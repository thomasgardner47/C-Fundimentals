using System;

namespace C_basics_NonPrimitives
{
    public class Person
    {
        public String FirstName;
        public String LastName;
        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + "" + LastName);
        }
    }
}