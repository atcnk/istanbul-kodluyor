using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<HospitalAppointmentSystemDbContext>();

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminActionRepository, AdminActionRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>(); 
            services.AddScoped<IDoctorScheduleRepository, DoctorScheduleRepository>();
            services.AddScoped<IFeedbackRepository, FeedbackRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IPatientReportRepository, PatientReportRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();     
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
