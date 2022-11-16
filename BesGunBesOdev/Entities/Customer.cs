﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesGunBesOdev.Abstract;

namespace BesGunBesOdev.Entities
{
    public class Customer:Entity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
        
    }
}
