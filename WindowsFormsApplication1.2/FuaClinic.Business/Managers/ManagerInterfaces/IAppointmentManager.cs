﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Managers.ManagerInterfaces
{
    public interface IAppointmentManager : IManager
    {
        DataTable GetAll();
        DataTable GetByDate(String date);
        DataTable GetByTime(DateTime time);
        DataTable GetByPatientId(int id);

        
        
    }
}
