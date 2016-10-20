using System.Drawing;
using System.Collections.Generic;
using System;

namespace The_Quest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints{ get; private set; }

        private List<Weapon> inventory = new List<Weapon>();

        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }


        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 100;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                // see if the weapon is nearby, and possibly pick it up 
                if (game.WeaponInRoom.Nearby(base.location, 30))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);

                }
                    
            }
        }
        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                if (equippedWeapon is IPotion)
                {
                    IPotion potion = equippedWeapon as IPotion;
                    if(!potion.Used)
                        equippedWeapon.Attack(direction, random);
                }
                else
                {
                    equippedWeapon.Attack(direction, random);
                }
            }                 
        }
    }
}