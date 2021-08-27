namespace finalgame
{
    partial class FIGHTSCREEN
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
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.OptionBox = new System.Windows.Forms.PictureBox();
            this.AttackBox = new System.Windows.Forms.PictureBox();
            this.DefendBox = new System.Windows.Forms.PictureBox();
            this.RunBox = new System.Windows.Forms.PictureBox();
            this.SelectIndicator = new System.Windows.Forms.PictureBox();
            this.CombatTimer = new System.Windows.Forms.Timer(this.components);
            this.playerhealthbar = new System.Windows.Forms.PictureBox();
            this.enemyhealthbar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefendBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerhealthbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyhealthbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.Image = global::finalgame.Properties.Resources.Enemy_Attack;
            this.Enemy.Location = new System.Drawing.Point(626, 107);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(100, 186);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy.TabIndex = 0;
            this.Enemy.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::finalgame.Properties.Resources.MC_ATTACK_1;
            this.Player.Location = new System.Drawing.Point(51, 78);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 186);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // OptionBox
            // 
            this.OptionBox.BackColor = System.Drawing.Color.Transparent;
            this.OptionBox.BackgroundImage = global::finalgame.Properties.Resources.Menu_Background;
            this.OptionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionBox.Location = new System.Drawing.Point(-6, 393);
            this.OptionBox.Name = "OptionBox";
            this.OptionBox.Size = new System.Drawing.Size(780, 45);
            this.OptionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OptionBox.TabIndex = 2;
            this.OptionBox.TabStop = false;
            // 
            // AttackBox
            // 
            this.AttackBox.Image = global::finalgame.Properties.Resources.Attack;
            this.AttackBox.Location = new System.Drawing.Point(42, 314);
            this.AttackBox.Name = "AttackBox";
            this.AttackBox.Size = new System.Drawing.Size(100, 50);
            this.AttackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttackBox.TabIndex = 3;
            this.AttackBox.TabStop = false;
            // 
            // DefendBox
            // 
            this.DefendBox.Image = global::finalgame.Properties.Resources.Dodge;
            this.DefendBox.Location = new System.Drawing.Point(281, 314);
            this.DefendBox.Name = "DefendBox";
            this.DefendBox.Size = new System.Drawing.Size(100, 50);
            this.DefendBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DefendBox.TabIndex = 4;
            this.DefendBox.TabStop = false;
            // 
            // RunBox
            // 
            this.RunBox.Image = global::finalgame.Properties.Resources.Flee;
            this.RunBox.Location = new System.Drawing.Point(490, 314);
            this.RunBox.Name = "RunBox";
            this.RunBox.Size = new System.Drawing.Size(100, 50);
            this.RunBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RunBox.TabIndex = 5;
            this.RunBox.TabStop = false;
            // 
            // SelectIndicator
            // 
            this.SelectIndicator.BackColor = System.Drawing.Color.Transparent;
            this.SelectIndicator.Image = global::finalgame.Properties.Resources.Select_Icon;
            this.SelectIndicator.Location = new System.Drawing.Point(42, 211);
            this.SelectIndicator.Name = "SelectIndicator";
            this.SelectIndicator.Size = new System.Drawing.Size(58, 53);
            this.SelectIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectIndicator.TabIndex = 6;
            this.SelectIndicator.TabStop = false;
            // 
            // CombatTimer
            // 
            this.CombatTimer.Interval = 10;
            this.CombatTimer.Tick += new System.EventHandler(this.CombatTimer_Tick);
            // 
            // playerhealthbar
            // 
            this.playerhealthbar.BackColor = System.Drawing.Color.Transparent;
            this.playerhealthbar.Image = global::finalgame.Properties.Resources.Life_Bar_1;
            this.playerhealthbar.Location = new System.Drawing.Point(10, 12);
            this.playerhealthbar.Name = "playerhealthbar";
            this.playerhealthbar.Size = new System.Drawing.Size(255, 48);
            this.playerhealthbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerhealthbar.TabIndex = 7;
            this.playerhealthbar.TabStop = false;
            // 
            // enemyhealthbar
            // 
            this.enemyhealthbar.Image = global::finalgame.Properties.Resources.Life_Bar_1;
            this.enemyhealthbar.Location = new System.Drawing.Point(626, 13);
            this.enemyhealthbar.Name = "enemyhealthbar";
            this.enemyhealthbar.Size = new System.Drawing.Size(255, 47);
            this.enemyhealthbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyhealthbar.TabIndex = 8;
            this.enemyhealthbar.TabStop = false;
            // 
            // FIGHTSCREEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalgame.Properties.Resources.BACKGROUND_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enemyhealthbar);
            this.Controls.Add(this.playerhealthbar);
            this.Controls.Add(this.SelectIndicator);
            this.Controls.Add(this.RunBox);
            this.Controls.Add(this.DefendBox);
            this.Controls.Add(this.AttackBox);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.OptionBox);
            this.DoubleBuffered = true;
            this.Name = "FIGHTSCREEN";
            this.Text = "FIGHTSCREEN";
            this.Activated += new System.EventHandler(this.FIGHTSCREEN_Activated);
            this.Load += new System.EventHandler(this.FIGHTSCREEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefendBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerhealthbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyhealthbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox OptionBox;
        private System.Windows.Forms.PictureBox AttackBox;
        private System.Windows.Forms.PictureBox DefendBox;
        private System.Windows.Forms.PictureBox RunBox;
        private System.Windows.Forms.PictureBox SelectIndicator;
        private System.Windows.Forms.Timer CombatTimer;
        private System.Windows.Forms.PictureBox playerhealthbar;
        private System.Windows.Forms.PictureBox enemyhealthbar;
    }
}