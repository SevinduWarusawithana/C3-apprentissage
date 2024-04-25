using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 21;
            //Console.WriteLine(age);

            //string name = "sevindu";

            //Console.Write("My name is ");
            //Console.Write(name);




            //string age = "21";
            //int age01 = Convert.ToInt32(age);
            //Console.WriteLine(age01);

            //string date = "25.51";
            //int date2 = Convert.ToDouble(date);
            //Console.WriteLine(date2);



            //int age = 21;
            //age++;
            //Console.WriteLine(age);

            //age--;
            //Console.WriteLine(age);


            //string name = "sevindu";
            //name += " is a sigma boy with different attitude.";
            //Console.WriteLine(name);


            //int firstNum = 10;
            //int secondNum = 3;

            //int cal = firstNum % secondNum;
            //Console.WriteLine(cal);

            //const int vat = 20;
            //int balance = 1000;

            //Console.WriteLine(balance + (balance * (vat/100D)));

            //int num1 = 21;
            //int num2 = 20;

            //Console.WriteLine(num2 %2);


            //Console.Write("Enter you name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //string ageString = Console.ReadLine();
            //int age = Convert.ToInt32(ageString);

            //Console.WriteLine();

            //Console.WriteLine($"Hello {name}, how are you!. Your age is {age}.");


            Console.Write("Enter you age: ");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);

            if (age >= 18) 
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a child");
            }

            Console.ReadLine();
        }
    }
}
