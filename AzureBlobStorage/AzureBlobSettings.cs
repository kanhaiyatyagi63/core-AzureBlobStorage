namespace AzureBlobStorage
{
    public class AzureBlobSettings
    {
        //public AzureBlobSettings(string containerName,
        //                            string connectionString
        //                            )
        //{

        //    if (string.IsNullOrEmpty(containerName))
        //        throw new ArgumentNullException("ContainerName Not found");
        //    if (string.IsNullOrEmpty(connectionString))
        //        throw new ArgumentNullException("ConnectionString Not found");

        //    ContainerName = containerName;
        //    ConnectionString = connectionString;
        //}

        public string ContainerName { get; set; }
        public string ConnectionString { get; set; }
    }
}
