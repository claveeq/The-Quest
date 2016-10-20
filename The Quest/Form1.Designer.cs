namespace The_Quest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.bluePotionInv = new System.Windows.Forms.PictureBox();
            this.redPotionInv = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.maceInv = new System.Windows.Forms.PictureBox();
            this.bowInv = new System.Windows.Forms.PictureBox();
            this.swordInv = new System.Windows.Forms.PictureBox();
            this.MoveBox = new System.Windows.Forms.GroupBox();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.AttackBox = new System.Windows.Forms.GroupBox();
            this.rightAttack = new System.Windows.Forms.Button();
            this.leftAttack = new System.Windows.Forms.Button();
            this.downAttack = new System.Windows.Forms.Button();
            this.upAttack = new System.Windows.Forms.Button();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInv)).BeginInit();
            this.MoveBox.SuspendLayout();
            this.AttackBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::The_Quest.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(110, 80);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = global::The_Quest.Properties.Resources.bat;
            this.bat.Location = new System.Drawing.Point(167, 80);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(50, 50);
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = global::The_Quest.Properties.Resources.ghost;
            this.ghost.Location = new System.Drawing.Point(224, 80);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(50, 50);
            this.ghost.TabIndex = 2;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = global::The_Quest.Properties.Resources.ghoul;
            this.ghoul.Location = new System.Drawing.Point(281, 80);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(50, 50);
            this.ghoul.TabIndex = 3;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // bluePotionInv
            // 
            this.bluePotionInv.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bluePotionInv.Image = global::The_Quest.Properties.Resources.potion_blue;
            this.bluePotionInv.Location = new System.Drawing.Point(323, 437);
            this.bluePotionInv.Name = "bluePotionInv";
            this.bluePotionInv.Size = new System.Drawing.Size(60, 60);
            this.bluePotionInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotionInv.TabIndex = 4;
            this.bluePotionInv.TabStop = false;
            this.bluePotionInv.Visible = false;
            this.bluePotionInv.Click += new System.EventHandler(this.bluePotionInv_Click);
            // 
            // redPotionInv
            // 
            this.redPotionInv.BackColor = System.Drawing.Color.Transparent;
            this.redPotionInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.redPotionInv.Image = global::The_Quest.Properties.Resources.potion_red;
            this.redPotionInv.Location = new System.Drawing.Point(394, 437);
            this.redPotionInv.Name = "redPotionInv";
            this.redPotionInv.Size = new System.Drawing.Size(60, 60);
            this.redPotionInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotionInv.TabIndex = 5;
            this.redPotionInv.TabStop = false;
            this.redPotionInv.Visible = false;
            this.redPotionInv.Click += new System.EventHandler(this.redPotionInv_Click);
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = global::The_Quest.Properties.Resources.sword;
            this.sword.Location = new System.Drawing.Point(452, 80);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(50, 50);
            this.sword.TabIndex = 6;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = global::The_Quest.Properties.Resources.bow;
            this.bow.Location = new System.Drawing.Point(509, 80);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(50, 50);
            this.bow.TabIndex = 7;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = global::The_Quest.Properties.Resources.mace;
            this.mace.Location = new System.Drawing.Point(566, 80);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(50, 50);
            this.mace.TabIndex = 8;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // maceInv
            // 
            this.maceInv.BackColor = System.Drawing.Color.Transparent;
            this.maceInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maceInv.Image = global::The_Quest.Properties.Resources.mace;
            this.maceInv.Location = new System.Drawing.Point(252, 437);
            this.maceInv.Name = "maceInv";
            this.maceInv.Size = new System.Drawing.Size(60, 60);
            this.maceInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maceInv.TabIndex = 11;
            this.maceInv.TabStop = false;
            this.maceInv.Visible = false;
            this.maceInv.Click += new System.EventHandler(this.maceInv_Click);
            // 
            // bowInv
            // 
            this.bowInv.BackColor = System.Drawing.Color.Transparent;
            this.bowInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bowInv.Image = global::The_Quest.Properties.Resources.bow;
            this.bowInv.Location = new System.Drawing.Point(181, 437);
            this.bowInv.Name = "bowInv";
            this.bowInv.Size = new System.Drawing.Size(60, 60);
            this.bowInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowInv.TabIndex = 10;
            this.bowInv.TabStop = false;
            this.bowInv.Visible = false;
            this.bowInv.Click += new System.EventHandler(this.bowInv_Click);
            // 
            // swordInv
            // 
            this.swordInv.BackColor = System.Drawing.Color.Transparent;
            this.swordInv.Image = global::The_Quest.Properties.Resources.sword;
            this.swordInv.Location = new System.Drawing.Point(110, 437);
            this.swordInv.Name = "swordInv";
            this.swordInv.Size = new System.Drawing.Size(60, 60);
            this.swordInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordInv.TabIndex = 9;
            this.swordInv.TabStop = false;
            this.swordInv.Visible = false;
            this.swordInv.Click += new System.EventHandler(this.swordInv_Click);
            // 
            // MoveBox
            // 
            this.MoveBox.BackColor = System.Drawing.Color.Transparent;
            this.MoveBox.Controls.Add(this.right);
            this.MoveBox.Controls.Add(this.left);
            this.MoveBox.Controls.Add(this.down);
            this.MoveBox.Controls.Add(this.up);
            this.MoveBox.Location = new System.Drawing.Point(461, 422);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(137, 93);
            this.MoveBox.TabIndex = 12;
            this.MoveBox.TabStop = false;
            this.MoveBox.Text = "Move";
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.ForeColor = System.Drawing.Color.White;
            this.right.Location = new System.Drawing.Point(91, 30);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 36);
            this.right.TabIndex = 3;
            this.right.Text = "→";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.ForeColor = System.Drawing.Color.White;
            this.left.Location = new System.Drawing.Point(6, 30);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 36);
            this.left.TabIndex = 2;
            this.left.Text = "←";
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.ForeColor = System.Drawing.Color.White;
            this.down.Location = new System.Drawing.Point(47, 52);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(43, 31);
            this.down.TabIndex = 1;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.ForeColor = System.Drawing.Color.White;
            this.up.Location = new System.Drawing.Point(47, 15);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(43, 31);
            this.up.TabIndex = 0;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // AttackBox
            // 
            this.AttackBox.BackColor = System.Drawing.Color.Transparent;
            this.AttackBox.Controls.Add(this.rightAttack);
            this.AttackBox.Controls.Add(this.leftAttack);
            this.AttackBox.Controls.Add(this.downAttack);
            this.AttackBox.Controls.Add(this.upAttack);
            this.AttackBox.Location = new System.Drawing.Point(604, 422);
            this.AttackBox.Name = "AttackBox";
            this.AttackBox.Size = new System.Drawing.Size(137, 93);
            this.AttackBox.TabIndex = 13;
            this.AttackBox.TabStop = false;
            this.AttackBox.Text = "Attack";
            // 
            // rightAttack
            // 
            this.rightAttack.BackColor = System.Drawing.Color.Firebrick;
            this.rightAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAttack.ForeColor = System.Drawing.Color.White;
            this.rightAttack.Location = new System.Drawing.Point(91, 28);
            this.rightAttack.Name = "rightAttack";
            this.rightAttack.Size = new System.Drawing.Size(40, 36);
            this.rightAttack.TabIndex = 7;
            this.rightAttack.Text = "→";
            this.rightAttack.UseVisualStyleBackColor = false;
            this.rightAttack.Click += new System.EventHandler(this.rightAttack_Click);
            // 
            // leftAttack
            // 
            this.leftAttack.BackColor = System.Drawing.Color.Firebrick;
            this.leftAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftAttack.ForeColor = System.Drawing.Color.White;
            this.leftAttack.Location = new System.Drawing.Point(6, 28);
            this.leftAttack.Name = "leftAttack";
            this.leftAttack.Size = new System.Drawing.Size(40, 36);
            this.leftAttack.TabIndex = 6;
            this.leftAttack.Text = "←";
            this.leftAttack.UseVisualStyleBackColor = false;
            this.leftAttack.Click += new System.EventHandler(this.leftAttack_Click);
            // 
            // downAttack
            // 
            this.downAttack.BackColor = System.Drawing.Color.Firebrick;
            this.downAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downAttack.ForeColor = System.Drawing.Color.White;
            this.downAttack.Location = new System.Drawing.Point(47, 50);
            this.downAttack.Name = "downAttack";
            this.downAttack.Size = new System.Drawing.Size(43, 31);
            this.downAttack.TabIndex = 5;
            this.downAttack.Text = "↓";
            this.downAttack.UseVisualStyleBackColor = false;
            this.downAttack.Click += new System.EventHandler(this.downAttack_Click);
            // 
            // upAttack
            // 
            this.upAttack.BackColor = System.Drawing.Color.Firebrick;
            this.upAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upAttack.ForeColor = System.Drawing.Color.White;
            this.upAttack.Location = new System.Drawing.Point(47, 13);
            this.upAttack.Name = "upAttack";
            this.upAttack.Size = new System.Drawing.Size(43, 31);
            this.upAttack.TabIndex = 4;
            this.upAttack.Text = "↑";
            this.upAttack.UseVisualStyleBackColor = false;
            this.upAttack.Click += new System.EventHandler(this.upAttack_Click);
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = global::The_Quest.Properties.Resources.potion_red;
            this.redPotion.Location = new System.Drawing.Point(395, 80);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(50, 50);
            this.redPotion.TabIndex = 15;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = global::The_Quest.Properties.Resources.potion_blue;
            this.bluePotion.Location = new System.Drawing.Point(338, 80);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(50, 50);
            this.bluePotion.TabIndex = 14;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(508, 336);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 69);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(58, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 1;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bat";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(58, 17);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 13);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghost";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(58, 34);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghoul";
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(58, 51);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Quest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 544);
            this.Controls.Add(this.player);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.AttackBox);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.maceInv);
            this.Controls.Add(this.bowInv);
            this.Controls.Add(this.swordInv);
            this.Controls.Add(this.redPotionInv);
            this.Controls.Add(this.bluePotionInv);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.sword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInv)).EndInit();
            this.MoveBox.ResumeLayout(false);
            this.AttackBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox bluePotionInv;
        private System.Windows.Forms.PictureBox redPotionInv;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox maceInv;
        private System.Windows.Forms.PictureBox bowInv;
        private System.Windows.Forms.PictureBox swordInv;
        private System.Windows.Forms.GroupBox MoveBox;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.GroupBox AttackBox;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Button rightAttack;
        private System.Windows.Forms.Button leftAttack;
        private System.Windows.Forms.Button downAttack;
        private System.Windows.Forms.Button upAttack;
    }
}

