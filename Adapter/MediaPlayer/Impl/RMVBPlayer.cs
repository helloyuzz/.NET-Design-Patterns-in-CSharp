using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.MediaPlayer.Impl
{
    class RMVBPlayer : IVideoMediaPlayer
    {

        public void PlayMp4(string fileName)
        {
            // 不实现
        }

        public void PlayRmvb(string fileName)
        {
            Console.WriteLine("开始播放RMVB，文件：" + fileName);
        }
    }
}
