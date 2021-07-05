using Adapter.MediaPlayer;
using Adapter.MediaPlayer.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    // 适配器
    class AudioToVideoAdapter : IMediaPlayer {
        IVideoMediaPlayer videoPlayer;

        public AudioToVideoAdapter(String audioType) {
            switch (audioType.ToUpper()) {
                case "RMVB":
                    videoPlayer = new RMVBPlayer();
                    break;
                case "MP4":
                    videoPlayer = new Mp4Player();
                    break;
            }
        }
        public void Play(string audioType, string fileName) {
            switch (audioType.ToUpper()) {
                case "RMVB":
                    videoPlayer.PlayRmvb(fileName);
                    break;
                case "MP4":
                    videoPlayer.PlayMp4(fileName);
                    break;
            }
        }
    }
}