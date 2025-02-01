//Written by Shrijan Paudel
//Date : 01/26

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Four_Sisters_and_the_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourSisterandDuckbear calculator = new FourSisterandDuckbear();
            Console.WriteLine("Welcome to the Four Sisters and the Duckbear program!");

            Console.WriteLine("Enter Number of Eggs:");
            int numeggs = Convert.ToInt32(Console.ReadLine());

            if (numeggs > 0)
            {
                calculator.Eggs = numeggs;
                Console.WriteLine(calculator.GetResultMessage());
            
            }
        }
    }
}
