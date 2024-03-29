﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Viewtance.ERP.Configuration;
using Viewtance.ERP.Web;

namespace Viewtance.ERP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ERPDbContextFactory : IDesignTimeDbContextFactory<ERPDbContext>
    {
        public ERPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ERPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ERPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ERPConsts.ConnectionStringName));

            return new ERPDbContext(builder.Options);
        }
    }
}
