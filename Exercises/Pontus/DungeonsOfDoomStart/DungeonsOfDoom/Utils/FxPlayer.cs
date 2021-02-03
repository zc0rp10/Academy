using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;

namespace DungeonsOfDoom
{
    class FxPlayer : WMPLib.WindowsMediaPlayerClass
    {
         
        static string filePath = Directory.GetCurrentDirectory();
        public void PlayTheme()
        {
            URL = Directory.GetCurrentDirectory() + @"\Sounds\16bit_ Castlevania_IV_Simon_Belmonts_Theme.wav";
            play();
            
        }

        public void PlayHit()
        {
            URL = filePath + @"\Sounds\attack.wav";
            play();
        }
        public void PlayVictory()
        {
            URL = filePath + @"\Sounds\victory.wav";
            play();
        }
    }
}

//   var player = new WindowsMediaPlayer();
//   player.URL = Directory.GetCurrentDirectory() + @"\Sounds\16bit_ Castlevania_IV_Simon_Belmonts_Theme.wav";
//   player.controls.play();
//   Thread.Sleep(500);
//   var player2 = new WindowsMediaPlayer();
//   player2.URL = Directory.GetCurrentDirectory() + @"\Sounds\victory.wav";
//   player2.controls.play();