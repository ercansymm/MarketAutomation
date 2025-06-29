using System;
using System.Collections.Generic;
using System.IO;

namespace GladiusObjex.Tool
{
    public class GladiusIO : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public static List<string> DosyaListele(string path)
        {
            List<string> fileList = new List<string>();
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();

            foreach (FileInfo dosya in fi)
            {
                fileList.Add(dosya.Name);

            }

            return fileList;
        }
    }
}
