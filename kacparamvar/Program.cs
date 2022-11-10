using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kacparamvar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tlTutar = Cevir("Kaç tln var");
            decimal euroTutar = Cevir("Kaç euron var");
            decimal dolarTutar = Cevir("Kaç doların var");
            dolarTutar = kurHesapla(dolarTutar,"Dolar Kuru ne kadar");
            euroTutar = kurHesapla(euroTutar, "Euro Kuru ne kadar");
            decimal toplam = tlTutar + euroTutar + dolarTutar;
            Yazdır(toplam);
        }
        static decimal  Cevir (string soru)
        {
            try
            {
                Console.WriteLine(soru);
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("sayısal değer giriniz");
                Cevir(soru);
                return 0;
            }
           
        }
        static decimal kurHesapla(decimal yp , string kurSoru)
        {
          decimal kur = Cevir(kurSoru);
            return yp*kur;
        }
        static void Yazdır(decimal toplam)
        {
            Console.WriteLine ("Toplam Değer"+toplam);
            Console.ReadLine();
        }
        
    }
}
