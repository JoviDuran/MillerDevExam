using FuaClinic.Business.Managers.ManagerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuaClinic.Business.Repositories.Interfaces;
using FuaClinic.Business.Repositories;

namespace FuaClinic.Business.Managers
{
    public class TestResultManager : BaseManager, ITestResultManager
    {
        internal override IRepository Repository => new TestResutlRepository();
        
    }
}
