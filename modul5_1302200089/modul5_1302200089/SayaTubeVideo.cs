using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200089
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length <= 200, "Panjang maksimal judul 200 karakter!");
            Debug.Assert(title != null, "Judul tidak boleh NULL!");
            this.title = title;

            Random random = new Random();
            this.id = random.Next(0, 100000);
            playCount = 0;
        }

        public void IncreasePlayCount(int angka)
        {  
            //25.000.000
            Debug.Assert(angka <= 25000000, "Angka maks 25.000.000!");
            Debug.Assert(angka > 0, "Angka tidak boleh negatif!");

            int x;
            try
            {
                x = checked(this.playCount + angka);
                this.playCount = this.playCount + angka;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\nTerjadi error Overflow: " + e.Message);
                Console.WriteLine("playCount akan ditambah 1");
                this.playCount++;
            }
        }

        public void PrintVideoDetails()
        {
            //Console.WriteLine(title.Length);
            Console.WriteLine("vidTitle \t: " + title);
            Console.WriteLine("vidID \t\t: " + id);
            Console.WriteLine("vidPlayCount \t: " + playCount);
            Console.WriteLine("\n");
        }
        
        public int getPlayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
