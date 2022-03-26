using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200089
{
    internal class SayaTubeUser
    {
        private int id;
        public string Username;
        List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string uname)
        {
            Debug.Assert(uname.Length <= 100, "Panjang username maks 100 char!");
            Debug.Assert(uname != null, "Username tidak boleh null");
            this.Username = uname;
            Random random = new Random();
            this.id = random.Next(0, 100000);
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total, tambah;
            total = 0;

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                tambah = uploadedVideos[i].getPlayCount();
                total = total + tambah;
            }

            return total;
        }

        public void AddVideo(SayaTubeVideo x)
        {
            Debug.Assert(x != null, "Video yang ditambahkan tidak berupa null!");
            Debug.Assert(x.getPlayCount() < int.MaxValue, "playCount harus kurang dari int max!");
            uploadedVideos.Add(x);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User \t: " + this.Username);
            Console.WriteLine("\n");
            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul \t: " + uploadedVideos[i].getTitle());
                Console.WriteLine("\n");
                //uploadedVideos[i].PrintVideoDetails();
            }
        }
    }
}
