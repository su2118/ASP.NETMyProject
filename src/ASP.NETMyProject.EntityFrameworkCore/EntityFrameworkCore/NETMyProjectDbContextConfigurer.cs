using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETMyProject.EntityFrameworkCore
{
    public static class NETMyProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NETMyProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NETMyProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
