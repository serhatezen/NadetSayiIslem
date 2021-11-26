using System;

namespace NadetSayiIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N Adet sayıyla 4 İşlem");
            
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz(+,-,*,/)");
            char islem = Convert.ToChar(Console.ReadLine());
            float islemSonucu = Islem(islem);
            Console.WriteLine($"İşlem sonucunuz={islemSonucu}");

            Console.ReadKey();
        }
        private static float Islem(char islem)
        {
            Console.WriteLine("Kaç adet sayıyla işlem yapmak istersiniz");
            int n = Convert.ToInt32(Console.ReadLine());
            float[] sayilar = new float[n];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı giriniz");
                sayilar[i] = Convert.ToSingle(Console.ReadLine());
            }

            float sonuc=sayilar[0];
            switch (islem)
            {
                case '+':
                    foreach (var item in sayilar)
                        sonuc += item;
                        sonuc=sonuc-sayilar[0];
                    
                    break;
                case '-':
                    foreach (var item in sayilar)
                        sonuc =sonuc- item;
                    sonuc = sonuc + sayilar[0];

                    break;
                case '*':
                    foreach (var item in sayilar)
                        sonuc*=item;
                    sonuc = sonuc / sayilar[0];
                    break;
                case '/':
                    foreach (var item in sayilar)
                        sonuc /=item;
                    sonuc = sonuc * sayilar[0];
                    
                    break;
            }
            return sonuc;
        }
    }
}
