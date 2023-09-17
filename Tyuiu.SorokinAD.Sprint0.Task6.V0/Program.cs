using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SorokinAD.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов масива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstracktionArray(numsArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplucationArray(numsArray));
            Console.ReadKey();
        }
    }
}
