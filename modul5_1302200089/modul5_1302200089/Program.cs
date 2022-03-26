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

            SayaTubeVideo vid1 = new SayaTubeVideo("Review Film Big Hero 6 oleh Panji");
            user1.AddVideo(vid1);

            SayaTubeVideo vid2 = new SayaTubeVideo("Review Film Ambulance oleh Panji");
            user1.AddVideo(vid2);

            SayaTubeVideo vid3 = new SayaTubeVideo("Review Film Waifumu Tidak Nyata oleh Panji");
            user1.AddVideo(vid3);

            SayaTubeVideo vid4 = new SayaTubeVideo("Review Film Ron Gone Wrong oleh Panji");
            user1.AddVideo(vid4);

            SayaTubeVideo vid5 = new SayaTubeVideo("Review Film Kungfu Panda oleh Panji");
            user1.AddVideo(vid5);

            SayaTubeVideo vid6 = new SayaTubeVideo("Review Film Kungfu Panda 2 oleh Panji");
            user1.AddVideo(vid6);

            SayaTubeVideo vid7 = new SayaTubeVideo("Review Film Highschool of The Dead oleh Panji");
            user1.AddVideo(vid7);

            SayaTubeVideo vid8 = new SayaTubeVideo("Review Film Kungfu Panda 3 oleh Panji");
            user1.AddVideo(vid8);

            SayaTubeVideo vid9 = new SayaTubeVideo("Review Film HxH oleh Panji");
            user1.AddVideo(vid9);

            SayaTubeVideo vid10 = new SayaTubeVideo("Review Film Deadpool oleh Panji");
            user1.AddVideo(vid10);


            //printAll
            user1.PrintAllVideoPlaycount();
            Console.WriteLine("\n");
        }
    }
}
