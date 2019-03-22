﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jun.Admin.Entity
{
    public class Sys_User:BaseEntity
    {

        public  string UserName { get; set; }

        public string UserPwd { get; set; }

        public string RealName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool? IsAdmin { get; set; }

    }
}
