using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LABIO.EntityFrameworkCore
{
    public static class LABIODbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LABIODbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LABIODbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
