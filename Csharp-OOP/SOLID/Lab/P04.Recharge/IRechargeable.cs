﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04.Recharge
{
    public interface IRechargeable
    {
        void Recharge();

        public int Capacity { get;}
        public int CurrentPower { get;}
    }
}
