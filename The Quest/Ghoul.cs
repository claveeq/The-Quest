using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 1) { }
        public override void Move(Random random)
        {
            // Your code will go here    
            if (!base.Dead)
            {
                base.location = Move(base.FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (base.NearPlayer())
                    game.HitPlayer(1, random);
            }
        }
    }
}
