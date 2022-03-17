using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AzureBlobStorage.Middlewares
{
    internal class StorageMiddleware
    {
        private readonly RequestDelegate _next;
        private ILogger<StorageMiddleware> _logger;
        public StorageMiddleware(RequestDelegate next, ILogger<StorageMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                _logger.LogDebug("Invoked Blob Storage");
                await _next(context);
            }
            catch (Exception error)
            {
                _logger.LogError("Something went wrong", error);
            }
        }

    }

}
