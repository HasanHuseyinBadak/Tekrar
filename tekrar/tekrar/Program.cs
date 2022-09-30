using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrar
{
    internal class Programma
    {
        static void Main(string[] args)
        {
            #region Alışveriş İndirim Hesaplama

            ////Müşterilerine 100₺'e kadar alışverişe %10 indirim 100-150₺ %15 150-200₺ arası toplam %20 indirim yapıyo. Ödemesi gereken fiyat tutarı
            //Console.WriteLine("HOŞGELDİNİZ");
            //Console.WriteLine("KAMPANYA'DA GEÇERLİ 100₺'e KADAR ALIŞVERİŞ YAPARSANIZ %10");
            //Console.WriteLine(" ");
            //Console.WriteLine("100-150₺ ARASINDA ALIŞVERİŞ YAPARSANIZ %15");
            //Console.WriteLine(" ");
            //Console.WriteLine("150-200₺ ARASINDA ALIŞVERİŞ YAPARSANIZ ise %20");
            //Console.WriteLine(" ");
            //Console.WriteLine("0-0   İ N D İ R İ M  F I R S A T I   0-0");
            //Console.WriteLine(" ");
            //Console.Write("ADINIZ :");
            //string ad = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine("Sayın " + ad + " " + "ALMAK İSTEDİĞİNİZ ÜRÜN 1 TANE İSE '1'e 1'den FAZLA İSE '2'e BASIN");
            //string secim = Console.ReadLine();
            //Console.Clear();


            //if (secim == "1")
            //{
            //    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Fiyatını Giriniz ;");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Sayın " + ad + " " + "Almak İstediğiniz Ürünün İndirimli Fiyatı : " + (sayi1 - (sayi1 * 0.10)) + " " + "TL");
            //    Console.WriteLine(" ");
            //    Console.WriteLine("BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ :) ");
            //}
            //else if (secim == "2")
            //{
            //    Console.WriteLine("Lütfen Almak İstediğiniz Ürünlerin Fiyatını Giriniz (max. 3 ürün) ");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());
            //    double sayi3 = Convert.ToDouble(Console.ReadLine());
            //    double sayi4 = Convert.ToDouble(Console.ReadLine());
            //    if (sayi2 + sayi3 + sayi4 <= 150 || sayi2 + sayi3 + sayi4 >= 100)
            //    {
            //        Console.WriteLine("Sayın " + ad + " " + "Almak İstediğiniz Ürünün İndirimli Fiyatı : " + (((sayi2 + sayi3 + sayi4) - (sayi2 + sayi3 + sayi4) * 0.15)) + " " + "TL");
            //    }
            //    else if (sayi2 + sayi3 + sayi4 <= 200 || sayi2 + sayi3 + sayi4 >= 150)
            //    {
            //        Console.WriteLine("Sayın " + ad + " " + "Almak İstediğiniz Ürünün İndirimli Fiyatı : " + (((sayi2 + sayi3 + sayi4) - (sayi2 + sayi3 + sayi4)) * 0.20) + " " + "TL");
            //    }
            //    Console.WriteLine("BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ :) ");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Seçim Yaptınız");
            //}

            #endregion
            #region FOR DÖNGÜSÜ

            //int toplam = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //    toplam = toplam + i;

            //}
            //Console.WriteLine("Toplam = " + toplam);

            // -------******--------

            //int toplam = 0;

            //for (int i = 0; i <= 10; i += 2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine("Çifter Çifter Toplaması = " + toplam);

            #endregion

            
            Console.WriteLine("Yaşını Öğrenmek için hayıra bas kaça gittiğini öğrenmek için evet'e bas");
            string secim = Console.ReadLine().ToLower();

            if (secim == "hayır")
            {
                Console.WriteLine("yaşınız");
            }
            if (secim == "evet")
            {
                Console.WriteLine("kaça gidiyorum");
            }
            
            Console.WriteLine(Programma.HAsan());

        }
        public int HAsan()
        {
            return 5;



        }
    }

}
