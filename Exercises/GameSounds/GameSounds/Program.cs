using System;
using System.IO;
using System.Media;

namespace GameSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer fxPlayer = new SoundPlayer();
            PlayAttack(fxPlayer);
            PlayFire(fxPlayer);
            PlayIce(fxPlayer);
            PlayNoMana(fxPlayer);
            PlayVictory(fxPlayer);


        }

        static void PlayAttack(SoundPlayer fxPlayer)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\sounds\attack.wav";
            fxPlayer.SoundLocation = filePath;
            fxPlayer.PlaySync();
        }

        static void PlayFire(SoundPlayer fxPlayer)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\sounds\fire.wav";
            fxPlayer.SoundLocation = filePath;
            fxPlayer.PlaySync();
        }

        static void PlayIce(SoundPlayer fxPlayer)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\sounds\ice.wav";
            fxPlayer.SoundLocation = filePath;
            fxPlayer.PlaySync();
        }

        static void PlayNoMana(SoundPlayer fxPlayer)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\sounds\nomana.wav";
            fxPlayer.SoundLocation = filePath;
            fxPlayer.PlaySync();
        }

        static void PlayVictory(SoundPlayer fxPlayer)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\sounds\victory.wav";
            fxPlayer.SoundLocation = filePath;
            fxPlayer.PlaySync();
        }

    }
}
