using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class RedPotion : Weapon, IPotion
    {
        private bool used = false;

        public RedPotion(Game game, Point location) : base(game, location){  }

        public override string Name { get { return "Red Potion"; } }

        public bool Used
        {
            get
            {
                return used;
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            used = true;
        }
    }
}
