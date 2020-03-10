using Adapter.MediaPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AudioPlayer : IMediaPlayer
    {
        AudioToVideoAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            switch (audioType.ToUpper()) {
                case "MP3":
                    Console.WriteLine("开始播放Mp3，文件：" + fileName);
                    break;
                case "RMVB":
                case "MP4":
                    mediaAdapter = new AudioToVideoAdapter(audioType);
                    mediaAdapter.Play(audioType, fileName);
                    break;
                default:
                    Console.WriteLine("不支持的文件格式");
                    break;
            }
        }
    }
}
