using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Managers.Interfaces
{
    public interface IManager
    {
        int Add<T>(T data);
        bool Update<T>(T data);
        bool Delete(int[] ids);
        T GetById<T>(int id);
        IList<T> GetAll<T>();

        IList<T> GetWithWhereCondition<T>(string condition);
    }
}
