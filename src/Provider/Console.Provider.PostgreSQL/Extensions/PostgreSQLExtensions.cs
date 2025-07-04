﻿using Console.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Console.Provider.PostgreSQL.Extensions;

public static class PostgreSQLExtensions
{
    public static IServiceCollection AddPostgreSQL(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<IDbContext, PostgreSQLDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
            // 不输出日志
            options.EnableSensitiveDataLogging(false);
        });
        
        return services;
    }
}