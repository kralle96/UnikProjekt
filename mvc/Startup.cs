using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Commands.CommandInterface;
using application.Commands.ObjectCommand;
using application.Commands.Repository;
using application.Queries.DtoInterface;
using bolig.Mvc.Data;
using infrastructure.Lejemaal;
using infrastructure.Lejemaal.Queries;
using infrastructure.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace mvc
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
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddDbContext<LejemaalContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("LejemaalConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddDbContext<LejemaalContext>(options =>
            //    options.UseSqlServer(Configuration["ConnectionStrings:LejemaalConnection"], x => x.MigrationsAssembly("Infrastructure")));


            services.AddScoped<ILejemaalQuery, LejemaalQuery>();
            services.AddScoped<ILejemaalCommand, LejemaalCommand>();
            services.AddScoped<ILejemaalRepository, LejemaalRepository>();
            services.AddCors();

            //option configuration of identity
            services.Configure<IdentityOptions>(options =>
            {
                //password settings
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = true;

                //lockout settings
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

                //user settings
                options.User.RequireUniqueEmail = true;
            });

            //Cookie configuration
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => {
                    options.LoginPath = "/Account/Login";
                    options.LogoutPath = "/Account/Logout";
                    options.Cookie.Name = "auth20_cookie";
                    options.Cookie.HttpOnly = false;
                    options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.None;
                });

            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
          

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
