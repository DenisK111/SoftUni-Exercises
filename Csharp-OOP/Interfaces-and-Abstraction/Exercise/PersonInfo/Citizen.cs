﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen
        : IPerson, IBirthable, IIdentifiable
    {
       
        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthDate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set  ; }
        public string Birthdate { get; set ; }
    }
}
