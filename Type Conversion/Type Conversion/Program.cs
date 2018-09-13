using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            int j = 10;
            //byte a = j;
            byte a = (byte)j;
            Console.WriteLine(a);

            try
            {
                String number = "1234";
                int x = Convert.ToByte(number);
                Console.WriteLine(x);
            }
            catch(Exception){
                Console.WriteLine("The number could not be converted to a Byte.");
            }

            try
            {
                String str = "true";
                bool y = Convert.ToBoolean(str);
                Console.WriteLine(y);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a Byte.");
            }
        }
    }
}
