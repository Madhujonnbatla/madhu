using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Code_First.Models
{
    public class commonContext:DbContext
    {
        public DbSet<Emp> Emps { get; set; }
    }
}