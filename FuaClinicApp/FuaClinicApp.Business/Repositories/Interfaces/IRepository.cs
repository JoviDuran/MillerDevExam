using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Repositories.Interfaces
{
    internal interface IRepository
    {
        int Insert<T>(T data);
        bool Update<T>(T data);
        bool Delete(int[] ids);
        IList<T> SelectAll<T>();
        T SelectById<T>(int id);
        IList<T> SelectWithWhereCondition<T>(string condition);
    }
}
