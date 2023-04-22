using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Reziser : IEntity
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public override bool Equals(object obj)
        {
            return obj is Reziser reziser &&
                   Id == reziser.Id;
        }

        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }

        [Browsable(false)]
        public string TableName => "Reziser";
        [Browsable(false)]
        public string PrimaryKeyName => "Id";

        [Browsable(false)]
        public string[] ForeignKeyNames => null;
        [Browsable(false)]
        public string StrongObjectRefName => "";

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }

        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("id", Id));
                list.Add(new SqlParameter("ime", Ime));
                list.Add(new SqlParameter("Prezime", Prezime));

                return list;
            }
        }

        public string InsertParams => "@id,@ime,@prezime";

        public List<SqlParameter> ListOfWhereParams { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string UpdateParams => throw new NotImplementedException();

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                Reziser reziser = new Reziser()
                {
                    Id = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                };
                list.Add(reziser);
            }

            return list;
        }





    }
}
