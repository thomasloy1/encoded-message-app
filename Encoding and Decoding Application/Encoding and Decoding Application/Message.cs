using System;
using System.Collections.Generic;
using System.Text;

namespace Encoding_and_Decoding_Application
{
    class Message
    {
        
        public static void Enter(ref string msg, ref string encode, ref int key)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Enter Message.");
            msg = Console.ReadLine();
            new Menu(ref msg, ref encode, ref key);
        }

        public static void Clear(ref string msg, ref string encode, ref int key)
        {
            Console.Clear();
            msg = null;
            encode = null;
            new Menu(ref msg, ref encode, ref key);
        }
    }
}
