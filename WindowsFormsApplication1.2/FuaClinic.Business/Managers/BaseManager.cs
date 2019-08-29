using FuaClinic.Business.Managers.ManagerInterfaces;
using FuaClinic.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FuaClinic.Business.Managers
{
    public abstract class BaseManager : IManager
    {
        internal abstract IRepository Repository { get; }
        public int Add<T>(T data)
        {
            return Repository.Insert(data);
        }

        public bool Delete(int[] ids)
        {
            return Repository.Delete(ids);
        }

        public bool Update<T>(T data)
        {
            return Repository.Update(data);
        }

        public T GetById<T>(int id)
        {
            return Repository.SelectById<T>(id);
        }

        public IList<T> GetWithWhereCondition<T>(string condition)
        {
            return Repository.SelectWithWhereCondition<T>(condition);
        }
       
        public IList<T> GetAll<T>()
        {
            return Repository.SelectAll<T>();
        }


        // TODO: Find a way to add generic method for creating dataTable
        //public DataTable CreateDataTable<T>(IList<T> data)
        //{

        //    var entity = data.First();
        //    var properties = entity.GetType().GetProperties().Select(x => x.Name);
        //    var dataTable = new DataTable();

        //    foreach (var property in properties)
        //    {
        //        dataTable.Columns.Add(property.ToString());
        //    }

        //    foreach (var item in data)
        //    {
        //    DataRow dataRow = dataTable.NewRow();


        //    }
        //    //var prop = properties.ToArray().Trim();

        //    //for (int i = 0; i < dataTable.Columns.Count; i++)
        //    //{
        //    //    for (int j = 0; j < properties.ToArray().Length; j++)
        //    //    {
        //    //        dataRow[i] = prop[j];
        //    //    }
        //    //}

        //    //dataTable.Rows.Add(dataRow);
        //    return dataTable;
        //}


    }
}
