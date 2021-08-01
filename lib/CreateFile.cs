using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sharp_NSI.lib.main
{
    class CreateFile
    {
        public static void NSICreate(string fileName)        {
            string directory = ".\\Installer";
            string file_path = $"{directory}\\{fileName}.nsi";
            if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
            if (!File.Exists(file_path)) { File.Create(file_path); }
        }
    }
}
