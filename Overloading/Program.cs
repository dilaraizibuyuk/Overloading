using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Islem(int sayi1,int sayi2) //1.metot
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("İşlemin Sonucu:"+sonuc);
        }

        static void Islem(int sayi1,int sayi2,int sayi3) //2.metot
        {
            int sonuc = sayi1 * sayi2 * sayi3;
            Console.WriteLine("İşlemin Sonucu:"+sonuc);
        }

        static void Islem(int sayi1, int sayi2, int sayi3, int sayi4)//3.metot
        {
            int sonuc = sayi1 + sayi2 + sayi3 + sayi4;
            Console.WriteLine("İşlemin Sonucu:"+ sonuc);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("2 parametre=Bölme işlemi\n"+"3 Parametre=Çarpma\n"+"4 Parametre=Toplama");
            Islem(250, 5);
            Islem(30, 4, 8);
            Islem(158, 96, 74, 12);

            Console.ReadKey();

        }
    }
}
