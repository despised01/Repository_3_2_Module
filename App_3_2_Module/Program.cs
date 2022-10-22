using System;

namespace App_3_2_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName;
            byte MyAge;
            bool MyPet;
            double MySize;

            MyName = "Anton";
            MyAge = 30;
            MyPet = true;
            MySize = 43.5f;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? " + MyPet);
            Console.WriteLine("My shoe size is " + MySize);
        }
    }
}
