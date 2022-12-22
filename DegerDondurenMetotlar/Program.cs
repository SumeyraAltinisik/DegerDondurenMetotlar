using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerDondurenMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           int cevap= KareninAlaniniHesapla();
            Console.WriteLine("Karenin alanı:{0}", cevap);
            Console.ReadKey();
        }

        static int KareninAlaniniHesapla()
        {
            Console.WriteLine("Hesaplamak istediğiniz karenin uzunluğunu giriniz.");
            int kenar= Convert.ToInt32(Console.ReadLine());

            int alan = kenar * kenar;
            return alan;
        }
    }
}
