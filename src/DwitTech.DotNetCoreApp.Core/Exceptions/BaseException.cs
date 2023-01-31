﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwitTech.DotNetCoreApp.Core.Exceptions
{
    public abstract class BaseException
    {
        public string? Message { get; set; }
        public Exception? Exception { get; set; }

    }
}