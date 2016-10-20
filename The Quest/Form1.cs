using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(90, 50, 620, 265));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            // more code to go here...
          

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.Dead)
                        batHitPoints.Text = "Dead";
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.Dead)
                        batHitPoints.Text = "Dead";
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.Dead)
                        batHitPoints.Text = "Dead";
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            // etc...
            player.Visible = true; 
            bat.Visible = showBat;
            ghost.Visible = showGhost;
            ghoul.Visible = showGhoul;

            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            bluePotion.Visible = false;
            redPotion.Visible = false;    
                    
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    if (game.WeaponInRoom.PickedUp)
                        swordInv.Visible = true;
                    break;
                case "Bow":
                    weaponControl = bow;
                    if (game.WeaponInRoom.PickedUp)
                        bowInv.Visible = true;
                    break;
                case "Mace":
                    weaponControl = mace;
                    if (game.WeaponInRoom.PickedUp)
                        maceInv.Visible = true;
                    break;
                case "Red Potion":
                    weaponControl = redPotion;
                    if (game.CheckPlayerInventory("Red Potion"))
                        redPotionInv.Visible = true;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotion;
                    if (game.CheckPlayerInventory("Blue Potion"))
                        bluePotionInv.Visible = true;
                    break;
            }  
            weaponControl.Location = game.WeaponInRoom.Location;

            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
                
            else
                weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");

                if (game.NewLevel(random))
                {
                    MessageBox.Show("Congratulations! You have completed the game.");
                    Application.Exit();
                }
                else
                {
                    UpdateCharacters();
                }
                    
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void down_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void left_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void right_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void upAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void downAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void leftAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void rightAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void swordInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                swordInv.BorderStyle = BorderStyle.FixedSingle;
                bowInv.BorderStyle = BorderStyle.None;
                maceInv.BorderStyle = BorderStyle.None;
                bluePotionInv.BorderStyle = BorderStyle.None;
                redPotionInv.BorderStyle = BorderStyle.None;
            }
        }

        private void bowInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                swordInv.BorderStyle = BorderStyle.None;
                bowInv.BorderStyle = BorderStyle.FixedSingle;
                maceInv.BorderStyle = BorderStyle.None;
                bluePotionInv.BorderStyle = BorderStyle.None;
                redPotionInv.BorderStyle = BorderStyle.None;
            }
        }

        private void maceInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                swordInv.BorderStyle = BorderStyle.None;
                bowInv.BorderStyle = BorderStyle.None;
                maceInv.BorderStyle = BorderStyle.FixedSingle;
                bluePotionInv.BorderStyle = BorderStyle.None;
                redPotionInv.BorderStyle = BorderStyle.None;
            }
        }

        private void bluePotionInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                DialogResult result = MessageBox.Show("Do you want to drink this Blue Potion?",
                    "Drink Potion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    game.Equip("Blue Potion");
                    game.Attack(Direction.Up, random);               
                    UpdateCharacters();
                }
            }
        }

        private void redPotionInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                swordInv.BorderStyle = BorderStyle.None;
                bowInv.BorderStyle = BorderStyle.None;
                maceInv.BorderStyle = BorderStyle.None;
                bluePotionInv.BorderStyle = BorderStyle.None;
                redPotionInv.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}