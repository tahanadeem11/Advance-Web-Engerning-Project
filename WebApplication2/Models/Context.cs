﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication2.Models
{
    public class EmpContext : DbContext

    {

        public DbSet<employe> Employees { get; set; }

    }
}