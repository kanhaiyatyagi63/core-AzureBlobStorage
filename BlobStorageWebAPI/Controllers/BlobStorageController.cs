using AzureBlobStorage.Models;
using AzureBlobStorage.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JCI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlobStorageController : ControllerBase
    {
        private readonly IBlobStorage _azureBlobStorage;
        public BlobStorageController(IBlobStorage azureBlobStorage)
        {
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
}
