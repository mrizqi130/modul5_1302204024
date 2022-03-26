using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser a = new SayaTubeUser("rizqi");
            SayaTubeVideo b = new SayaTubeVideo("Review Film satu oleh Muhammad Rizqi Anshari");
            SayaTubeVideo c = new SayaTubeVideo("Review Film dua oleh Muhammad Rizqi Anshari");
            SayaTubeVideo d = new SayaTubeVideo("Review Film tiga oleh Muhammad Rizqi Anshari");
            
            a.AddVideos(b);
            
            a.AddVideos(c);
            
            a.AddVideos(d);
            a.PrintAllVideoPlayCount();

            Console.WriteLine();
            Console.WriteLine();

            SayaTubeVideo e = new SayaTubeVideo(null);
            

            for (int i = 0; i < 65538000; i++)
            {
                e.IncreasePlayCount(i);
            }

        }
    }

}
