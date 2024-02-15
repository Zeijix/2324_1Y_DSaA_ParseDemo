using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_DSaA_ParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to declare a variable
            // <dataType> <variableName> = <initialValue>;
            bool a = true;
            byte b = 12;
            short c = 12;
            int d = 12;
            long e = 12;
            float f = 12f;
            double g = 12d;
            char h = 'z';
            string i = "A";

            Console.WriteLine($"The character {h} when converted" +
                $" to byte has a value of {(byte)h}");
            Console.WriteLine($"The character {h} when converted" +
                $" to short or int16 has a value of {(short)h}");
            Console.WriteLine($"The character {h} when converted" +
                $" to int has a value of {(int)h}");
            Console.WriteLine($"The character {h} when converted" +
                $" to long or int64 has a value of {(long)h}");
            Console.WriteLine($"The character {h} when converted" +
                $" to float has a value of {(float)h}");
            Console.WriteLine($"The character {h} when converted" +
                $" to double has a value of {(double)h}");
            // Regular concatination version
            Console.WriteLine("The character " + h + " when converted" +
                " to double has a value of " + (double)h);
            // No concatination
            Console.Write("The character ");
            Console.Write(h);
            Console.Write(" when converted to double has a value of ");
            Console.WriteLine((double)h);

            Console.WriteLine();

            Console.WriteLine($"The number 69 when converted to a" +
                $" character is {(char)69}");
            // Regular concatination version
            Console.WriteLine("The number 69 when converted to a" +
                " character is " + (char)125);

            Console.WriteLine();

            for (int x = 0; x < 26; x++)
                Console.Write((char)(x + 65));
            Console.WriteLine();
            for (int x = 0; x < 26; x++)
                Console.Write((char)(x + 97));

            Console.Write("\n\nPlease input any number between 0 - 255: ");
            i = Console.ReadLine();
            b = byte.Parse(i);
            c = short.Parse(i);
            d = int.Parse(i);
            e = long.Parse(i);
            f = float.Parse(i);
            g = double.Parse(i);

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            Console.Write("\n\nPlease input any number between 0 - 255 with decimal: ");
            i = Console.ReadLine();
            //b = byte.Parse(i);
            //c = short.Parse(i);
            //d = int.Parse(i);
            //e = long.Parse(i);
            f = float.Parse(i);
            g = double.Parse(i);

            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            Console.ReadKey();
        }
    }
}
