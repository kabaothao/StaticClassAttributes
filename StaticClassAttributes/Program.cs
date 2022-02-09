using System;

namespace StaticClassAttributes
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmir.title);

            Console.ReadLine();
        }


    }



}