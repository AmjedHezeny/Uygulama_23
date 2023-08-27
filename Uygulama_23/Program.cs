using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.ad = "Emcet";
            ogretmen.soyad = "Hazani";
            ogretmen.yas = 27;
            ogretmen.sehir = "İstenbul";
            ogretmen.uni = "ITU";
            ogretmen.brans = "Matematik";
            ogretmen.Yazdir();

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "Mohammed";
            ogrenci.soyad = "Okla";
            ogrenci.yas = 25;
            ogrenci.sehir = "Rize";
            ogrenci.sayi = 12;
            ogrenci.okulno = 153;
            ogrenci.Yazdir();

            Console.ReadKey();
        }
    }
}