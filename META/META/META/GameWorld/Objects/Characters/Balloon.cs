﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using META.Engine.Sprites;

namespace META.GameWorld.Objects.Characters
{
    public class Balloon : Enemy
    {
        public Balloon(Vector2 _position)
            : base(new Rectangle((int)_position.X, (int)_position.Y, 72, 83), SpriteID.Balloon, Sound.BalloonKill, Sound.BalloonDeath, 0, 0, new Rectangle(-112, -40, 300, 242))
        {
        }

        public override int GetDirection()
        {
            return -Math.Sign(Player.Main.position.X - position.X);
        }
    }
}
