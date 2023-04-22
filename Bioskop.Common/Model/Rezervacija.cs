using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Rezervacija : IEntity
    {
        //public int Id { get; set; }

        public Korisnik Korisnik { get; set; }
        public ProjekcijaFilma ProjekcijaFilma { get; set; }
        public DateTime Datum_Rezervacije { get; set; }
        public List<Sediste> ListSedistaSaDostupnosti { get; set; }
        public Film Film
        {
            get
            {
                if (ProjekcijaFilma != null)
                {
                    if (ProjekcijaFilma.Film != null)
                    {
                        return ProjekcijaFilma.Film;
                    }
                }
                return null;
            }
        }

        [Browsable(false)]
        public int Korisnik_Id
        {
            get
            {
                if (Korisnik != null)
                {
                    return Korisnik.Id;
                }
                return 0;
            }
        }
        //[Browsable(false)]
        public int Projekcija_Id
        {
            get
            {
                if (ProjekcijaFilma != null)
                {
                    return ProjekcijaFilma.Id;
                }
                return 0;
            }
        }

        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }

        [Browsable(false)]
        public List<Karta> ListKarta { get; set; }

        [Browsable(false)]
        public string TableName => "Rezervacija";

        //refaktorisati
        [Browsable(false)]
        public string[] SearchQueryFields { get; set; }

        [Browsable(false)]
        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();

                list.Add(new SqlParameter("korisnik_id", Korisnik.Id));
                list.Add(new SqlParameter("projekcija_id", ProjekcijaFilma.Id));
                list.Add(new SqlParameter("datum", Datum_Rezervacije));

                return list;
            }
        }

        [Browsable(false)]
        public string PrimaryKeyName => null;

        [Browsable(false)]
        public string[] ForeignKeyNames => new string[] { "korisnik_id", "projekcija_id" };

        [Browsable(false)]
        public string StrongObjectRefName => "";

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }


        [Browsable(false)]
        public string InsertParams => "@korisnik_id,@projekcija_id,@datum";
        [Browsable(false)]
        public string UpdateParams => "korisnik_id=@korisnik_id,projekcija_id=@projekcija_id,datum_rezervacije=@datum";
        [Browsable(false)]
        public List<SqlParameter> ListOfWhereParams { get; set; }

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }

        [Browsable(false)]
        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> list = new List<IEntity>();
                while (reader.Read())
                {
                    // da li je skraceni zapis
                    bool produzeni = reader.FieldCount == 26;

                    Console.WriteLine("**************");
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(i.ToString() + ":" + reader.GetName(i));
                    }
                    Console.WriteLine("Ovaj reader ima: " + reader.FieldCount);
                    Korisnik korisnik = new Korisnik()
                    {
                        //od 3 - 9 
                        Id = reader.GetInt32(3),
                        Ime = reader.GetString(4),
                        Prezime = reader.GetString(5),
                    };

                    //MessageBox.Show(reader.FieldCount.ToString());
                    Film f = new Film();
                    BioskopskaSala salica = new BioskopskaSala();
                    if (produzeni)
                    {
                        //16-23
                        f.Id = reader.GetInt32(16);
                        f.Naziv_Filma = reader.GetString(17);

                        //24-25
                        salica.Id = reader.GetInt32(24);
                        salica.Naziv_Sale = reader.GetString(25);

                    }
                    ProjekcijaFilma proj = new ProjekcijaFilma()
                    {
                        //10-15
                        Id = reader.GetInt32(10),
                        Datum_Projekcije = DateTime.Parse(reader[11].ToString()),
                        Cena_Karte = reader.GetDecimal(12),
                        BioskopskaSala = new BioskopskaSala()
                        {
                            Id = reader.GetInt32(14)
                        },


                    };
                    if (produzeni)
                    {
                        proj.Film = f;
                        proj.BioskopskaSala = salica;
                    }
                    Rezervacija p = new Rezervacija()
                    {
                        // od 0-2
                        Datum_Rezervacije = DateTime.Parse(reader[2].ToString()),
                        Korisnik = korisnik,
                        ProjekcijaFilma = proj

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
