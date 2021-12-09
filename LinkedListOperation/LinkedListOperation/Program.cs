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
            Console.WriteLine("****WELCOME TO LINKED LIST OPERATIONS");
            Console.WriteLine("**********1.Adding the elements************");
            Console.WriteLine("**********2.Inserted into list(First)************");
            Console.WriteLine("**********3.Inserting in between***********");
            Console.WriteLine("**********4.Pop the First Element***********");
            Console.WriteLine("**********5.Delete the Last Element***********");
            Console.WriteLine("**********6.Searching the Element***********");

            Console.WriteLine("Enter the option!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            //Creating object for Custom Linked list class
            Operation obj = new Operation();
            switch (num)
            {
                case 1:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(70);
                    obj.Show();
                    break;
                case 2:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(70);
                    obj.Show();
                    break;
                case 3:
                    obj.AddElement(56);
                    obj.AddElement(70);
                    obj.AddBetween(2, 30);
                    obj.Show();
                    break;
                case 4:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(70);
                    obj.PopFirst();
                    obj.Show();
                    break;
                case 5:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(70);
                    obj.PopLast();
                    obj.Show();
                    break;
                case 6:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(70);
                    obj.Search(56);
                    obj.Show();
                    break;
                case 7:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(70);
                    obj.Insert(30, 40);
                    obj.Show();
                    break;
                case 8:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(40);
                    obj.AddElement(70);
                    obj.DeleteInBetween(40);
                    obj.Show();
                    break;
                case 9:
                    obj.AddElement(56);
                    obj.AddElement(30);
                    obj.AddElement(40);
                    obj.AddElement(70);
                    obj.Sort();
                    obj.Show();
                    break;



            }
            Console.ReadLine();


        }
      }
}
