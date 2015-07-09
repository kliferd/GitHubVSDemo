using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public  void printMessage(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Sum is: " + c);
        }

        public void followMessage(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Sum is: " + c);
        }
    }
      
    class Execute
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Unit Testing");
            Console.WriteLine("Unit Testing");
            obj.printMessage(5, 5);
            
        }

        
    }

}
