using AzureBlobStorage.Services;
using AzureBlobStorage.Services.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AzureBlobStorage.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private static void AddFrameworkServices(this IServiceCollection services)
        {
            #region Framework Services
            //Check if a BlobStorage is already registered.
            var tempDataProvider = services.FirstOrDefault(d => d.ServiceType == typeof(IBlobStorage));
            #endregion
        }
        public static void AddAzureBlobStorage(this IServiceCollection services, Action<AzureBlobSettings> configure)
        {
            var configuration = new AzureBlobSettings();
            configure(configuration);
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddFrameworkServices();
            services.AddScoped<IBlobStorage>(factory =>
            {
                return new BlobStorage(configuration);
            });
        }
    }
}
