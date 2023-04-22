using Bioskop.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bioskop.Repository
{
    public class GenericDbRepository : IDbRepository<IEntity>
    {
        public List<IEntity> VratiJoin(IEntity entity, FilterField[] filterFields, params IEntity[] entitiesJoin)
        {
            List<IEntity> listEntity = new List<IEntity>();

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand("");

            string[] spoljniKljucevi = entity.ForeignKeyNames;

            string str = $"select * from {entity.TableName} ";

            int brojac = 0;

            foreach (IEntity entityX in entitiesJoin)
            {
                str +=
                $" join {entityX.TableName} " +
                $" on {entityX.TableName}.{entityX.PrimaryKeyName}={entity.TableName}.{spoljniKljucevi[brojac]} ";
                brojac++;


            }
            foreach (IEntity entityX in entitiesJoin)
            {
                // dodajemo dodatne joinove na kraj
                if (entityX.JoinHelper != null)
                {
                    foreach (JoinHelper helper in entityX.JoinHelper)
                    {
                        str += $" join {helper.JoinTable.TableName} " +
                               $" on {helper.JoinTable.TableName}.{helper.JoinTable.PrimaryKeyName} " +
                               $" = {entityX.TableName}.{helper.ForeignKeyName}";
                    }

                }

            }


            str += $"  where {MakeWhereQuery(entity, filterFields)}";


            foreach (IEntity entityX in entitiesJoin)
            {
                //ako svaki join ima neki svoj uslov
                if (entityX.FilterFieldsJoin != null)
                {
                    str += $" and {MakeWhereQuery(entityX, entityX.FilterFieldsJoin)}";

                    foreach (SqlParameter param in entityX.ListOfWhereParams)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
            }

            //System.Windows.Forms.MessageBox.Show(str);

            if (entity.ListOfWhereParams != null)
                foreach (SqlParameter param in entity.ListOfWhereParams)
                {
                    cmd.Parameters.Add(param);
                }

            //System.Windows.Forms.MessageBox.Show(str);
            cmd.CommandText = str;
            SqlDataReader reader = cmd.ExecuteReader();
            listEntity = entity.GetList(reader);
            reader.Close();

            return listEntity;

        }
        public List<IEntity> VratiSveJoin(IEntity entity, params IEntity[] entitiesJoin)
        {
            List<IEntity> listEntity = new List<IEntity>();

            string[] spoljniKljucevi = entity.ForeignKeyNames;

            string str = $"select * from {entity.TableName} ";

            int brojac = 0;

            foreach (IEntity entityX in entitiesJoin)
            {
                str +=
                $" join {entityX.TableName} " +
                $" on {entityX.TableName}.{entityX.PrimaryKeyName}={entity.TableName}.{spoljniKljucevi[brojac]} ";
                brojac++;
            }


            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(str);


            SqlDataReader reader = cmd.ExecuteReader();
            listEntity = entity.GetList(reader);
            reader.Close();

            return listEntity;

        }
        public List<IEntity> VratiSve(IEntity entity)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"select * from {entity.TableName}");
            SqlDataReader reader = cmd.ExecuteReader();
            List<IEntity> list = entity.GetList(reader);
            reader.Close();
            return list;
        }
        public List<IEntity> Pretrazi(IEntity entity, params FilterField[] filterFields)
        {
            //throw new Exception("Moras baciti");
            string s = $"select * from {entity.TableName} where {MakeWhereQuery(entity, filterFields)}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(s);

            if (entity.ListOfWhereParams != null)
                foreach (SqlParameter param in entity.ListOfWhereParams)
                {
                    cmd.Parameters.Add(param);
                }
            Console.WriteLine(s);
            SqlDataReader reader = cmd.ExecuteReader();
            List<IEntity> list = entity.GetList(reader);

            reader.Close();
            return list;
        }

        public void Dodaj(IEntity entity)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand("");
            string s = $"insert into {entity.TableName} ";

            if (entity.PrimaryKeyName != null)
                s += $" output inserted.{entity.PrimaryKeyName} ";

            s += $"values({entity.InsertParams}) ";
            cmd.CommandText = s;
            foreach (SqlParameter param in entity.ListOfAllParams)
            {
                cmd.Parameters.Add(param);
            }
            if (entity.PrimaryKeyName != null)
            {
                int x = (int)cmd.ExecuteScalar();
                entity.GetType().GetProperty(entity.PrimaryKeyName).SetValue(entity, x);
                Console.WriteLine(x);
            }
            else
            {
                int x1 = cmd.ExecuteNonQuery();
                Console.WriteLine(x1);
            }

        }
        public void Azuriraj(IEntity entity, params FilterField[] filterField)
        {

            /* Film f = (Film)entity;
             Console.WriteLine(f.Id.ToString());*/
            string s = $"update {entity.TableName} set {entity.UpdateParams} where {MakeWhereQuery(entity, filterField)}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(s);

            foreach (SqlParameter param in entity.ListOfAllParams)
            {
                cmd.Parameters.Add(param);
            }
            foreach (SqlParameter param in entity.ListOfWhereParams)
            {
                cmd.Parameters.Add(param);
            }

            int x = cmd.ExecuteNonQuery();
            Console.WriteLine("rows affected: " + x);


        }
        public void Obrisi(IEntity entity, params FilterField[] filterFields)
        {
            string s = $"delete from {entity.TableName} where {MakeWhereQuery(entity, filterFields)}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(s);

            foreach (SqlParameter param in entity.ListOfWhereParams)
            {
                cmd.Parameters.Add(param);
            }

            int x = cmd.ExecuteNonQuery();
            Console.WriteLine("rows affected: " + x);
        }
        public IEntity Vrati(IEntity entity, params FilterField[] filterFields)
        {
            string s = $"select * from {entity.TableName} where {MakeWhereQuery(entity, filterFields)}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(s);

            foreach (SqlParameter param in entity.ListOfWhereParams)
            {
                cmd.Parameters.Add(param);
            }
            Console.WriteLine(s);
            SqlDataReader reader = cmd.ExecuteReader();
            List<IEntity> list = entity.GetList(reader);

            reader.Close();
            if (list.Count > 0) return list[0];
            return null;

        }

        public string MakeWhereQuery(IEntity entity, params FilterField[] paramsName)
        {
            if (paramsName == null) return "1=1";
            if (paramsName.Length <= 0) return "1=1";
            List<SqlParameter> list = new List<SqlParameter>();

            string where = "";
            if (paramsName == null) throw new Exception("Unesite uslov pretrage!");
            foreach (FilterField param in paramsName)
            {
                string field = param.FieldName;
                object value = entity.GetType().GetProperty(field).GetValue(entity);
                Console.WriteLine("Refl:" + value);
                list.Add(new SqlParameter(field, value));


                if (param.FilterType == FilterType.FieldEquality)
                    where += $" {entity.TableName}.{field} = @{field} and";

                else if (param.FilterType == FilterType.ManualComparation)
                {
                    where += $" {param.LeftSideCondition} and";
                }
            }

            //brisemo and
            where = where.Remove(where.Length - 1);
            where = where.Remove(where.Length - 1);
            where = where.Remove(where.Length - 1);

            entity.ListOfWhereParams = list;


            return where;
        }
        public void Close()
        {
            DbConnectionFactory.Instance.GetDbConnection().Close();
        }
        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }
        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();
        }

    }
}
