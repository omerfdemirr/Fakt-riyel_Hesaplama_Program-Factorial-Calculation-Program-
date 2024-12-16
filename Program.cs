namespace Faktöriyel_Hesaplama_Programı_Factorial_Calculation_Program_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FaktöriyelHesaplayıcı();
        }

        static void FaktöriyelHesaplayıcı()
        {
            Console.WriteLine("Faktöriyel Hesaplayıcı");

            // Kullanıcıdan bir sayı alalım
            Console.Write("Bir sayı girin: ");
            int sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı < 0)
            {
                Console.WriteLine("Negatif sayılar için faktöriyel hesaplanamaz.");
            }
            else
            {
                long faktöriyel = 1;

                // Faktöriyel hesaplama
                for (int i = 1; i <= sayı; i++)
                {
                    faktöriyel *= i;
                }

                // Sonucu yazdıralım
                Console.WriteLine($"{sayı} sayısının faktöriyel sonucu: {faktöriyel}");
            }

            // Kullanıcıya yeniden başlatma seçeneği sunalım
            Console.WriteLine("\nBaşka bir faktöriyel hesaplamak ister misiniz? (Evet/Hayır)");
            string seçim = Console.ReadLine().ToLower();

            if (seçim == "evet")
            {
                FaktöriyelHesaplayıcı(); // Metodu tekrar çağırıyoruz
            }
            else
            {
                Console.WriteLine("Program sonlanıyor...");
            }
        }


    }
}
