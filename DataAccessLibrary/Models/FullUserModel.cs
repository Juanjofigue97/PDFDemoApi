﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class FullUserModel
    {
        public BasicUserModel BasicInfo { get; set; }

        public string LastName { get; set; }

        public string  Email { get; set; }


    }
}
