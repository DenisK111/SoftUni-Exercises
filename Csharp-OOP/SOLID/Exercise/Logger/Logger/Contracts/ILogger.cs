﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface ILogger
    {
        void Log(string date, string level, string data);

    }
}
