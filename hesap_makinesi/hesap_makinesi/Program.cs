using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
        Tekrar:
            try
            {
                int sayi1, sayi2;
                char islem;
                Console.WriteLine("Lütfen ilk sayiyi giriniz: ");
                sayi1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen ikinci sayiyi giriniz: ");
                sayi2 = int.Parse(Console.ReadLine());

                Console.WriteLine("İşlemgiriniz.");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-Çıkarma");
                Console.WriteLine("3-Çarpma");
                Console.WriteLine("4-Bölme");
                Console.WriteLine("5-Çıkış içinfarklıbirtuşabasınız.");
                islem = char.Parse(Console.ReadLine());

                if ((islem == 'T') || (islem == '1') || (islem == '+') || (islem == 't'))
                {
                    Console.WriteLine(sayi1 + "+" + sayi2 + "=" + (sayi1 + sayi2));
                }
                else if ((islem == 'E') || (islem == '2') || (islem == '-') || (islem == 'e'))
                {
                    Console.WriteLine(sayi1 + "-" + sayi2 + "=" + (sayi1 - sayi2));
                }
                else if ((islem == 'Ç') || (islem == '3') || (islem == '*') || (islem == 'ç'))
                {
                    Console.WriteLine(sayi1 + "*" + sayi2 + "=" + (sayi1 * sayi2));
                }
                else if ((islem == 'B') || (islem == '4') || (islem == '/') || (islem == 'b'))
                {
                    Console.WriteLine(sayi1 + "/" + sayi2 + "=" + (Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2)));
                }
                else
                {
                    Console.WriteLine("Oturum kapatılıyor.");
                    Console.Clear();

                }
                Console.WriteLine("Bir daha işlem yapmak istiyor musunuz? (e/h)");
                char istek = Char.Parse(Console.ReadLine());
                if (istek == 'e')
                {
                    Console.Clear();
                    goto Tekrar;
                }
                else
                {
                    Console.WriteLine("Oturum kapatılıyor...");
                    Console.Clear();
                }

            }


            catch
            {
                Console.WriteLine("Tekrar deneyiniz.");
                Console.WriteLine("--------------------");
                goto Tekrar;
            }



            Console.ReadKey();





        }
    }
}
