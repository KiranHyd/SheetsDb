using DoMaven.SheetsDb;
using DoMaven.SheetsDb.Managers;
using DoMaven.SheetsDb.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Your email:");
            var username = Console.ReadLine();
            var password = string.Empty;

            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }

            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);

            var sheetsManager = new SheetsManager("SheetsDb-Test", new GoogleAuthentication(username, password));


            sheetsManager.Test();
        }
    }
}
