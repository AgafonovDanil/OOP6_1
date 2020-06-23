using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп6
{
    class Numbers

    {
        private int OneKonst;
        private int TwoKonst;

       


        public Numbers(int OneObject)

        {
            OneKonst = OneObject;
        }

        public Numbers()
        {
        }


        public Numbers(int One, int Two)
        {
            OneKonst = One;

            TwoKonst = Two;
        }

        public void Display()
        {
            Console.WriteLine($"{OneKonst} {TwoKonst}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numbers Numbers = new Numbers();

            Numbers.Display();

            Numbers NumbersOne = new Numbers(1);

            NumbersOne.Display();

            Numbers NumbersTwo = new Numbers(2, 3);

            NumbersTwo.Display();



            Console.ReadLine();
        }
    }
}
