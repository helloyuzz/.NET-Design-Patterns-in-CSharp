using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.MediaPlayer {
    interface IVideoMediaPlayer {
        void PlayRmvb(String fileName);
        void PlayMp4(String fileName);
    }
}