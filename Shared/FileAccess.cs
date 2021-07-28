using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shared
{
    public class FileAccess<T>
    {

        public static async Task WriteToFileAsync(T data, string path)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            using FileStream createStream = File.Create(path);
            await JsonSerializer.SerializeAsync(createStream, data, options);

        }


        public static async Task ReadFromFileAsync(string path)
        {
            using FileStream openStream = File.OpenRead(path);
           var result = await JsonSerializer.DeserializeAsync<dynamic>(openStream);

        }


        public static string GeneratePath(string fileName)
        {
            string path = @"C:\Users\hp\source\repos\WillBank\WillBank.Store\DataStore\";
            string fileExtension = ".json";
            return path + fileName + fileExtension;

        }
    }
}
