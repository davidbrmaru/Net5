﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net5.Examen.Client.Data;

[assembly: HostingStartup(typeof(Net5.Examen.Client.Areas.Identity.IdentityHostingStartup))]
namespace Net5.Examen.Client.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SecurityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SecurityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SecurityContext>();
            });
        }
    }
}