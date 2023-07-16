using Microsoft.EntityFrameworkCore;

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
