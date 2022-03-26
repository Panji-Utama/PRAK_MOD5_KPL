using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("Panji");
            SayaTubeUser user2 = new SayaTubeUser("INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER" +
                "INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER" +
                "INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER" +
                "INI UNTUK USERNAME YANG LEBIH DARI 100 KARAKTER");
            //null username
            //SayaTubeUser user3 = new SayaTubeUser(null);

            SayaTubeVideo vid1 = new SayaTubeVideo("Review Film Big Hero 6 oleh Panji");
            user1.AddVideo(vid1);

            SayaTubeVideo vid2 = new SayaTubeVideo("Review Film Ambulance oleh Panji");
            user1.AddVideo(vid2);

            //maxChar
            //SayaTubeVideo vid3 = new SayaTubeVideo("Review Film INI JUDUL FILM YANG CERITANYA KARAKTERNYA LEBIH DARI 200 " +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA MAKANYA SAYA ASAL TULIS BEGINI DAN COPY INI oleh Panji" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA MAKANYA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "V" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA" +
            //    "CUMA SAYA TIDAK TAU MAU TULIS APA");
            SayaTubeVideo vid3 = new SayaTubeVideo("Review Film Karate Kid oleh Panji");
            user1.AddVideo(vid3);

            SayaTubeVideo vid4 = new SayaTubeVideo("Review Film Ron Gone Wrong oleh Panji");
            user1.AddVideo(vid4);

            SayaTubeVideo vid5 = new SayaTubeVideo("Review Film Kungfu Panda oleh Panji");
            user1.AddVideo(vid5);

            SayaTubeVideo vid6 = new SayaTubeVideo("Review Film Kungfu Panda 2 oleh Panji");
            user1.AddVideo(vid6);

            //null
            string utkNULL = null;
            SayaTubeVideo vid7 = new SayaTubeVideo("Review Film Capek oleh Panji");
            user1.AddVideo(vid7);

            //playcount
            SayaTubeVideo vid8 = new SayaTubeVideo("Review Film Kungfu Panda 3 oleh Panji");
            vid8.IncreasePlayCount(25000001);
            user1.AddVideo(vid8);

            //playcount negatif
            SayaTubeVideo vid9 = new SayaTubeVideo("Review Film HxH oleh Panji");
            vid8.IncreasePlayCount(-1);
            user1.AddVideo(vid9);

            SayaTubeVideo vid10 = new SayaTubeVideo("Review Film Deadpool oleh Panji");
            user1.AddVideo(vid10);
            //vid null
            user1.AddVideo(null);

            //max == 2147483647
            vid10.IncreasePlayCount(900000000);
            vid10.IncreasePlayCount(900000000);
            vid10.IncreasePlayCount(900000000);
            vid10.IncreasePlayCount(900000000);

            //vid10.getPlayCount();
            user1.GetTotalVideoPlayCount();

            //printAll
            user1.PrintAllVideoPlaycount();
            Console.WriteLine("\n");
        }
    }
}
