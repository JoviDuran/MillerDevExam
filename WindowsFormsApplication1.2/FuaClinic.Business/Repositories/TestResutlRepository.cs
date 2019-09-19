using FuaClinic.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Repositories
{
    public class TestResutlRepository : BaseRepository, ITestResultRepository
    {
        internal override string TableName => "TestResults";
       
    }
}
