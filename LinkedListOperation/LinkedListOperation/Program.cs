using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOperation
{
      class Program
      {
        static void Main(string[] args)
        {

            //UseCase 1
            Operation obj = new Operation();
            
            
            //Display Operation
            Console.WriteLine("*****Adding the Elements*****");
            //Insertion Operation
            obj.AddElement(56);
            obj.AddElement(30);
            obj.AddElement(70);
            obj.Show();
        }
      }
}
