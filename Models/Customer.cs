using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WFDB.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}