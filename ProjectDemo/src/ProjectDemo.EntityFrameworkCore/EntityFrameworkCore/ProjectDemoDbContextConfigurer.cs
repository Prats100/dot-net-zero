using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProjectDemo.EntityFrameworkCore
{
    public static class ProjectDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjectDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjectDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}