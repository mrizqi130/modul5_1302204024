using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204024
{
    //internal class SayaTubeVideo
    //{
    //}
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        //public int a;

        public SayaTubeVideo(string a)
        {
            //Debug.Assert(a != null && a.Length < 101);
            Random b = new Random();

            this.id = b.Next(10000, 100000);//in range 10000-100000
            this.title = a;
            playCount = 0;
        }

        public void IncreasePlayCount(int a)
        {
            //Debug.Assert(a <= 10000000);
            //try
            //{
            //    playCount = checked(playCount + a);
            //}
            //catch (System.OverflowException e)
            //{
            //    Console.WriteLine("UNCHECKED and CAUGHT:  " + e.ToString());
            //}
            playCount = checked(playCount + a);
        }

        public int getPlay()
        {
            return playCount;
        }
        public string getTitle()
        {
            return title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();
        }
    }
}
