using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;


/**
    The purpose of Jukebox is to encapsulate the process of playing sounds and music for the game.
    We don't want to have to deal with this when we are writing levels or characters' actions, so we want
    a one-stop place for all our audio needs.


*/
namespace FrogKnightMonoGL
{
    class Jukebox
    {
        Song song;
        SoundEffect effect;


        float MusicVolume { get; set; }
        float EffectsVolume { get; set; }

        FrogKnight gameInstance;

        public Jukebox(FrogKnight GameInstance)
        {
            gameInstance = GameInstance;

            song = gameInstance.Content.Load<Song>("Music/Vocal.wav");
            MusicVolume = 1.0f;

        }

        public void PlayEffect()
        {
            effect = gameInstance.Content.Load<SoundEffect>("Music/MetroidDoor.wav");
            EffectsVolume = 0.025f;
            effect.Play(EffectsVolume, 0.0f, 0.0f);
        }

        public void PlaySong()
        {
            MediaPlayer.Play(song);
        }

        public void StopSong()
        {
            MediaPlayer.Stop();
        }

        public void QuietMusic()
        {
            MusicVolume = .025f;
            MediaPlayer.Volume = MusicVolume;
        }

        public void LoudMusic()
        {
            MusicVolume = 1.0f;
            MediaPlayer.Volume = MusicVolume;
        }
    }
}
