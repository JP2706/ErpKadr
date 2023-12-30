﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpKadr
{
    public class Employee
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateToEmploy {  get; set; }
        public decimal Paycheck { get; set; }
        public string EmployeeNumer { get; set; }
        public string Comments {  get; set; }
        public DateTime? DateSlowDown { get; set; }

    }
}
