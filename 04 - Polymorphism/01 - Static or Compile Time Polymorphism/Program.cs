using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    //MethodOverlaoding is a concept where we have multiple methods having siilar names but they vary by their method signatures.
    /*
     * It can be implemented by 
     * 1. Changing the number of arguments. -- Implemented by Add Method on AddMethod class
     * 2. Changing order of arguments. -- Implemented by PrintYourName_Age method on YourNameAndAge class
     * 3. Changing type of arguments.
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Calling Add Method in AddMethod class by instantiating it
            AddMethod amObj = new AddMethod();

            //Calling add method with 2 arguments
            amObj.Add(2, 4);

            //Calling add method with 3 arguments
            amObj.Add(2, 4, 6);

            Console.WriteLine("-------------------------------------------------------------------------------------");

            //Calling PrintYourName_Age method in YourNameAndAge class by instantiating it
            YourNameAndAge ynaObj = new YourNameAndAge();

            //Calling with byte followed by string argument
            ynaObj.PrintYourName_Age(45, "John");

            //Calling with string followed by byte argument
            ynaObj.PrintYourName_Age("Doe", 28);

            Console.WriteLine("-------------------------------------------------------------------------------------");

            //Creating object of TypeArgument
            TypeArgument typeArgument = new TypeArgument();

            //Calling checkType method with int argument
            typeArgument.checkType(12);

            //Calling checkType method with string argument
            typeArgument.checkType("Hello, I am a random guy");

            //Calling checkType method with float argument
            typeArgument.checkType(14.26f);

            Console.ReadLine();

        }
    }
}
