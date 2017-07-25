using System;

namespace HelloVisual
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello Visual Studio");

            Console.WriteLine("Enter 'Y' to start over");
            string keyStroke = Console.ReadLine();
            if (keyStroke == "Y" || keyStroke == "y")
            {
                Main();
            }

        }
    }
}
