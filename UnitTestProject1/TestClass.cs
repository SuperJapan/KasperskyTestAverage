using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class TestClass
    {
        public TestClass()
        {
            
        }
        
        public static string ExceptionNullArgument = "ExceptionNullArgument";
        public static string ExceptionOutOfRangeArgument = "ExceptionNullArgument";

        public double Average(IEnumerable<double> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException("sequence", ExceptionNullArgument);
            }
            if (sequence.Count() < 1)
            {
                throw new ArgumentOutOfRangeException("sequence", ExceptionOutOfRangeArgument);
            }

            double res = 0;
            double sum = 0;
            foreach (double d in sequence)
                sum += d;
            
            res = sum / (double)sequence.Count();
            return res;
        }
    }
}
