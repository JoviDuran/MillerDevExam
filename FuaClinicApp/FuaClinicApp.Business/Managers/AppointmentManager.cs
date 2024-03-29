﻿using FuaClinicApp.Business.Managers.Interfaces;
using FuaClinicApp.Business.Repositories;
using FuaClinicApp.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuaClinicApp.Business.Entities;

namespace FuaClinicApp.Business.Managers
{
    public class AppointmentManager : BaseManager, IAppointmentManager
    {
        internal override IRepository Repository => new AppointmentRepository();
    }
}
