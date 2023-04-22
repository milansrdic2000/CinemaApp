using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class ProjekcijaFilma : IEntity
    {
        public int Id { get; set; }
        public DateTime Datum_Projekcije { get; set; }
        public decimal Cena_Karte { get; set; }

        [Browsable(false)]
        public TipProjekcije Tip_Projekcije { get; set; }

        public string TipProjekcije => Tip_Projekcije.ToString().Remove(0, 1);


        public BioskopskaSala BioskopskaSala { get; set; }
        public Film Film { get; set; }

        public int Film_Id
        {
            get
            {
                if (Film == null) return -1;
                else return Film.Id;
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"Sala: {BioskopskaSala?.Naziv_Sale} u {Datum_Projekcije.ToShortDateString()}, {Datum_Projekcije.ToShortTimeString()}";
        }
        [Browsable(false)]
        public string TableName => "ProjekcijaFilma";


        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }

        [Browsable(false)]
        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();
                //list.Add(new SqlParameter("id", Id));
                list.Add(new SqlParameter("datum", Datum_Projekcije));
                list.Add(new SqlParameter("cena", Cena_Karte));
                list.Add(new SqlParameter("tip", Tip_Projekcije));

                list.Add(new SqlParameter("sala_id", BioskopskaSala.Id));
                list.Add(new SqlParameter("film_id", Film.Id));

                return list;
            }

        }
        [Browsable(false)]
        public string PrimaryKeyName => "Id";
        [Browsable(false)]
        public string[] ForeignKeyNames => new string[] { "Sala_Id", "Film_Id" };

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }
        [Browsable(false)]
        public string StrongObjectRefName => "";

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }

        [Browsable(false)]
        public string InsertParams => "@datum, @cena, @tip, @sala_id,@film_id";
        [Browsable(false)]
        public string UpdateParams => "datum_projekcije=@datum, cena_karte = @cena, tip_projekcije=@tip, sala_id = @sala_id, film_id=@film_id";
        [Browsable(false)]
        public List<SqlParameter> ListOfWhereParams { get; set; }


        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> list = new List<IEntity>();
                while (reader.Read())
                {
                    BioskopskaSala sala = new BioskopskaSala()
                    {
                        Id = reader.GetInt32(6),
                        Naziv_Sale = reader.GetString(7),
                    };
                    string s = reader[9].ToString();
                    Film film = new Film()
                    {
                        Id = reader.GetInt32(8),

                        Naziv_Filma = reader.GetString(9),
                        Datum_Premijere = DateTime.Parse(reader[12].ToString()),
                    };
                    ProjekcijaFilma p = new ProjekcijaFilma()
                    {
                        Id = reader.GetInt32(0),
                        Datum_Projekcije = DateTime.Parse(reader[1].ToString()),
                        Cena_Karte = reader.GetDecimal(2),
                        Tip_Projekcije = (TipProjekcije)reader.GetInt32(3),
                        BioskopskaSala = sala,
                        Film = film

                    };
                    list.Add(p);
                }

                return list;
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }
        }



    }
}
