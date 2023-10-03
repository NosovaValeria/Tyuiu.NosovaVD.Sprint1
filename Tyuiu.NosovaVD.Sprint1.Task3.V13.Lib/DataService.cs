using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NosovaVD.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            return Math.Round(((number / 100) * (number % 100 / 10) * (number % 10)), 3);
        }
    }
}
