using System;
using System.Drawing;

namespace The_Quest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location,1) { }
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