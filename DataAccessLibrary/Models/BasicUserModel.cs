﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class BasicUserModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? Password { get; set; }

    }
}
