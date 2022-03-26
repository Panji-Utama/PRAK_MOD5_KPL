using System;
using System.Collections.Generic;
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

            this.title = title;
            Random random = new Random();
            this.id = random.Next(0, 100000);
            playCount = 0;
        }

        public void IncreasePlayCount(int angka)
        {  
            playCount = playCount + angka;                        
        }

        public void PrintVideoDetails()
        {
            //Console.WriteLine(title.Length);
            //Console.WriteLine("vidID \t\t: " + id);
            //Console.WriteLine("vidTitle \t: " + title);
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
