using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.Business.Managers.Concrete;

namespace IK_PROJE.MVC.Extensions
{
    public static class IkExtension
    {
        public static IServiceCollection AddIKService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<>), typeof(Manager<>));

            return services;
        }
    }
}
