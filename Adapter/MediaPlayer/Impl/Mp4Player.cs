using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.MediaPlayer.Impl
{
    class Mp4Player : IVideoMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("开始播放Mp4，文件：" + fileName);
        }

        public void PlayRmvb(string fileName)
        {
            // 无需实现
        }
    }
}
