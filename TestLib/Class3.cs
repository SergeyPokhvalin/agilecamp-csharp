﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public  interface IDataBaseContent
    {
        IQueryable<T> Query<T>();
    }
}
