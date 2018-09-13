using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public String firstName;
        public String lastName;

        public void Introduce()
        {
            Console.WriteLine("My full name is "+firstName+" "+lastName);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Person john = new Person();
            var john = new Person();
            john.firstName = "Rajiv";
            john.lastName = "Nair";
            john.Introduce();
        }
    }
}
