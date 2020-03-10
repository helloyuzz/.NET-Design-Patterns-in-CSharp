using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.MediaPlayer
{
    interface IMediaPlayer
    {
        void Play(String audioType, String fileName);
    }
}
