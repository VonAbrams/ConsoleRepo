using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace FileLibrary
{
    public class LibraryBase
    {

    }


    public class File
    {
        private string path = Environment.CurrentDirectory;
        public string fileName { get; }
        public File()
        {
            fileName = path;
        }


    }


}