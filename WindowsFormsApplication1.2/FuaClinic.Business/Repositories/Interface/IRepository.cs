﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Repositories
{
    interface IRepository
    {
        int Insert<T>(T data);
    }
}