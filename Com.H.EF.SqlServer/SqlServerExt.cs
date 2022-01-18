using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.H.EF.SqlServer
{
    public static class SqlServerExt
    {
        public static DbContext NewDbContext(this string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new DbContext(optionsBuilder.Options);
        }
    }
}
