using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Managers.ManagerInterfaces
{
    public interface IManager
    {
        int Add<T>(T data);
        bool Update<T>(T data);
        bool Delete(int[] ids);
        T GetById<T>(int id);
        IList<T> GetWithWhereCondition<T>(string condition);
        IList<T> GetAll<T>();



    }
}
