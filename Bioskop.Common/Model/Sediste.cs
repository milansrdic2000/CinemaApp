using Bioskop.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class Sediste : IEntity
    {
        public int Sediste_Id { get; set; }
        public int Red { get; set; }
        public int Kolona { get; set; }

        public CrudStatus CrudStatus { get; set; }

        //[Browsable(false)]
        public bool Rezervisano { get; set; }
        public bool MojeRezervisano { get; set; }

        public override string ToString()
        {
            return $"Red:{Red}, Kolona:{Kolona}";
        }

        [Browsable(false)]
        public int Sala_Id { get; set; }

        [Browsable(false)]
        public string TableName => "Sediste";

        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }

        [Browsable(false)]

        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("sala_id", Sala_Id));
                list.Add(new SqlParameter("red", Red));
                list.Add(new SqlParameter("kolona", Kolona));
                return list;
            }

        }



        [Browsable(false)]
        public string PrimaryKeyName => "Sediste_Id";
        [Browsable(false)]
        public string[] ForeignKeyNames => new string[] { "Sala_Id" };

        [Browsable(false)]
        public string StrongObjectRefName => "Sala_Id";

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }

        [Browsable(false)]
        public string InsertParams => "@sala_id,@red,@kolona";
        [Browsable(false)]
        public string UpdateParams => "sala_id=@sala_id,red = @red, kolona = @kolona";
        [Browsable(false)]
        public List<SqlParameter> ListOfWhereParams { get; set; }
        [Browsable(false)]
        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                Sediste s = new Sediste()
                {
                    Sediste_Id = reader.GetInt32(1),
                    Sala_Id = reader.GetInt32(0),
                    Red = reader.GetInt32(2),
                    Kolona = reader.GetInt32(3),
                };
                list.Add(s);
            }
            return list;
        }


    }
}
