using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Film : IEntity
    {
        public int Id { get; set; }
        public string Naziv_Filma { get; set; }
        public string Opis_Filma { get; set; }
        public int Trajanje_U_Minutima { get; set; }
        public DateTime Datum_Premijere { get; set; }
        public Reziser Reziser { get; set; }
        public Zanr Zanr { get; set; }
        public Administrator Administrator { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Film film &&
                   Id == film.Id;
        }

        public override string ToString()
        {
            return Naziv_Filma;
        }


        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }

        [Browsable(false)]
        public string TableName => "Film";

        [Browsable(false)]
        public string PrimaryKeyName => "Id";
        [Browsable(false)]
        public string StrongObjectRefName => "";

        [Browsable(false)]
        public string SearchQuery { get; set; }

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }
        public string[] ForeignKeyNames
        {
            get
            {
                return new string[] { "reziser_id", "zanr_id", "administrator_id" };
            }
        }
        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }
        [Browsable(false)]
        public string InsertParams => "@naziv, @opis, @trajanje, @datum, @reziser, @zanr, @admin";

        [Browsable(false)]
        public string UpdateParams => "naziv_filma=@naziv, opis_filma=@opis, trajanje_u_minutima=@trajanje, datum_premijere = @datum, reziser_id = @reziser, zanr_id = @zanr, administrator_id = @admin";
        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("naziv", Naziv_Filma));
                list.Add(new SqlParameter("opis", Opis_Filma));
                list.Add(new SqlParameter("trajanje", Trajanje_U_Minutima));
                list.Add(new SqlParameter("datum", Datum_Premijere));
                list.Add(new SqlParameter("reziser", Reziser.Id));
                list.Add(new SqlParameter("zanr", Zanr.Id));
                list.Add(new SqlParameter("admin", Administrator.Id));
                return list;
            }

        }

        public List<SqlParameter> ListOfWhereParams
        {
            get; set;
        }



        public List<IEntity> GetList(SqlDataReader reader)
        {

            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                if (reader.FieldCount < 18)//kraci zapis, samo za pretragu
                {
                    Film kratki = new Film()
                    {
                        Id = reader.GetInt32(0),
                        Naziv_Filma = reader.GetString(1),
                        Opis_Filma = reader.GetString(2),
                        Trajanje_U_Minutima = reader.GetInt32(3),
                        Datum_Premijere = reader.GetDateTime(4),

                    };
                    list.Add(kratki);
                    continue;
                }
                Reziser r = new Reziser()
                {
                    Id = reader.GetInt32(8),
                    Ime = reader.GetString(9),
                    Prezime = reader.GetString(10),
                };
                Zanr z = new Zanr()
                {
                    Id = reader.GetInt32(11),
                    Ime_Zanra = reader.GetString(12),
                };
                Administrator a = new Administrator()
                {
                    Id = reader.GetInt32(13),
                    Email = reader.GetString(14),
                    Sifra = reader.GetString(15),
                    Ime = reader.GetString(16),
                    Prezime = reader.GetString(17)
                };
                Film f = new Film()
                {
                    Id = reader.GetInt32(0),
                    Naziv_Filma = reader.GetString(1),
                    Opis_Filma = reader.GetString(2),
                    Trajanje_U_Minutima = reader.GetInt32(3),
                    Datum_Premijere = reader.GetDateTime(4),
                    Reziser = r,
                    Zanr = z,
                    Administrator = a
                };
                list.Add(f);
            }
            return list;
        }




    }
}
