using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class file_manager
    {
        public void Path(string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                Console.WriteLine("\n==============================================================================");
                if (dirs.Length == 0)
                    Console.WriteLine("Подпапки - отсутствуют");
                else
                {
                    Console.WriteLine("Все папки:\n");
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        Console.WriteLine($"\t{i+1}) " + dirs[i]);
                    }
                }

                if (files.Length == 0)
                    Console.WriteLine("\nФайлы - отсутствуют");
                else
                {
                    Console.WriteLine("\nВсе файлы:\n");
                    for (int i = 0; i < files.Length; i++)
                    {
                        Console.WriteLine($"\t{i+1}) " + files[i]);
                    }
                }
                Console.WriteLine("==============================================================================");
            }
            catch
            {
                Console.WriteLine("Неверно введен путь до директории. Вводи абсолютный путь!");
            }
        }
    }
}
