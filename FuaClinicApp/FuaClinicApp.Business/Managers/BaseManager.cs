using FuaClinicApp.Business.Managers.Interfaces;
using FuaClinicApp.Business.Repositories;
using FuaClinicApp.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Managers
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
        public IList<T> GetAll<T>()
        {
            return Repository.SelectAll<T>();
        }

        public IList<T> GetWithWhereCondition<T>(string condition)
        {
            return Repository.SelectWithWhereCondition<T>(condition);
        }
    }
}
