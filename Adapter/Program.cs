using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    class Program {
        static void Main(string[] args) {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "这是一首Mp3.mp3");
            audioPlayer.Play("mp4", "星际穿越.mp4");
            audioPlayer.Play("rmvb", "aaa.rmvb");
            audioPlayer.Play("vlc", "aaa.vlc");

            Console.ReadLine();
        }
    }
}