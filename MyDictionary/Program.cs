using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, string> sehirler = new Dictionary<int, string>();

            sehirler.Add(0, "Ankara");
            sehirler.Add(1, "İstanbul");

            Console.WriteLine(sehirler.Count);




            MyDictionary<int, string> isimler = new MyDictionary<int, string>();

            isimler.Add(0, "Yunus Emre");
            isimler.Add(1, "Furkan");
            isimler.Add(2, "Mert Ali");
            isimler.Add(3, "Hasan");

            Console.WriteLine(isimler.Count);



        }
    }
}
