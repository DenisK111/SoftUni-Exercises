﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Cat : Animal
    {
        string sound = "Meow meow";
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }
        protected override string Sound { get { return this.sound; } set { } }
    }
}
