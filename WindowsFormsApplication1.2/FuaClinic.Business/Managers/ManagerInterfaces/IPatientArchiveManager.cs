﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Managers.ManagerInterfaces
{
    public interface IPatientArchiveManager : IManager
    {
        DataTable GetAll();
    }
}
