using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Korisnik : IEntity
    {

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Datum_Rodjenja { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }
        public int Poeni { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public override bool Equals(object obj)
        {
            return obj is Korisnik korisnik &&

                   Email == korisnik.Email;
        }
        public string TableName => "Korisnik";

        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }

        public string PrimaryKeyName => "Id";
        public string[] ForeignKeyNames => null;
        [Browsable(false)]
        public string StrongObjectRefName => "";

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }
        public string Condition { get; set; }

        public string InsertParams => "@ime, @prezime, @datum, @email, @sifra, @poeni";

        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("email", Email));
                list.Add(new SqlParameter("sifra", Sifra));
                list.Add(new SqlParameter("ime", Ime));
                list.Add(new SqlParameter("prezime", Prezime));
                list.Add(new SqlParameter("datum", Datum_Rodjenja));
                list.Add(new SqlParameter("poeni", Poeni));

                return list;
            }

        }

        public List<SqlParameter> ListOfWhereParams
        {
            get; set;
        }

        public string UpdateParams => throw new NotImplementedException();

        public string MakeWhereQuery(params string[] paramsName)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            string where = "";
            foreach (string param in paramsName)
            {
                object value = this.GetType().GetProperty(param).GetValue(this);
                Console.WriteLine("Refl:" + value);
                list.Add(new SqlParameter(param, value));

                where += $"{param}=@{param},";
            }
            //brisemo zarez
            where = where.Remove(where.Length - 1);

            this.ListOfWhereParams = list;

            return where;
        }



        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> listKorisnici = new List<IEntity>();

                while (reader.Read())
                {
                    Korisnik k = new Korisnik()
                    {
                        Id = reader.GetInt32(0),
                        Ime = reader.GetString(1),
                        Prezime = reader.GetString(2),
                        Datum_Rodjenja = DateTime.Parse(reader["datum_rodjenja"].ToString()),
                        Email = reader.GetString(4),
                        Sifra = reader.GetString(5),
                        Poeni = reader.GetInt32(6),
                    };
                    listKorisnici.Add(k);

                }

                return listKorisnici;
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }
        }




    }
}
