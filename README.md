# AspNetCore AzureBlobStorage
This is a azure blob storage helper library that can be used for azure blob storage operations like Insert, delete, download, GetList of blob.

# Installation
1. Open package manager console and paste
```c#
Install-Package AspDotNetCore.AzureBlobStorage -Version 1.0.0
```
2. Add below snippt in Configure services method in startup.cs file
```c#
 services.AddAzureBlobStorage(config =>
            {
                config.ContainerName = "<ContainerName>";
                config.ConnectionString = "<ConnectionString>"
            });
```
3. Add below snippt in Configure method in startup.cs file
```c#
app.UseAzureBlobStorage();
```
# Usage
1. Add below snippt into the controller
```c#
private readonly IBlobStorage _azureBlobStorage;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IBlobStorage azureBlobStorage)
        {
            _logger = logger;
            _azureBlobStorage = azureBlobStorage;
        }

```

# Example 
```c#
 [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IBlobStorage _azureBlobStorage;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IBlobStorage azureBlobStorage)
        {
            _logger = logger;
            _azureBlobStorage = azureBlobStorage;
        }

        [HttpGet("getbloblists")]
        public async Task<FilesViewModel> GetBlobLists()
        {
            var model = new FilesViewModel();
            foreach (var item in await _azureBlobStorage.ListAsync())
            {
                model.Files.Add(
                    new FileDetails { Name = item.Name, BlobName = item.BlobName });
            }
            return model;
        }
    }
```

# Features
- [x] Support refersh token if blobs are more than 5000.
- [x] Delete blobs
- [x] Get blobs
- [x] Download blobs  
- [x] Get folders 
- [ ] create container

# Upcoming Features
* Establishment of connection through credentails

# Technology
1. C#
2. Net 6
3. Class Library
4. Dot net core web API

# Supported Frameworks
- [x] Support Dot Net Core
- [x] Establish connection through connection string 
- [ ] Establish connection through credential like username and password
- [ ] Support Dot Net Framework


# Author
* Facebook - [Kanhaya Tyagi](https://www.facebook.com/kanhaiyatyagi63/)
* StackOverFlow - [Kanhaya Tyagi](https://stackoverflow.com/users/14945515/kanhaya-tyagi)
* LinkedIn - [Kanhaya Tyagi](https://www.linkedin.com/in/kanhaya-tyagi-510b55141/)
* Twitter - [Kanhaya Tyagi](https://www.twitter.com/kanhaiyatyagi63/)
* Bit Bucket - [Kanhaya Tyagi](https://bitbucket.org/kanhaiyatyagi63/)

# Version
1. Version 1.0 - Stable

# Licence

AspDotNetCore AzureBlobStorage under the [MIT](https://github.com/kanhaiyatyagi63/AspNetCore.AzureBlobStorage/blob/master/LICENSE)
