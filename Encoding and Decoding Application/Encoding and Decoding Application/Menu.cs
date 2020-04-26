using System;
using System.Collections.Generic;
using System.Text;

namespace Encoding_and_Decoding_Application
{
    class Menu
    {
        public Menu(ref string msg, ref string encode, ref int key)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("--------Encoding and Decoding Application---------");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Enter Message to be decoded");
            Console.WriteLine("2. Encode Message");
            Console.WriteLine("3. Decode Message");
            Console.WriteLine("4. Clear Message");

            var input = Console.ReadKey();

            while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2 && input.Key != ConsoleKey.D3 && input.Key != ConsoleKey.D4)
            {
                Console.WriteLine("Invalid Input. Try Again.");

                input = Console.ReadKey();
            }

            if (input.Key == ConsoleKey.D1)
            {
                Message.Enter(ref msg, ref encode, ref key);
            }

            else if (input.Key == ConsoleKey.D2)
            {
                App.Encode(ref msg, ref encode, ref key);
            }

            else if (input.Key == ConsoleKey.D3)
            {
                App.Decode(ref msg, ref encode, ref key);
            }

            else if (input.Key == ConsoleKey.D4)
            {
                Message.Clear(ref msg, ref encode, ref key);
            }
        }
    }
}
