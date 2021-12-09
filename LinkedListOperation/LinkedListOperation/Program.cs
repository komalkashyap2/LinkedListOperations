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
             obj.AddFirst(56);
             obj.AddFirst(30);
             obj.AddFirst(70);
             
            //Display Operation
            Console.WriteLine("*****Appending*****");
             obj.Append(56);
             obj.Append(30);
             obj.Append(70);
            obj.Show();

            ;
        }
      }
}
