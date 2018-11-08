using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            //Console.WriteLine("Hello World!");
            Console.WriteLine("Hi, what is your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        string message = Message.GetMessage("fr");
        //        Console.WriteLine(message);
        //        Console.ReadLine();
        //    }
        //}
        //public class Message
        //{
        //    public static string GetMessage(string lang)
        //    {
        //        if (lang.Equals("sp"))
        //        {
        //            return "Hola Mundo";
        //        }
        //        else if (lang.Equals("fr"))
        //        {
        //            return "Bonjour le monde";
        //        }
        //        else
        //        {
        //            return "Hello World";
        //        }
        //    }
        //}
    }
}
