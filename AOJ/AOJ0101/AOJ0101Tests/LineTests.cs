using Microsoft.VisualStudio.TestTools.UnitTesting;
using AOJ0101;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOJ0101.Tests
{
    [TestClass()]
    public class LineTests
    {
        [TestMethod()]
        public void error_correctionTestList()
        {
            Line original_line = new Line("Hoshina");
            Equals("Hoshina", original_line.error_correction());
            original_line.line_change("Hoshino");
            Equals("Hoshina", original_line.error_correction());
            original_line.line_change("Hoshino Hoshina hoshino hoshina ");
            Equals("Hoshina Hoshina hoshino hoshina ", original_line.error_correction());
        }
    }
}