using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Zanr : IEntity
    {
        public int Id { get; set; }
        public string Ime_Zanra { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Zanr zanr &&
                   Id == zanr.Id &&
                   Ime_Zanra == zanr.Ime_Zanra;
        }
        public override string ToString()
        {
            return Ime_Zanra;
        }
        public string TableName => "Zanr";

        public string PrimaryKeyName => "Id";
        public string[] ForeignKeyNames => null;
        [Browsable(false)]
        public string StrongObjectRefName => "";

        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }
        public string InsertParams => "@ime";

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }

        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> listParameter = new List<SqlParameter>();
                listParameter.Add(new SqlParameter("ime", Ime_Zanra));
                return listParameter;
            }

        }

        public List<SqlParameter> ListOfWhereParams
        {
            get; set;
        }

        public string UpdateParams => throw new NotImplementedException();



        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                Zanr zanr = new Zanr()
                {
                    Id = reader.GetInt32(0),
                    Ime_Zanra = reader.GetString(1),
                };
                list.Add(zanr);
            }

            return list;
        }






    }
}
