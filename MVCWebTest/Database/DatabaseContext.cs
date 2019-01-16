using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebTest.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("")
        {

        }
    }
}