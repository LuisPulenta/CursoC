using System;
using System.IO;
using System.Text;

namespace _17_AdministracionRecursos
{
    class FileManager:IDisposable
    {
        FileStream reader = null;

        public FileManager(string filePath)
        {
            //using (FileStream reader = File.Open(filePath, FileMode.Open))
            //{
            //    byte[] b = new byte[1024];
            //    UTF8Encoding temp = new UTF8Encoding();

            //    while (reader.Read(b, 0, b.Length) > 0)
            //    {
            //        Console.WriteLine(temp.GetString(b));
            //    }
            //}


                reader = File.Open(filePath, FileMode.Open);
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding();
                while (reader.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
           
           
        }

        public void Dispose()
        {
            reader?.Dispose();
        }
    }
}