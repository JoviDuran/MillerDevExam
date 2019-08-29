﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Managers.ManagerInterfaces
{
    public interface IPatientManager:IManager
    {
        DataTable GetAll();
        DataTable GetBySearch(DynamicParameters param);

    }
}
