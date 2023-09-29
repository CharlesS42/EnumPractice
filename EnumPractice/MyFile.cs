using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    internal class MyFile
    {
        public MyFile(string name, string path, Rights fileRights, byte[] fileData) {
            Name = name;
            Path = path;
            FileRights = fileRights;
            FileData = fileData;
        }
        public string Name { get; set; }
        public string Path { get; set; }

        public Rights FileRights { get; set; }

        public byte[] FileData { get; set; }
    }
}
