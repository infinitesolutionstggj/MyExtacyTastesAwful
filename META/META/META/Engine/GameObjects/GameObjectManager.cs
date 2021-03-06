﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using META.GameWorld.Objects;
using META.GameWorld.Objects.Characters;
using META.Engine.Sprites;

namespace META.Engine.GameObjects
{
	public static class GameObjectManager
	{
		public static List<GameObject> Objects;

		public static void Initialize()
		{
			Objects = new List<GameObject>();
			Objects.Add(new Player(new Vector2(10, -300)));
			Objects.Add(new GenericTestObstacle(new Rectangle(170, 352, 974, 68)));
			Objects.Add(new GenericTestObstacle(new Rectangle(0, 1006, 1744, 74)));
			Objects.Add(new GenericTestObstacle(new Rectangle(1894, 800, 398, 280)));
			Objects.Add(new GenericTestObstacle(new Rectangle(1364, 558, 346, 70)));
			Objects.Add(new GenericTestObstacle(new Rectangle(1880, 265, 440, 17)));
			Objects.Add(new GenericTestObstacle(new Rectangle(2648, 360, 86, 720)));
			Objects.Add(new GenericTestObstacle(new Rectangle(2734, 360, 592, 20)));
			Objects.Add(new GenericTestObstacle(new Rectangle(3316, 670, 466, 90)));
			Objects.Add(new GenericTestObstacle(new Rectangle(3727, 1016, 1057, 64)));
			Objects.Add(new GenericTestObstacle(new Rectangle(4935, 830, 312, 175)));
			Objects.Add(new GenericTestObstacle(new Rectangle(5130, 615, 390, 203)));
			Objects.Add(new GenericTestObstacle(new Rectangle(5282, 1011, 1596, 69)));
			Objects.Add(new GenericTestObstacle(new Rectangle(7150, 352, 750, 136)));
			Objects.Add(new GenericTestObstacle(new Rectangle(7900, 400, 116, 110)));
			Objects.Add(new GenericTestObstacle(new Rectangle(8858, 639, 400, 75)));
			Objects.Add(new GenericTestObstacle(new Rectangle(9391, 499, 400, 31)));
			Objects.Add(new GenericTestObstacle(new Rectangle(9999, 342, 148, 16)));
			Objects.Add(new GenericTestObstacle(new Rectangle(7325, 1016, 2571, 64)));
			Objects.Add(new GenericTestObstacle(new Rectangle(5451, 457, 1491, 60)));

			Objects.Add(new Butterfly(new Vector2(1024, 650), 3));
			Objects.Add(new Butterfly(new Vector2(3125, 200), 3));
			Objects.Add(new Butterfly(new Vector2(3050, 780), 1.5f));
			Objects.Add(new Butterfly(new Vector2(6300, 750), 2));

			Objects.Add(new LimitedBoundsCrab(new Vector2(1500, 400), 1364, 1710));
			Objects.Add(new LimitedBoundsCrab(new Vector2(3500, 500), 3316, 3782));
			Objects.Add(new LimitedBoundsCrab(new Vector2(4150, 820), 2648, 3326));
			Objects.Add(new LimitedBoundsCrab(new Vector2(6500, 800), 5282, 6878));
			Objects.Add(new LimitedBoundsCrab(new Vector2(8525, 850), 7920, 8820));

			Objects.Add(new Balloon(new Vector2(2350, 623)));
			Objects.Add(new Balloon(new Vector2(2530, 450)));
			Objects.Add(new Balloon(new Vector2(4150, 225)));
			Objects.Add(new Balloon(new Vector2(4450, 325)));
			Objects.Add(new Balloon(new Vector2(4750, 425)));
			Objects.Add(new Balloon(new Vector2(8120, 250)));
			Objects.Add(new Balloon(new Vector2(8500, 360)));
		}

		public static void Update(GameTime gameTime)
		{
			foreach (var o in Objects)
				o.Update(gameTime);
		}

		public static void Draw()
		{
			foreach (var o in Objects)
				o.Draw();
		}
	}
}
