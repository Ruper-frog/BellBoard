using System;
using System.Media;
using System.Threading;

namespace BellBoard
{
    internal class Program
    {
        static void BoomBox()
        {
            SoundPlayer Shkira = new SoundPlayer(soundLocation: @"C:\Users\USER\source\repos\Visual Studio\Visual Studio Documents\Audio\Shakira Waka Waka.wav");
            Shkira.Play();
        }
        static string checkTime()
        {
            //input time as: hh:mm
            return DateTime.Now.ToShortTimeString();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string Time = checkTime();

                if (Time.Length > 5)
                {
                    if (Time == "7:45 AM" || Time == "8:30 AM" || Time == "9:15 AM" || Time == "10:00 AM" || Time == "10:15 AM" || Time == "11:00 AM" || Time == "11:45 AM" || Time == "12:10 PM" || Time == "12:55 PM" || Time == "1:40 PM" || Time == "1:55 PM" || Time == "2:40 PM" || Time == "3:25 PM" || Time == "3:35 PM" || Time == "4:20 PM" || Time == "5:05 PM" || Time == "5:50 PM" || Time == "6:35 PM")
                    {
                        Thread.Sleep(13000);

                        BoomBox();
                        Thread.Sleep(48000);
                    }
                }
                else if (Time == "07:45" || Time == "08:30" || Time == "09:15" || Time == "10:00" || Time == "10:15" || Time == "11:00" || Time == "11:45" || Time == "12:10" || Time == "12:55" || Time == "13:40" || Time == "13:55" || Time == "14:40" || Time == "15:25" || Time == "15:35" || Time == "16:20" || Time == "17:05" || Time == "17:50" || Time == "18:35")
                {
                    Thread.Sleep(13000);

                    BoomBox();
                    Thread.Sleep(48000);
                }
            }
        }
    }
}
