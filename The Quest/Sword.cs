using System;
using System.Drawing;

namespace The_Quest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location) { }
        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random)
        {
            base.DamageEnemy(direction, 30, 4, random);
        } 
    }
}