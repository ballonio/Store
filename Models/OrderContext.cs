﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}