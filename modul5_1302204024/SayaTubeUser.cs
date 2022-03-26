using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modul5_1302204024
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(String a)
        {
            Random c = new Random();
            this.id = c.Next(10000, 100000);//in range 10000-100000
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = a;

        }

        public int GetTotalVideoPlayCount()
        {
            int hasil = 0;
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                hasil += video.getPlay();
            }
            return hasil;
        }

        public void AddVideos(SayaTubeVideo a)
        {
            uploadedVideos.Add(a);
        }

        public void PrintAllVideoPlayCount()
        {
            int i = 0;
            Console.WriteLine("User :" + this.username);
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                Console.WriteLine("Video " + (i + 1) + " judul : " + this.uploadedVideos[i].getTitle());
                i++;
            }
        }
    }
}
