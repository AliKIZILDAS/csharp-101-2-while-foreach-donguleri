using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac+=1;     
            }
            double ort=(double)toplam/sayi;
            Console.WriteLine(ort);          
            //a dan z bütün karakterleri consola yazdıralım.
            char ch='a';
            while (ch<='z')
            {
                Console.WriteLine(ch);
                ch++;
            }
            //***foreach***
            string[] arabalar={"BMW","FORD","TOYOTA","NİSSAN"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}