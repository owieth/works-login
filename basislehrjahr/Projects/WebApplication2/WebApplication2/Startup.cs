using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            //Konfiguration wie angemeldet werden soll
            services.Configure<IdentityOptions>(
                options =>
                {
                    //passwort optionen
                    options.Password.RequireDigit = true; //muss zahlen haben
                    options.Password.RequireNonAlphanumeric = true; //sonderzeichen
                    options.Password.RequiredLength = 10; //mindestlänge passwort
                    options.Password.RequireLowercase = true;
                    options.Password.RequireUppercase = true;

                    //lockout optionen
                    options.Lockout.MaxFailedAccessAttempts = 3; //maximale anmeldeversuche
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10); //wartezeit bis zur automatischen abmeldung
                    options.Lockout.AllowedForNewUsers = true;

                    //benutzer opotionen
                    options.User.RequireUniqueEmail = true; //einmalige emailadresse beim registrieren

                });

            //cookie optionen
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true; //wie lange cookie gültig
                options.Cookie.Expiration = TimeSpan.FromMinutes(15); //wie lange darf cookie aktiv sein
            });

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
