using System;
using HelloWorld.Math;

namespace HelloWorld
{

    public enum ShippingMethod // enums, or key value pairs for a group of related constants, need to be declared at the namespace level.
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3

    }

 
    class Program
    {
        static void Main(string[] args)
        {

            var dan = new Person();

            dan.firstName = "Dan";
            dan.lastName = "Sacharow";

            dan.Introduce();

            var Calculator = new Calculator();

            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);  // console is a static method; you don't need more than one instance of console
            //and you don't need to instantiate a Console object.


            //arrays

            var numbers = new int[3];

            //when you initilaize an array of a certain type and don't specifiy the value of each element,
            // they default to the default value of that data type.  Int would default to zero.  Boolean to false.

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            var names = new string[] { "Dan", "Jen" };


            //strings


            var firstName = "Dan";
            var lastName = "Sacharow";


            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var namefromArray = String.Join(",", names);

            var text = @"Hi Dan, look in the c:\folder1\folder2";



            //enums


            var method = ShippingMethod.Express;
            Console.WriteLine(method); // this returns the key, express
            Console.WriteLine((int)method); //this returns the value, 3

            var methodID = 3;

            Console.WriteLine((ShippingMethod)methodID);  //this returns the key in the enum that matches the value you cast to the enum.

            Console.WriteLine(method);
            //note that Console.writeLine automatically calls the .toString method on anything you pass in.
            // so the above is the same as writing
            Console.WriteLine(method.ToString());

            //here is how you would parse a string into an enum type, or enumeration.

            var methodName = "Express";

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);


            // static types and reference types


            //VALUE TYPES, all are structures
            //byte
            //short
            //int
            //long
            //float
            //double
            //decimal
            //char
            //bool

            //value for a will stay the same, because VALUE TYPES have a reserved spot in memory,
            // and any copies are stored into the NEW variable.  Hence VALUE TYPE, because their values
            // are copied.
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("value type");
            Console.WriteLine(a + "  ---> " + b);
            //REFERENCE TYPE
            //any class.  string, array, enum.
            // any copies made to a REFERENCE TYPE is merely a POINTER to the memory in stack of the original object.
            // hence REFERENCE TYPES, because their memory address is referenced, and their value is not copied.

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine("reference type");
            Console.WriteLine(array1[0] + " " + array2[0]);
        }
    }
}
