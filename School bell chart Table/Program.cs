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
            return DateTime.Now.ToShortTimeString();
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

                    case "1:40 PM":
                        Play = true;
                        break;

                    case "1:55 PM":
                        Play = true;
                        break;

                    case "2:40 PM":
                        Play = true;
                        break;

                    case "3:25 PM":
                        Play = true;
                        break;

                    case "3:35 PM":
                        Play = true;
                        break;

                    case "4:20 PM":
                        Play = true;
                        break;

                    case "5:05 PM":
                        Play = true;
                        break;

                    case "5:50 PM":
                        Play = true;
                        break;

                    case "6:35 PM":
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
