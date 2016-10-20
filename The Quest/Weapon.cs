using System;
using System.Drawing;

namespace The_Quest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp  { get; private set; }
        public Weapon(Game game, Point location) : base(game, location)  
        {
            PickedUp = false;
        }
        public void PickUpWeapon() { PickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 20; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        private Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            Point newLocation = target;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - 50 >= boundaries.Top) newLocation.Y -= 50;
                    break;
                case Direction.Down:
                    if (newLocation.Y + 50 <= boundaries.Bottom) newLocation.Y += 50;
                    break;
                case Direction.Left:
                    if (newLocation.X - 50 >= boundaries.Left) newLocation.X -= 50;
                    break;
                case Direction.Right:
                    if (newLocation.X + 50 <= boundaries.Right) newLocation.X += 50;
                    break;
                default:
                    break;
            }
            return newLocation;
        }

        private bool Nearby(Point location, Point target, int distance)
        {
            if (Math.Abs(location.X - target.X) < distance &&
              (Math.Abs(location.Y - target.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}