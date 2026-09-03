using System;
using Dapper.Extensions.Monitor;
using Microsoft.Extensions.DependencyInjection;

namespace Dapper.Extensions.PostgreSql
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDapperForPostgreSQL(this IServiceCollection services, Action<MonitorBuilder> monitorBuilder = null)
        {
            return services.AddDapper<PostgreSqlDapper>(monitorBuilder);
        }

        public static IServiceCollection AddDapperForPostgreSQL(this IServiceCollection services, string connectionName, Action<MonitorBuilder> monitorBuilder = null)
        {
            return services.AddDapper<PostgreSqlDapper>(connectionName, monitorBuilder);
        }
    }
}
