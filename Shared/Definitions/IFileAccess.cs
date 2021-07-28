using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IFileAccess
    {
        string GeneratePath(string fileName);
        Task WriteToFileAsync(dynamic data, string path);
        Task ReadFromFileAsync(dynamic data, string path);
    }
}
