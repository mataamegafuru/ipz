using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int b = 8;
                int kb = 8192;
                int input;
                do
                {
                    Console.WriteLine("Input number in bits to convert it into KB and Bytes");
                }
                while(!Int32.TryParse(Console.ReadLine(), out input) || input < 0);
                int reskb = input / kb;
                int resb = (input - kb * reskb) / b;
                int res = input - (kb * reskb + b * resb);
                Console.WriteLine($"{reskb} KByte(s) {resb} Byte(s) {res} Bit(s)");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
