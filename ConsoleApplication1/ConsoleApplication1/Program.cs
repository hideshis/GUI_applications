using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ans = fizzBuzz(15);
            Console.WriteLine(ans);
            System.Threading.Thread.Sleep(1000);
        }

        public static string fizzBuzz(int i)
        {
            //3の倍数でかつ5の倍数の場合は"FizzBuzz"を出力
            if (i % 3 == 0 && i % 5 == 0) return "FizzBuzz";

            //3の倍数の倍数の場合は"Fizz"を出力
            if (i % 3 == 0) return "Fizz";

            //5の倍数の場合は"Buzz"を出力
            if (i % 5 == 0) return "Buzz";

            //それ以外の場合はその数値をそのまま文字列として出力
            return i.ToString();
        }
    }
}
