using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Command
    {
        public void delete(string path)
        {
            try
            {
                bool is_file = false;
                for(int i = 0; i < path.Length; i++)
                {
                    if (path[i] == '.')
                        is_file = true;
                }
                if (is_file)
                    File.Delete(path);
                else
                    Directory.Delete(path, true);
            }
            catch
            {
                Console.WriteLine("Введен неавприльный путь!");
            }
        }
        public void copy(string sourth_path, string goal_path)
        {
            string file_name = "";
            bool flag = true;
            for(int i = sourth_path.Length-1; i >= 0; i--)
            {
                if (sourth_path[i] == '\\')
                    flag = false;

                if (flag == true)
                    file_name += sourth_path[i];
            }
            string res_file = "\\";
            for(int i = file_name.Length-1; i >= 0; i--)
            {
                if (file_name[i] == '.')
                {
                    res_file += "_copy";
                }
                res_file += file_name[i];
            }

            File.Copy(sourth_path, goal_path + res_file);
        }
        public void rename(string path, string new_name)
        {
            string new_path = "";
            string format = "";
            bool flag_path = false;
            bool flag_format = true;
            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] == '.')
                    flag_format = false;

                if (flag_format == true)
                    format += path[i];

                if (path[i] == '\\')
                    flag_path = true;

                if (flag_path == true)
                    new_path += path[i];

            }
            string new_path_ = "";
            string format_ = ".";
            for (int i = new_path.Length-1; i >=0; i--)
            {
                new_path_ += new_path[i];
            }
            for (int i = format.Length - 1; i >= 0; i--)
            {
                format_ += format[i];
            }
            Directory.Move(path, new_path_ + new_name + format_);
        }
        public void replace(string sourth_path, string goal_path)
        {
            File.Copy(sourth_path, goal_path);
            File.Delete(sourth_path);
        }
        public void search(string dir_path, string file_name)
        {
            if (!Directory.Exists(dir_path))
            {
                Console.WriteLine("Ошибка: Указанная директория не существует!");
                return;
            }
            try
            {
                string[] foundFiles = Directory.GetFiles(dir_path, file_name);

                if (foundFiles.Length == 0)
                {
                    Console.WriteLine("Файлы не найдены.");
                }
                else
                {
                    Console.WriteLine($"\nНайдено файлов: {foundFiles.Length}");
                    Console.WriteLine("Список найденных файлов:");

                    foreach (string filePath in foundFiles)
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        Console.WriteLine($"- {Path.GetFileName(filePath)}");
                        Console.WriteLine($"  Полный путь: {filePath}");
                        Console.WriteLine($"  Размер: {fileInfo.Length} байт");
                        Console.WriteLine($"  Дата изменения: {fileInfo.LastWriteTime}");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
