using Dapper;
using FuaClinic.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FuaClinic.Business.Repositories
{
    public abstract class BaseRepository : IRepository
    {
        IDbConnection _connection;

        internal IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(@"Data Source = DESKTOP-PN05J6C\SQLEXPRESS;Initial Catalog= FuaClinic;Integrated Security =True;");
                    //_connection = new SqlConnection(@"Data Source = LAPTOP-II46HSN7\SQLEXPRESS;Initial Catalog= FuaClinic;Integrated Security =True;");
                }

                return _connection;
            }
        }

        internal abstract string TableName { get; }


        public bool Delete(int[] ids)
        {
            var sql = $@"DELETE FROM {TableName}
                        WHERE id IN @Ids";

            return Connection.Execute(sql, new { Ids = ids }) > 0;
        }

        public int Insert<T>(T data)
        {
            var fields = string.Join(",", data.GetType().GetProperties().Where(x =>
            {
                var propertyName = $"{x.Name}".ToLower();
                string[] toBeExcludedProperties =
                {
                    "id"
                };
                return !toBeExcludedProperties.Contains(propertyName);
            }).Select(x => $"{x.Name}"));

            var values = string.Join(",", data.GetType().GetProperties().Where(x =>
            {
                var propertyName = $"{x.Name}".ToLower();
                string[] toBeExcludedProperties =
                {
                    "id"
                };
                return !toBeExcludedProperties.Contains(propertyName);
            }).Select(x => $"@{x.Name}"));

            var sql = $@"DECLARE @SelectedId int;
                        INSERT INTO {TableName} ({fields})
                        VALUES ({values})
                        SET @SelectedId = SCOPE_IDENTITY();
                        SELECT @SelectedId";

            return Connection.Query<int>(sql, data).SingleOrDefault();
        }


        public IList<T> SelectAll<T>()
        {
            var sql = $@"SELECT * FROM {TableName}";

            return Connection.Query<T>(sql).ToList();
        }

        public T SelectById<T>(int id)
        {
            var sql = $@"SELECT * FROM {TableName} WHERE id = @Id";

            return Connection.Query<T>(sql, new { Id = id }).FirstOrDefault();
        }

        public IList<T> SelectWithWhereCondition<T>(string condition)
        {
            if (string.IsNullOrEmpty(condition))
            {
                throw new MissingFieldException("Condition not found.");
            }

            var sql = $@"SELECT * FROM {TableName} WHERE {condition}";

            return Connection.Query<T>(sql).ToList();
        }

        public bool Update<T>(T data)
        {
            var fields = string.Join(",", data.GetType().GetProperties().Where(x =>
            {
                var propertyName = $"{x.Name}".ToLower();
                string[] toBeExcludedProperties =
                {
                    "id", "createdon", "createdby"
                };
                return !toBeExcludedProperties.Contains(propertyName);
            }).Select(x => $"{x.Name} = @{x.Name}"));
            var sql = $@"UPDATE {TableName} SET {fields} WHERE id = @Id";

            return Connection.Execute(sql, data) > 0;
        }
    }
}
