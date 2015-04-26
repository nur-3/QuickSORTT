using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlgoritması
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int eleman_sayısı = int.Parse(Console.ReadLine());
            
            double[] dizi = new double[eleman_sayısı];
            Random rand = new Random();

            for (int i = 0; i < eleman_sayısı; i++)
            {
                dizi[i] = rand.Next() % 100;
            }

            Console.WriteLine("\nDizi\n");

            for (int i = 0; i < eleman_sayısı; i++)
            {
                Console.Write(dizi[i]);
                Console.Write(" ");
            }

            Console.WriteLine("\n\nQuickSort\n");
            sw.Start();

            Quick(dizi, 0, eleman_sayısı - 1);
            
            sw.Stop();

            for (int i = 0; i < eleman_sayısı; i++)
            {
                Console.Write(dizi[i]);
                Console.Write(" ");
            }
            

            
            
            TimeSpan toplamSure = sw.Elapsed; //  süre değerine erişimi sağlayabilmek için timespan yapısı kullanıldı.
            string sure = String.Format("{0}:{1}:{2}.{3}", toplamSure.Hours, toplamSure.Minutes, toplamSure.Seconds, toplamSure.TotalMilliseconds * 1000000);// süre bulunuldu.

            Console.WriteLine( );
            Console.WriteLine( "\nToplam Süre:" + sure); // ekrana yazdırıldı.
            Console.ReadLine(); // sure yi ekranda görebilmek için yazıldı.
        }
        public static void Quick(double [] dizi,int p,int r) {

            if (p < r)
            {
                int q = Partition(dizi, p, r);
                Quick(dizi, p, q - 1);
                Quick(dizi, q + 1, r);
            }
        }
        public static int Partition(double [] A, int p, int r)
        {
            double x = A[r];
            int i = p - 1;

            for (int j = p; j <= r - 1; j++)
            {
                if (A[j] <= x)
                {
                    i = i + 1;
                    double temp1 = A[i];
                    A[i] = A[j];
                    A[j] = temp1;
                }
            }

            double temp2 = A[i + 1];
            A[i + 1] = A[r];
            A[r] = temp2;
            return i + 1;
        }
    }
}
