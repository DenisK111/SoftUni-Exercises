﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationAttributes.Attributes
{

    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            
            return !string.IsNullOrWhiteSpace((string)obj);

        }
    }
}
