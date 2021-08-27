namespace finalgame
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
            this.components = new System.ComponentModel.Container();
            this.ENEMYBOX = new System.Windows.Forms.PictureBox();
            this.rigdoor = new System.Windows.Forms.PictureBox();
            this.lefdoor = new System.Windows.Forms.PictureBox();
            this.downdoor = new System.Windows.Forms.PictureBox();
            this.updoor = new System.Windows.Forms.PictureBox();
            this.dummy = new System.Windows.Forms.PictureBox();
            this.worldTimer = new System.Windows.Forms.Timer(this.components);
            this.HealthBar = new System.Windows.Forms.PictureBox();
            this.lootNote = new System.Windows.Forms.PictureBox();
            this.lootyDooty = new System.Windows.Forms.PictureBox();
            this.potionBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.obstacles00 = new System.Windows.Forms.PictureBox();
            this.ShowOFF = new System.Windows.Forms.PictureBox();
            this.obstacles01 = new System.Windows.Forms.PictureBox();
            this.obstacles02 = new System.Windows.Forms.PictureBox();
            this.obstacles03 = new System.Windows.Forms.PictureBox();
            this.treasureChest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ENEMYBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dummy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootyDooty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasureChest)).BeginInit();
            this.SuspendLayout();
            // 
            // ENEMYBOX
            // 
            this.ENEMYBOX.BackColor = System.Drawing.Color.Transparent;
            this.ENEMYBOX.Image = global::finalgame.Properties.Resources.Enemy_Battle_Idel_1;
            this.ENEMYBOX.Location = new System.Drawing.Point(534, 77);
            this.ENEMYBOX.Name = "ENEMYBOX";
            this.ENEMYBOX.Size = new System.Drawing.Size(72, 116);
            this.ENEMYBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ENEMYBOX.TabIndex = 5;
            this.ENEMYBOX.TabStop = false;
            // 
            // rigdoor
            // 
            this.rigdoor.BackColor = System.Drawing.Color.White;
            this.rigdoor.Location = new System.Drawing.Point(645, 160);
            this.rigdoor.Name = "rigdoor";
            this.rigdoor.Size = new System.Drawing.Size(145, 90);
            this.rigdoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rigdoor.TabIndex = 4;
            this.rigdoor.TabStop = false;
            // 
            // lefdoor
            // 
            this.lefdoor.BackColor = System.Drawing.Color.White;
            this.lefdoor.Location = new System.Drawing.Point(4, 138);
            this.lefdoor.Name = "lefdoor";
            this.lefdoor.Size = new System.Drawing.Size(145, 90);
            this.lefdoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lefdoor.TabIndex = 3;
            this.lefdoor.TabStop = false;
            // 
            // downdoor
            // 
            this.downdoor.BackColor = System.Drawing.Color.White;
            this.downdoor.Location = new System.Drawing.Point(335, 380);
            this.downdoor.Name = "downdoor";
            this.downdoor.Size = new System.Drawing.Size(200, 90);
            this.downdoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downdoor.TabIndex = 2;
            this.downdoor.TabStop = false;
            // 
            // updoor
            // 
            this.updoor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updoor.Location = new System.Drawing.Point(337, 12);
            this.updoor.Name = "updoor";
            this.updoor.Size = new System.Drawing.Size(200, 67);
            this.updoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updoor.TabIndex = 1;
            this.updoor.TabStop = false;
            // 
            // dummy
            // 
            this.dummy.BackColor = System.Drawing.Color.Transparent;
            this.dummy.Image = global::finalgame.Properties.Resources.MC_IDLE_2;
            this.dummy.Location = new System.Drawing.Point(431, 77);
            this.dummy.Name = "dummy";
            this.dummy.Size = new System.Drawing.Size(86, 115);
            this.dummy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dummy.TabIndex = 0;
            this.dummy.TabStop = false;
            // 
            // worldTimer
            // 
            this.worldTimer.Enabled = true;
            this.worldTimer.Interval = 5;
            this.worldTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HealthBar
            // 
            this.HealthBar.BackColor = System.Drawing.Color.Transparent;
            this.HealthBar.Image = global::finalgame.Properties.Resources.Life_Bar_1;
            this.HealthBar.Location = new System.Drawing.Point(4, 8);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(247, 50);
            this.HealthBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HealthBar.TabIndex = 6;
            this.HealthBar.TabStop = false;
            // 
            // lootNote
            // 
            this.lootNote.BackColor = System.Drawing.Color.Transparent;
            this.lootNote.Image = global::finalgame.Properties.Resources.Loot_Box;
            this.lootNote.Location = new System.Drawing.Point(516, -3);
            this.lootNote.Name = "lootNote";
            this.lootNote.Size = new System.Drawing.Size(286, 50);
            this.lootNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lootNote.TabIndex = 7;
            this.lootNote.TabStop = false;
            // 
            // lootyDooty
            // 
            this.lootyDooty.BackColor = System.Drawing.Color.Transparent;
            this.lootyDooty.Image = global::finalgame.Properties.Resources.Green_Gem;
            this.lootyDooty.Location = new System.Drawing.Point(534, 299);
            this.lootyDooty.Name = "lootyDooty";
            this.lootyDooty.Size = new System.Drawing.Size(22, 35);
            this.lootyDooty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lootyDooty.TabIndex = 8;
            this.lootyDooty.TabStop = false;
            // 
            // potionBox
            // 
            this.potionBox.BackColor = System.Drawing.Color.Transparent;
            this.potionBox.Image = global::finalgame.Properties.Resources.Potion;
            this.potionBox.Location = new System.Drawing.Point(335, 77);
            this.potionBox.Name = "potionBox";
            this.potionBox.Size = new System.Drawing.Size(33, 39);
            this.potionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potionBox.TabIndex = 9;
            this.potionBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = global::finalgame.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(747, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.Image = global::finalgame.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(713, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox3.Image = global::finalgame.Properties.Resources._0;
            this.pictureBox3.Location = new System.Drawing.Point(679, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox4.Image = global::finalgame.Properties.Resources._0;
            this.pictureBox4.Location = new System.Drawing.Point(645, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // obstacles00
            // 
            this.obstacles00.BackColor = System.Drawing.Color.Transparent;
            this.obstacles00.Image = global::finalgame.Properties.Resources.Barrel;
            this.obstacles00.Location = new System.Drawing.Point(204, 89);
            this.obstacles00.Margin = new System.Windows.Forms.Padding(0);
            this.obstacles00.Name = "obstacles00";
            this.obstacles00.Size = new System.Drawing.Size(89, 91);
            this.obstacles00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacles00.TabIndex = 14;
            this.obstacles00.TabStop = false;
            // 
            // ShowOFF
            // 
            this.ShowOFF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ShowOFF.Image = global::finalgame.Properties.Resources.Gold_Coins;
            this.ShowOFF.Location = new System.Drawing.Point(573, 8);
            this.ShowOFF.Name = "ShowOFF";
            this.ShowOFF.Size = new System.Drawing.Size(54, 28);
            this.ShowOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowOFF.TabIndex = 15;
            this.ShowOFF.TabStop = false;
            // 
            // obstacles01
            // 
            this.obstacles01.BackColor = System.Drawing.Color.Transparent;
            this.obstacles01.Image = global::finalgame.Properties.Resources.Barrel;
            this.obstacles01.Location = new System.Drawing.Point(311, 130);
            this.obstacles01.Name = "obstacles01";
            this.obstacles01.Size = new System.Drawing.Size(89, 98);
            this.obstacles01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacles01.TabIndex = 16;
            this.obstacles01.TabStop = false;
            // 
            // obstacles02
            // 
            this.obstacles02.BackColor = System.Drawing.Color.Transparent;
            this.obstacles02.Image = global::finalgame.Properties.Resources.Barrel;
            this.obstacles02.Location = new System.Drawing.Point(356, 176);
            this.obstacles02.Name = "obstacles02";
            this.obstacles02.Size = new System.Drawing.Size(89, 98);
            this.obstacles02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacles02.TabIndex = 17;
            this.obstacles02.TabStop = false;
            // 
            // obstacles03
            // 
            this.obstacles03.BackColor = System.Drawing.Color.Transparent;
            this.obstacles03.Image = global::finalgame.Properties.Resources.Barrel;
            this.obstacles03.Location = new System.Drawing.Point(364, 184);
            this.obstacles03.Name = "obstacles03";
            this.obstacles03.Size = new System.Drawing.Size(89, 98);
            this.obstacles03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacles03.TabIndex = 18;
            this.obstacles03.TabStop = false;
            // 
            // treasureChest
            // 
            this.treasureChest.BackColor = System.Drawing.Color.Transparent;
            this.treasureChest.Image = global::finalgame.Properties.Resources.Chest_Close;
            this.treasureChest.Location = new System.Drawing.Point(134, 284);
            this.treasureChest.Name = "treasureChest";
            this.treasureChest.Size = new System.Drawing.Size(100, 61);
            this.treasureChest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treasureChest.TabIndex = 19;
            this.treasureChest.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalgame.Properties.Resources.BACKGROUND_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treasureChest);
            this.Controls.Add(this.obstacles03);
            this.Controls.Add(this.obstacles02);
            this.Controls.Add(this.obstacles01);
            this.Controls.Add(this.ShowOFF);
            this.Controls.Add(this.obstacles00);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.potionBox);
            this.Controls.Add(this.lootyDooty);
            this.Controls.Add(this.lootNote);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.rigdoor);
            this.Controls.Add(this.lefdoor);
            this.Controls.Add(this.downdoor);
            this.Controls.Add(this.updoor);
            this.Controls.Add(this.dummy);
            this.Controls.Add(this.ENEMYBOX);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Got\'eem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ENEMYBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dummy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootyDooty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacles03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasureChest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dummy;
        private System.Windows.Forms.PictureBox updoor;
        private System.Windows.Forms.PictureBox downdoor;
        private System.Windows.Forms.PictureBox lefdoor;
        private System.Windows.Forms.PictureBox rigdoor;
        private System.Windows.Forms.PictureBox ENEMYBOX;
        private System.Windows.Forms.Timer worldTimer;
        private System.Windows.Forms.PictureBox HealthBar;
        private System.Windows.Forms.PictureBox lootNote;
        private System.Windows.Forms.PictureBox lootyDooty;
        private System.Windows.Forms.PictureBox potionBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox obstacles00;
        private System.Windows.Forms.PictureBox ShowOFF;
        private System.Windows.Forms.PictureBox obstacles01;
        private System.Windows.Forms.PictureBox obstacles02;
        private System.Windows.Forms.PictureBox obstacles03;
        private System.Windows.Forms.PictureBox treasureChest;
    }
}

