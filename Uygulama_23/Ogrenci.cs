using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_23
{
    internal class Ogrenci:Kisi
    {
        public int sayi, okulno;
        public new void Yazdir()
        {
            Console.WriteLine("Öğrenci Bilgileri.\n-------------");
            Console.WriteLine("Öğrencinin Adı: " + ad);
            Console.WriteLine("Öğrencinin Soyadı: " + soyad);
            Console.WriteLine("Öğrencinin Yaşı: " + yas);
            Console.WriteLine("Öğrencinin Memleketi: " + sehir);
            Console.WriteLine("Öğrencinin  Sınıfı: " + sayi);
            Console.WriteLine("Öğrencinin OKul NOsu: " + okulno);
        }
    }
}