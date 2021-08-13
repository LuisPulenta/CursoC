using System;
using System.IO;
using System.Text;

namespace _17_AdministracionRecursos
{
    class FileManager
    {
        FileStream reader = null;

        public FileManager(string filePath)
        {
            reader = File.Open(filePath, FileMode.Open);
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding();
            while(reader.Read(b,0,b.Length)>0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }

        ~FileManager()
        {
            reader.Close();
            System.Diagnostics.Trace.WriteLine("Archivo cerrado");
        }
    }
}