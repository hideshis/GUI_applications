using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOJ0101
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_lines = int.Parse(Console.ReadLine());
            List<string> corrected_line_list = new List<string>();
            for (int i = 1; i <= num_lines; i++)
            {
                Line original_line = new Line(Console.ReadLine());
                corrected_line_list.Add(original_line.error_correction());
            }
            Console.WriteLine(string.Join("\n", corrected_line_list.ToArray()));
        }

    }
}
