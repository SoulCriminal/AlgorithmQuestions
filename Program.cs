using System;

namespace AlgoritmaOdevPatika
{
    class Program
    {
        public static string Developer ="Hakkı AYMAN";
        static void Main(string[] args)
        {
            // Soru 1:
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            
            //kullanıcıdan bir sayı alınır
            Console.WriteLine("Lütfen Bir Sayı Giriniz!");
            int gsayi = Convert.ToInt32(Console.ReadLine());
            //alınan sayı dizi tanımlamakta kullanılır ve döngüye alınır.
            int[] sayilar = new int [gsayi];
            for(int i =0;i<gsayi;i++)
            {
                //döngü içerisinde kullanıcıdan ilk girdiği sayı kadar sayı girmesi istenir ve girdiği 
                // sayılar dizi içerisine eklenir.
                Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }
            //oluşturulan dizi içerisinde gezerek çift olanları kontrol edip ekrana yazdırırız.
            foreach(var item in sayilar)
            {
                if(item%2 == 0)
                {
                    Console.WriteLine("Girilen sayılardan çift olanlar: "+item);
                }
            }
            // Soru 2:
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayiyi giriniz");
            double m = Convert.ToInt32(Console.ReadLine());
            double[] sayilar2 = new double[n];
            for(int i = 0; i<n;i++)
            {
                Console.WriteLine($"Lütfen Dizi için {i+1}. sayıyı giriniz");
                sayilar2[i]= Convert.ToDouble(Console.ReadLine());

            }
            foreach (var item in sayilar2)
            {
                if(item == m || m%item ==0)
                {
                    Console.WriteLine(item);
                }else{
                    Console.WriteLine($"{item} sayısı 2. sayıya eşit değil ve tam bölünemedi");
                }
            }
            // Soru 3:
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


            Console.WriteLine("Lütfen bir sayı giriniz");
            int g1= Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[g1]; 
            for(int i =0; i<g1;i++)
            {
                Console.WriteLine($"{i+1}. kelimeyi giriniz!");
                kelimeler[i]=Console.ReadLine();
            }
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
               Console.WriteLine(item);
            }
           // 4. soru:
           //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            string cumle;
            Console.Write("Cümle Girin  : ");
            cumle = Console.ReadLine();
            string[] kelimeler1 = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı :"+kelimeler1.Length);
            Console.WriteLine("Harf Sayısı : "+cumle.Length);
            

        }
    }
}
