using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Administrator : IEntity
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }
        public string InsertParams => "@email, @sifra, @ime, @prezime";

        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("email", Email));
                list.Add(new SqlParameter("sifra", Sifra));
                list.Add(new SqlParameter("ime", Ime));
                list.Add(new SqlParameter("prezime", Prezime));

                return list;
            }


        }
        public List<SqlParameter> ListOfWhereParams
        {
            get; set;
        }



        public string TableName => "Administrator";

        public string PrimaryKeyName => "Id";
        public string[] ForeignKeyNames => null;

        public string StrongObjectRefName => "";

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }
        public string Condition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string UpdateParams => throw new NotImplementedException();

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> listAdmin = new List<IEntity>();
            while (reader.Read())
            {
                Administrator admin = new Administrator()
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Sifra = reader.GetString(2),
                    Ime = reader.GetString(3),
                    Prezime = reader.GetString(4),
                };
                listAdmin.Add(admin);
            }
            return listAdmin;
        }


    }
}
