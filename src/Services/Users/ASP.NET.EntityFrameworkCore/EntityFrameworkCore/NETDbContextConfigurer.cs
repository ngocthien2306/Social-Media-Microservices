using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.EntityFrameworkCore
{
    public static class NETDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NETDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NETDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
