using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    internal class Starter
    {
        public static void Run()
        {
            IPrintAviary ui = new UI();
            Aviary aviary = new Aviary();

            ui.PrintAviary(aviary.Animals);
            

            Console.WriteLine(aviary.Animals);
        }
    }
}
