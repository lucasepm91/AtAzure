using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace At_Azure.Repository
{
    public class BlobRepository
    {
        public async Task<IActionResult> ImportarBlob(IFormFile file, string name)
        {
            const string accountName = "lucasatazure";
            const string key = "s84Kt2JNmHqbU4+zsaDgt5V9oHnGRbLnpQraShTfTvSzPlQe2h+QfEeruvqo4Crc2EUIDvXH5QU9gdTRWUu6uA==";

            var storageAccount = new CloudStorageAccount(new StorageCredentials(accountName, key), true);
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("lucasatcontainer");

            var blob = container.GetBlockBlobReference(name);
            using (var stream = file.OpenReadStream())
            {
                var task = blob.UploadFromStreamAsync(stream);
                while (!task.IsCompleted)
                    Thread.Sleep(1000);

                stream.Close();
            }

            return null;
        }

        public string BuscarCaminho(string name)
        {
            const string accountName = "lucasatazure";
            const string key = "s84Kt2JNmHqbU4+zsaDgt5V9oHnGRbLnpQraShTfTvSzPlQe2h+QfEeruvqo4Crc2EUIDvXH5QU9gdTRWUu6uA==";
            string caminho = null;

            var storageAccount = new CloudStorageAccount(new StorageCredentials(accountName, key), true);
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("lucasatcontainer");

            CloudBlob blob = container.GetBlobReference(name);

            caminho = blob.Uri.ToString();

            return caminho;

        }

        public void AlterarBlob(string caminho, IFormFile file, string name)
        {
            DeletarBlob(caminho);
            ImportarBlob(file, name);
            
        }

        public void DeletarBlob(string caminho)
        {
            const string accountName = "lucasatazure";
            const string key = "s84Kt2JNmHqbU4+zsaDgt5V9oHnGRbLnpQraShTfTvSzPlQe2h+QfEeruvqo4Crc2EUIDvXH5QU9gdTRWUu6uA==";

            var storageAccount = new CloudStorageAccount(new StorageCredentials(accountName, key), true);
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("lucasatcontainer");

            var partes = caminho.Split("/");
            int tamanho = partes.Length;
            string name = partes[tamanho - 1];

            var blob = container.GetBlockBlobReference(name);

            var task = blob.DeleteAsync();
            while (!task.IsCompleted)
                Thread.Sleep(1000);
                                    
        }
    }
}
