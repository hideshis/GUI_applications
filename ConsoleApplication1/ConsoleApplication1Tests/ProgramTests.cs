using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void fizzBuzzTest()
        {
            string ans = Program.fizzBuzz(15);
            Equals(ans, "FizzBuzz");
        }
    }
}