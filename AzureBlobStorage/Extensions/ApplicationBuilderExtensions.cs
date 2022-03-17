
using AzureBlobStorage.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace AzureBlobStorage.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseAzureBlobStorage(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<StorageMiddleware>();
            return builder;
        }
    }
}
