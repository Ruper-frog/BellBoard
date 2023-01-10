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
        public static string checkTime()
        {
            //input time as: hh:mm
            string time = DateTime.Now.ToShortTimeString();

            Console.WriteLine(time);

            return time;
        }
        static void Main(string[] args)
        {
            bool Play;

            while (true)
            {
                Play = false;

                switch (checkTime())
                {
                    case "7:45 AM":
                        Play = true;
                        break;

                    case "8:30 AM":
                        Play = true;
                        break;

                    case "9:15 AM":
                        Play = true;
                        break;

                    case "10:00 AM":
                        Play = true;
                        break;

                    case "10:15 AM":
                        Play = true;
                        break;

                    case "11:00 AM":
                        Play = true;
                        break;

                    case "11:45 AM":
                        Play = true;
                        break;

                    case "12:10 PM":
                        Play = true;
                        break;

                    case "12:55 PM":
                        Play = true;
                        break;

                    case "13:40 PM":
                        Play = true;
                        break;

                    case "13:55 PM":
                        Play = true;
                        break;

                    case "14:40 PM":
                        Play = true;
                        break;

                    case "15:25 PM":
                        Play = true;
                        break;

                    case "15:35 PM":
                        Play = true;
                        break;

                    case "16:20 PM":
                        Play = true;
                        break;

                    case "17:05 PM":
                        Play = true;
                        break;

                    case "17:50 PM":
                        Play = true;
                        break;

                    case "18:35 PM":
                        Play = true;
                        break;
                    case "7:23 PM":
                        Play = true;
                        break;

                }
                if (Play)
                {
                    BoomBox();
                    Thread.Sleep(48000);
                }
            }
        }
    }
}
