using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2022;
            string month = "Sept";
            // using + sign
          Console.WriteLine("Current year is "+year+" &  month  is "+month);

           //placeholder {0}

          Console.WriteLine("Current year is {0} & month is {1}",year,month);

         //interpolation --> $ sign

          Console.WriteLine($"Current year is {year} & month is (month)");
        }
    }
}
