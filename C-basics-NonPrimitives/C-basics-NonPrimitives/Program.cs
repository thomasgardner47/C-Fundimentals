using System;
using C_basics_NonPrimitives;

namespace C_basics_NonPrimitives
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person Thomas = new Person();

            //Thomas.FirstName = "Thomas";
            //Thomas.LastName = "Gardner";
            //Thomas.Introduce();
            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);


            /* The Below shows how to
             declare several different types of array's in C# */


            // 1) declaring an array of intergers
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // 2) declaring an array of datatype boolean where by the elements which don't meet the true requirement are false 
            var flags = new bool[3];

            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            // 3) declaring an array of strings 
            var names = new string[3] {"Jack", "John", "Mary"};



            /*  How to Use Strings properly */

            //declaring the string variables 
            var firstName = "Tom";
            var lastName = "Gardner";

            // conatinating 3 string elements together
            var fullName = firstName + " " + lastName;

            // using the format method to take two arguments
            // the first being a format string and the other argument 
            //being the values being supplied to support this argument 
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            // creating an array of names and comparing the values with comma acting as a seperator and the array
            var names2 = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names2);

            // to display the results
            Console.WriteLine(formattedNames);

            // how to add slashes to a file path string 

            var text = "Hi John\nlook into the following paths\nc:\\folder1folder2\nc:\\folder3\\folder4 ";
            Console.WriteLine(text);

            // how to properly format a verbatim string without the need to format the file path as shown above 
            // by adding an @ symbol and removing double backslashes and \n
            var text2  = @"Hi John
look into the following paths
c:\\folder1folder2
c:\\folder3\\folder4 ";
            Console.WriteLine(text);


            /* working with enums */
        }
    }
}
