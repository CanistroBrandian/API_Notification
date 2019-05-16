using API_Notification.Helpers;
using API_Notification.Interfaces;
using API_Notification.Models;   // пространство имен моделей
using API_Notification.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore; // пространство имен EntityFramework
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API_Notification
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NotificationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddSingleton<INotificationService, EmailNotificationServicce>();
            services.AddSingleton<INotificationService, SmsNotificationService>();
            services.AddSingleton<INotificationManager, NotificationManager>();
            services.AddSingleton<INotificationScheduler, NotificationScheduler>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}