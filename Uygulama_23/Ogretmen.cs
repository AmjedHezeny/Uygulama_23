using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_23
{
    internal class Ogretmen : Kisi
    {
        public string uni, brans;

        public new void Yazdir()
        {
            Console.WriteLine("Öğretmen Bilgileri.\n-------------");
            Console.WriteLine("Öğretmenin Adı: " + ad);
            Console.WriteLine("Öğretmenin Soyadı: " + soyad);
            Console.WriteLine("Öğretmenin Yaşı: " + yas);
            Console.WriteLine("Öğretmenin Memleketi: " + sehir);
            Console.WriteLine("Mezun Olduğu Üni: " + uni);
            Console.WriteLine("Çalıştığı Branş: " + brans);
        }
    }
}
