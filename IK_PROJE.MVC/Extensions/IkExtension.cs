using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.Business.Managers.Concrete;
using System.Security.Claims;
using System.Security.Principal;

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
    public static class IdentityExtension

    {

        public static int GetId(this IIdentity identity)

        {

            // ClaimsIdentity türüne dönüştürme

            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

            // ClaimTypes.NameIdentifier değerini bul

            Claim claim = claimsIdentity?.FindFirst(ClaimTypes.NameIdentifier);

            // Claim varsa ve int'e dönüştürülebiliyorsa değeri döndür, aksi halde 0 döndür

            if (claim != null && int.TryParse(claim.Value, out int id))

            {

                return id;

            }

            return 0; // Varsayılan değer

        }

    }


}
