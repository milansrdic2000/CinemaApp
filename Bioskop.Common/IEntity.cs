using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bioskop.Common
{
    public interface IEntity
    {

        string TableName { get; }

        //za join
        string PrimaryKeyName { get; }
        string[] ForeignKeyNames { get; }

        string StrongObjectRefName { get; }

        FilterField[] FilterFieldsJoin { get; set; }

        FilterField[] FilterFields { get; set; }

        JoinHelper[] JoinHelper { get; set; }

        List<SqlParameter> ListOfAllParams { get; }
        //insert

        string InsertParams { get; }

        //za update

        string UpdateParams { get; }

        //where
        List<SqlParameter> ListOfWhereParams { get; set; }

        List<IEntity> GetList(SqlDataReader reader);
    }
}
