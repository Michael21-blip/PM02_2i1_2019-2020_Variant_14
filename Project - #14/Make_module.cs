using System; 
using System.IO;

namespace MyDriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
        // Изменяем кодировку консоли для вывода текста
            Console.OutputEncoding = Encoding.GetEncoding(866);             
            Console.WriteLine("Ваши диски:");
            string[] Pop = Directory.GetLogicalDrives();
            foreach (string K in Pop)
                Console.WriteLine("{0}", K);
            DriveInfo[] Ds = DriveInfo.GetDrives();
            foreach (DriveInfo O in Ds)
            {
                Console.WriteLine("Диск: {0} Тип {1}", O.Name, O.DriveType);                 
                if (O.IsReady)
                {
                    Console.WriteLine("Свободно: {0}", O.TotalFreeSpace);
                    Console.WriteLine("Файловая система: {0}", O.DriveFormat);
                    Console.WriteLine("Метка: {0}", O.VolumeLabel);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}