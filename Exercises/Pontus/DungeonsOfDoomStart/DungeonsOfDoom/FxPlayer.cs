using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;

namespace DungeonsOfDoom
{
    class FxPlayer : SoundPlayer
    {
        static FxPlayer fxPlayer = new FxPlayer();

        static string filePath = Directory.GetCurrentDirectory();
        public static void PlayTheme()
        {
            
            fxPlayer.SoundLocation = filePath + @"\Sounds\16bit_ Castlevania_IV_Simon_Belmonts_Theme.wav";
            fxPlayer.Play();
        }
    }
}
