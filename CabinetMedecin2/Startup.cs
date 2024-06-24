using CabinetMedecin2.Data;
using Microsoft.EntityFrameworkCore;

namespace CabinetMedecin2
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
            services.AddDbContext<GestionDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnectionDb")));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "patientDashboard",
                pattern: "patient/dashboard",
                defaults: new { controller = "Patient", action = "PatientDashboard" });

            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "medecindashboard",
                pattern: "medecin/dashboard",
                defaults: new { controller = "Medecin", action = "MedecinDashboard" });

            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "assistantdashboard",
                pattern: "assistant/dashboard",
                defaults: new { controller = "Assistant", action = "AssistantDashboard" });

            });
        }
    }
}
