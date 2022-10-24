using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Common.FileIO
{
    public interface IFileIOService
    {
        string ReadFile(string path);
        bool WriteFile(string path, string contents);
    }
}
