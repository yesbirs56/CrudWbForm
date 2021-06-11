using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WFDB.Models;

namespace WFDB.Data
{
    public class ContextDemo:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}