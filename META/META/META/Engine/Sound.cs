﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace META
{
    static class Sound
    {
		public static SoundEffectInstance Music;
		public static SoundEffect MusicSound;

		public static SoundEffect AchievementUnlocked;
		public static SoundEffect LevelComplete;
		public static SoundEffect Pause;
		public static SoundEffect PlayerJump;
		public static SoundEffect PlayerLand;
		public static SoundEffect PlayerFall;
		public static SoundEffect SpikeKill;
		public static SoundEffect BalloonKill;
		public static SoundEffect BalloonDeath;
		public static SoundEffect ButterflyKill;
		public static SoundEffect ButterflyDeath;
		public static SoundEffect CrabKill;
		public static SoundEffect CrabDeath;

		public static void PlayMusic()
		{
			Music = MusicSound.CreateInstance();
			Music.IsLooped = true;
			Music.Play();
		}

		public static void PauseMusic()
		{
			Music.Pause();
		}

		public static void ResumeMusic()
		{
			Music.Resume();
		}

		public static void SetMute(bool muted)
		{
			Music.Volume = muted ? 0 : 1;
		}

        public static void LoadContent(ContentManager content)
        {
            MusicSound = content.Load<SoundEffect>("Sounds/Music");

			AchievementUnlocked = content.Load<SoundEffect>("Sounds/Achievement");
			LevelComplete = content.Load<SoundEffect>("Sounds/Complete");
			Pause = content.Load<SoundEffect>("Sounds/Pause");
			PlayerJump = content.Load<SoundEffect>("Sounds/Jump");
			PlayerLand = content.Load<SoundEffect>("Sounds/Land");
			PlayerFall = content.Load<SoundEffect>("Sounds/Pitfall");
			SpikeKill = content.Load<SoundEffect>("Sounds/SpikeKill");
			BalloonKill = content.Load<SoundEffect>("Sounds/BalloonKill");
			BalloonDeath = content.Load<SoundEffect>("Sounds/BalloonDeath");
			ButterflyKill = content.Load<SoundEffect>("Sounds/ButterflyKill");
			ButterflyDeath = content.Load<SoundEffect>("Sounds/ButterflyDeath");
			CrabKill = content.Load<SoundEffect>("Sounds/CrabKill");
			CrabDeath = content.Load<SoundEffect>("Sounds/CrabDeath");
        }
    }
}
