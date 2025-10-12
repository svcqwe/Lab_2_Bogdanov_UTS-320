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
                Directory.Delete(path, true);
            }
            catch
            {
                Console.WriteLine("Введен неавприльный путь!");
            }
        }
        public void copy(string sourth_path, string goal_path)
        {
            Directory.Move(sourth_path, goal_path);
        }
        public void rename(string peth, string source_name, string new_name)
        {
            Console.WriteLine("sdf");
        }

    }
}
