using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOJ0101
{
    public class Line
    {
        private string original_line;

        public Line(string original_line)
        {
            this.original_line = original_line;
        }

        public string error_correction()
        {
            List<string> original_line_list = original_line.Split(' ').ToList();
            List<string> corrected_line_list = new List<string>();
            foreach (string word in original_line_list)
            {
                if (word.Contains("Hoshino")) {
                    corrected_line_list.Add(word.Replace("Hoshino", "Hoshina"));
                } else
                {
                    corrected_line_list.Add(word);
                }
            }
            return string.Join(" ", corrected_line_list.ToArray());
        }

        public void line_change(string new_line)
        {
            original_line = new_line;
        }
    }
}
