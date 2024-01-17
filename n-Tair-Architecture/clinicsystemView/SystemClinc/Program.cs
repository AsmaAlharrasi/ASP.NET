using Microsoft.EntityFrameworkCore;
using SystemClinc.BLL.Interface;
using SystemClinc.BLL.Repository;
using SystemClinc.DAL.MyDbContext;

namespace SystemClinc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("defultConnection")));
            builder.Services.AddScoped<IPatient, PatientRepository>();
            builder.Services.AddScoped<IAdmin, AdminRepository>();
            builder.Services.AddScoped<IAppointment, AppointmentRepository>();
            builder.Services.AddScoped<ISpecialization, SpecializationRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}