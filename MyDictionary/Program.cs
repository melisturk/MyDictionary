using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Melis");
            isimler.Add("Selin");
            isimler.Add("İpek");

            Console.WriteLine(isimler.Count + " elemanlıdır.");

        }
    }
}
