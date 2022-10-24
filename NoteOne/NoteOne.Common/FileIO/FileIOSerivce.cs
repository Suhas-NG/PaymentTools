using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Common.FileIO
{
    public class FileIOSerivce : IFileIOService
    {
        public string ReadFile(string path)
        {
            string result = string.Empty;
            
            if (File.Exists(path))
            {
                result = File.ReadAllText(path);
            } 
            return result;
        }

        public bool WriteFile(string path, string contents)
        {
            bool result = false;
            File.WriteAllText(path, contents);
            return result;
        }
    }
}
