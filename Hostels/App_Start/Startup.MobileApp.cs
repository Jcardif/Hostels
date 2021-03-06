﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Authentication;
using Microsoft.Azure.Mobile.Server.Config;
using Hostels.DataObjects;
using Hostels.Models;
using Owin;

namespace Hostels
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

            // Use Entity Framework Code First to create database tables based on your DbContext
            //Database.SetInitializer(new MobileServiceInitializer());

            //MobileAppSettingsDictionary settings = config.GetMobileAppSettingsProvider().GetMobileAppSettings();

            //if (string.IsNullOrEmpty(settings.HostName))
            //{
            //    app.UseAppServiceAuthentication(new AppServiceAuthenticationOptions
            //    {
            //        // This mIDdleware is intended to be used locally for debugging. By default, HostName will
            //        // only have a value when running in an App Service application.
            //        SigningKey = ConfigurationManager.AppSettings["SigningKey"],
            //        ValidAudiences = new[] { ConfigurationManager.AppSettings["ValIDAudience"] },
            //        ValidIssuers = new[] { ConfigurationManager.AppSettings["ValIDIssuer"] },
            //        TokenHandler = config.GetAppServiceTokenHandler()
            //    });
            //}

            //app.UseWebApi(config);
        }
    }

    //public class MobileServiceInitializer : CreateDatabaseIfNotExists<HostelsContext>
    //{
    //    protected override void Seed(HostelsContext context)
    //    {
    //        List<Employee> emp = new List<Employee>
    //        {
    //            new Employee { ID = 1, FrstName = "Josh", LastName = "Cardif", Phone = "0723333"},
    //        };

    //        foreach (Employee employee in emp)
    //        {
    //            context.Set<Employee>().Add(employee);
    //        }

    //        base.Seed(context);
    //    }
    //}
}

