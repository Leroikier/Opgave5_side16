using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5_side16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input "binært"
            Console.WriteLine("Indtast binært tal");
            string binary = (Console.ReadLine());

            //Input "hexadecimal"
            Console.WriteLine("Indtast hexadecimal tal");
            string hexa = (Console.ReadLine());

            //Der konventeres tilbage til decimaltal fra binært
            int decimaltal1 = Convert.ToInt32(binary, 2);
            //Der konventeres tilbage til decimaltal fra hexadecimale
            int decimaltal2 = int.Parse(hexa, System.Globalization.NumberStyles.HexNumber);

            //Output
            Console.Clear();
            Console.WriteLine("{0} binary is = {1} in decimals", binary, decimaltal1);
            Console.WriteLine("{0} hexadecimal is = {1} in decimals", hexa, decimaltal2);

            //Slut
            Console.ReadKey();
        }
    }
}
