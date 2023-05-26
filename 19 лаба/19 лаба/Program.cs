using System.IO;

foreach (var drive in DriveInfo.GetDrives())
{
    try
    {
        Console.WriteLine("Имя: " + drive.Name);
        Console.WriteLine("Файловая система: " + drive.DriveFormat);
        
        Console.WriteLine("ТИП ДИСКА: " + drive.DriveType);
       
        Console.WriteLine("Сколько свободного места (в байтах): " + drive.AvailableFreeSpace);
        
        Console.WriteLine("Готов диск: " + drive.IsReady);
        
        Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
       
        Console.WriteLine("Сколько доступного на диске (в байтах): " + drive.TotalFreeSpace);
       
        Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);
        
        Console.WriteLine("Метка тома диска: " + drive.VolumeLabel);
    }
    catch { }

    Console.WriteLine();
}
