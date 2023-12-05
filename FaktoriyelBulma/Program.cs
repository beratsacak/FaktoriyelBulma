using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islem islem = new Islem();
            Console.Write("Faktöriyelini Bulmak İstedigin Sayıyı Gir: ");
            long s2=Convert.ToInt64(Console.ReadLine());
            long sonuc = islem.Fak(s2);
            Console.WriteLine("Sayının Faktöriyeli = "+sonuc);
        }
    }
    class Islem
    {
        public long Fak(long sayi)
        {
            long sonuc =1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
                
            }
            return sonuc;
        }
    }
}
