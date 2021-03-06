
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AzureBlobStorage.Services.Abstracts
{
    public interface IBlobStorage
    {
        Task UploadAsync(string blobName, byte[] byteArray);
        Task UploadAsync(string blobName, Stream stream);
        Task<MemoryStream> DownloadAsync(string blobName);
        Task DownloadAsync(string blobName, string path);
        Task DeleteAsync(string blobName);
        Task<bool> ExistsAsync(string blobName);
        Task<List<AzureBlobItem>> ListAsync();
        Task<List<AzureBlobItem>> ListAsync(string rootFolder);
        Task<List<string>> ListFoldersAsync();
        Task<List<string>> ListFoldersAsync(string rootFolder);
    }
}
