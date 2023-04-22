using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    [Serializable]
    public class BioskopskaSala : IEntity
    {
        public int Id { get; set; }
        public string Naziv_Sale { get; set; }

        [Browsable(false)]
        public List<Sediste> ListSedista { get; set; }

        [Browsable(false)]
        public List<Sediste> ListaSedistaZaBrisanje { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BioskopskaSala sala &&
                   Id == sala.Id;
        }

        public override string ToString()
        {
            return Naziv_Sale;
        }

        [Browsable(false)]
        public string TableName => "BioskopskaSala";
        [Browsable(false)]
        public List<SqlParameter> ListOfAllParams
        {
            get
            {
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("naziv", Naziv_Sale));
                return list;
            }
        }
        [Browsable(false)]
        public FilterField[] FilterFields { get; set; }
        [Browsable(false)]
        public string PrimaryKeyName => "Id";

        [Browsable(false)]
        public string[] ForeignKeyNames => null;
        [Browsable(false)]
        public string StrongObjectRefName => "";

        [Browsable(false)]
        public FilterField[] FilterFieldsJoin { get; set; }

        [Browsable(false)]
        public string InsertParams => "@naziv";
        [Browsable(false)]
        public string UpdateParams => "naziv_sale=@naziv";

        [Browsable(false)]
        public JoinHelper[] JoinHelper { get; set; }

        [Browsable(false)]
        public List<SqlParameter> ListOfWhereParams { get; set; }



        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                BioskopskaSala sala = new BioskopskaSala()
                {
                    Id = reader.GetInt32(0),
                    Naziv_Sale = reader.GetString(1),
                };
                lista.Add(sala);
            }
            return lista;
        }




    }
}
