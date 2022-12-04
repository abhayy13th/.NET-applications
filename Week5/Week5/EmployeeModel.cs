﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Week5
{
    internal class EmployeeModel
    {
      
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            
            public string Position { get; set; }
            public DateOnly HireDate { get; set; }
        
    }
}
