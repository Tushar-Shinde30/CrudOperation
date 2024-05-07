using CrudOperationInOnePage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudOperationInOnePage.Context
{
    public class JsonContext : DbContext
    {
        public DbSet<Users> ObjUser { get; set; }
    }
}