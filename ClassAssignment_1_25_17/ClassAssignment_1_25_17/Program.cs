using System;

namespace ClassAssignment_1_25_17
{
    class Program
    {
        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                tail = value.Substring(4);
                head = value.Remove(4, 4);
            }
            string value;
            string tail;
            string head;
            public override string ToString()
            {
                return value;
            }
            public string Head
            {
                get
                {
                    return head;
                }
            }

            public string Tail
            {
                get
                {
                    return tail;
                }
            }
        }

        static public char Invert(char s)
        {
            // ternary operator that returns a character of 1 if it was a 0 and a character of 0 if it was a 1;
            return ((s == '0') ? '1' : '0');
        }

        // Write a function that takes in as an argument, a string represention of a binary number whose maximum amount is 2n8.
        // this function must return a string matching this format except the first half should be exact opposite of the second half.
        static public string FlipItUp(string tail)
        {
            string flipped = "";

            foreach (var v in tail)
                flipped += Invert(v);
            flipped += tail;

            return flipped;
        }

        static void Main(string[] args)
        {
            Gene BinNumber = new Gene("10011011");
            
            Console.WriteLine(BinNumber);
            Console.WriteLine("\n");

            BinNumber = new Gene(FlipItUp(BinNumber.Tail));

            Console.WriteLine(BinNumber);
            Console.ReadLine();
        }
    }
}