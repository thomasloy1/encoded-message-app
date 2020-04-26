using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoding_and_Decoding_Application
{
    class App
    {
        public string msg;
        public string encode;
        public int key;

        public void Run()
        {
            new Menu(ref msg, ref encode, ref key);
        }

        public static void Encode(ref string msg, ref string encode, ref int key)
        {
            Encoding ascii = Encoding.ASCII;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("What letter would you like to encode this message with?");
            var input = Console.ReadLine();
            
            char ch;
            while (!char.TryParse(input, out ch) && !Char.IsLetter(ch))
            {
                Console.WriteLine("Not a letter. Try again.");
                input = Console.ReadLine();
            }

            key = Key.KeySelect(ch);

            int key2 = key;

            encode = msg;

            Console.WriteLine(encode);

            //Message => ascii byte array => int array => add value to each element => ascii byte array => encoded string
            Byte[] encodedBytes = ascii.GetBytes(encode);

            int[] encodedInts = new int[] { };

            foreach (Byte x in encodedBytes)
            {
                encodedInts = encodedBytes.Select(x => (int)x).ToArray();
            }

            int[] encodedInts2 = new int[] { };

            for (int i = 0; i < encodedInts.Length; i++)
            {
                encodedInts2 = encodedInts.Select(i => i + key2).ToArray();
            }

            foreach (int j in encodedInts)
            {
                encodedBytes = encodedInts2.Select(j => (byte)j).ToArray();
            }

            encode = ascii.GetString(encodedBytes);

            Console.WriteLine(encode);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            new Menu(ref encode, ref msg, ref key);
        }

        public static void Decode(ref string msg, ref string encode, ref int key)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Enter Encoded Message.");
            encode = Console.ReadLine();

            Encoding ascii = Encoding.ASCII;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("What letter would you like to decode this message with?");
            var input = Console.ReadLine();

            char ch;
            while (!char.TryParse(input, out ch) && !Char.IsLetter(ch))
            {
                Console.WriteLine("Not a letter. Try again.");
                input = Console.ReadLine();
            }

            key = Key.KeySelect(ch);

            int key2 = key;

            Console.WriteLine(encode);

            //Message => ascii byte array => int array => add value to each element => ascii byte array => encoded string
            Byte[] encodedBytes = ascii.GetBytes(encode);

            int[] encodedInts = new int[] { };

            foreach (Byte x in encodedBytes)
            {
                encodedInts = encodedBytes.Select(x => (int)x).ToArray();
            }

            int[] encodedInts2 = new int[] { };

            for (int i = 0; i < encodedInts.Length; i++)
            {
                encodedInts2 = encodedInts.Select(i => i - key2).ToArray();
            }

            foreach (int j in encodedInts)
            {
                encodedBytes = encodedInts2.Select(j => (byte)j).ToArray();
            }

            msg = ascii.GetString(encodedBytes);

            Console.WriteLine(msg);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            new Menu(ref encode, ref msg, ref key);
        }



    }
}
