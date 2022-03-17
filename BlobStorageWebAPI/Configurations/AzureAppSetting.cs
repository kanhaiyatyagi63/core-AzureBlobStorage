using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlobStorageWebAPI.Configurations
{
    public class AzureAppSetting
    {
        public string ContainerName { get; set; }
        public string ConnectionString { get; set; }
    }
}
