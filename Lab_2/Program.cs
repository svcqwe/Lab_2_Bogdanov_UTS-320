using System.IO;

namespace Lab_2
{

    class Programm
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nДоступные команды:");
                Console.WriteLine("1. Просотр содержимого директории\n" +
                                  "2. Удалить файл/папку\n" +
                                  "3. Копировать файл/папку\n" +
                                  "4. Переимновать файл/папку");
                
                int choose = int.Parse(Console.ReadLine());
                
                if (choose == 1)
                {
                    Console.WriteLine("Введи абсолютный путь до папки");
                    string path = Console.ReadLine();
                    try
                    {
                        file_manager File_manager = new file_manager();
                        File_manager.Path(path);
                    }
                    catch
                    {
                        if (int.Parse(path) == 0)       //Заврешение работы программы
                            break;
                        else Console.WriteLine("Неверно введен путь до директории. Вводи абсолютный путь!");
                    }
                }
                
                if(choose == 2)
                {
                    Console.WriteLine("Введи абсолютный путь до директории/файла");
                    string path = Console.ReadLine();
                    try
                    {
                        Command command = new Command();
                        command.delete(path);
                    }
                    catch
                    {
                        if (int.Parse(path) == 0)       //Заврешение работы программы
                            break;
                        else Console.WriteLine("Неверно введен путь до директории/папкм. Вводи абсолютный путь!");
                    }
                }
            }
        }
    }
}



