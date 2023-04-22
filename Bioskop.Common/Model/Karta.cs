using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Karta : IEntity
    {

        public int Korisnik_Id { get; set; }

        public int Projekcija_Id { get; set; }

        public int Karta_Id { get; set; }

        public Sediste Sediste { get; set; }

        public int Sala_Id
        {
            get
            {
                if (Sediste == null)
                {
                    return 0;
                }
                return Sediste.Sala_Id;
            }
        }
        public int Sediste_Id
        {
            get
            {
                if (Sediste == null)
                {
                    return 0;
                }
                return Sediste.Sediste_Id;
            }
        }
        public string TableName => "Karta";

        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }
        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();

                //list.Add(new SqlParameter("rezervacija_id", Rezervacija_Id));

                list.Add(new SqlParameter("korisnik_id", Korisnik_Id));
                list.Add(new SqlParameter("projekcija_id", Projekcija_Id));
                list.Add(new SqlParameter("sala_id", Sediste.Sala_Id));
                list.Add(new SqlParameter("sediste_id", Sediste.Sediste_Id));

                return list;
            }
        }

        public string PrimaryKeyName => "Karta_Id";

        public string[] ForeignKeyNames => new string[] { "korisnik_id", "projekcija_id" };

        public string StrongObjectRefName => throw new NotImplementedException();

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }
        public string InsertParams => "@korisnik_id,@projekcija_id,@sala_id,@sediste_id";

        public string UpdateParams => "korisnik_id = @korisnik_id, projekcija_id = @projekcija_id, sala_id = @sala_id,sediste_id = @sediste_id";

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }
        public List<SqlParameter> ListOfWhereParams { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> list = new List<IEntity>();
                while (reader.Read())
                {
                    Rezervacija rezervacija = new Rezervacija()
                    {
                        //4-7
                        //izmeni indekse jer sam dodao polje
                        //Id = reader.GetInt32(4),
                        /* Korisnik = new Korisnik() { Id = reader.GetInt32(5) },
                         ProjekcijaFilma = new ProjekcijaFilma() { Id = reader.GetInt32(6) },
                         Datum_Rezervacije = DateTime.Parse(reader[7].ToString()),*/


                    };

                    Karta k = new Karta()
                    {
                        // indeksi 0-4
                        Korisnik_Id = reader.GetInt32(0),
                        Projekcija_Id = reader.GetInt32(1),
                        Karta_Id = reader.GetInt32(2),
                        Sediste = new Sediste()
                        {
                            Sala_Id = reader.GetInt32(3),
                            Sediste_Id = reader.GetInt32(4),
                        }

                    };
                    /*if (reader.FieldCount > 5)
                    {
                        Korisnik koca = new Korisnik()
                        {
                            //5-11
                        };
                        ProjekcijaFilma p = new ProjekcijaFilma()
                        {
                            Id = reader.GetInt32(12),
                            Datum_Projekcije = DateTime.Parse(reader.GetString(13)),
                        };

                    }*/

                    list.Add(k);
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
