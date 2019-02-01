using kaffe;
using System;
using System.Collections.Generic;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Latte latte = new Latte();
            Cortado cortado = new Cortado();
            FlatWhite flatWhite = new FlatWhite(12);
            SortKaffe sortKaffe = new SortKaffe();

            List<Imælk> liste = new List<Imælk>();
            liste.Add(cortado);
            liste.Add(latte);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine("Før cast " + item.MlMælk());

            //    if (item is Latte)
            //    {
            //        Latte 1 = item as Latte;
            //        Console.WriteLine();
            //    }
            //}


           

        }
    }
}
