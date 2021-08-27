using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalgame
{
    public partial class FIGHTSCREEN : Form
    {
        //what we want
        //the player starts
        //the turn changes from enemy to player
        int ploc = 0;
        int eloc = 0;

        int hitOnEn = 0;
        int hitOnPl = 0;

        Image[] fightIdleP = new Image[2];
        Image[] fightIdleE = new Image[2];

        Random rand = new Random(1);
        int random = 0;
        int random2 = 0;

        int indexSelec = 0;
        bool gethim = false;
        Player player = new Player();
        Form1 form1 = new Form1();
        Enemy enemy = new Enemy();
        bool myturn = true;
        public FIGHTSCREEN()
        {
            InitializeComponent();

            KeyDown += new KeyEventHandler(KeyPressed);

            fightIdleP[0] = Properties.Resources.MC_IDLE_WEAPON_1;
            fightIdleP[1] = Properties.Resources.MC_IDLE_WEAPON_2;

            fightIdleE[0] = Properties.Resources.Enemy_Battle_Idel_1;
            fightIdleE[1] = Properties.Resources.Enemy_Battle_Idel_2;
        }

        void KeyPressed(object obj, KeyEventArgs key)
        {
            if(myturn==true)
            {
                if (key.KeyCode == Keys.A)
                {
                    if (indexSelec > 0)
                    {
                        indexSelec--;
                        setThatSinner(indexSelec);
                    }
                }

                if (key.KeyCode == Keys.D)
                {
                    if (indexSelec < 3)
                    {
                        indexSelec++;
                        setThatSinner(indexSelec);
                    }
                }

                if (key.KeyCode == Keys.Enter)
                {
                    random2 = rand.Next(1, 100);
                    if (indexSelec == 0)
                    {
                        if(random2/100<=enemy.getDodge())
                        {
                            myturn = false;
                        }

                        if(enemy.getDodge()>=1)
                        {
                            myturn = false;
                        }

                        else
                        {
                            hitOnEn++;
                            enemy.HealthLoss(enemy.getHealth(), player.getAttack());
                            enemyhealthbar.Image = enemy.getHealthBar(hitOnEn);
                            myturn = false;
                        }
                    }

                    if (indexSelec == 1)
                    {
                        player.doTheDodge();
                        myturn = false;
                    }

                    if (indexSelec == 2)
                    {
                        gethim = true;
                        form1.HELP = 1;
                        this.Close();
                    }
                }
            }

            if(key.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        public Image animateFights(Image[] images, int x)
        {
            if (x + 1 < images.Length)
            {
                x++;
                return images.ElementAt(x);
            }
            else
            {
                x = 0;
                return images.ElementAt(x);
            }

        }

        private void FIGHTSCREEN_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OptionBox.Height = this.Height / 3;
            OptionBox.Width = this.Width;
            OptionBox.Top = this.Height - (this.Height / 3);

            AttackBox.Top = OptionBox.Top + (OptionBox.Height / 3);
            AttackBox.Left = 100;
            AttackBox.Width = this.Width / 4;

            DefendBox.Top = AttackBox.Top;
            DefendBox.Width = this.Width / 4;
            DefendBox.Left = AttackBox.Right + 100;

            RunBox.Top = AttackBox.Top;
            RunBox.Width = this.Width / 4;
            RunBox.Left = DefendBox.Right + 100;

            setThatSinner(indexSelec);
        }

        public void setThatSinner(int toHere)
        {
            SelectIndicator.Top = OptionBox.Top + (OptionBox.Height / 2);
            if(toHere==0)
            {
                SelectIndicator.Left = AttackBox.Left - (SelectIndicator.Width + 10);
            }
            if(toHere==1)
            {
                SelectIndicator.Left = DefendBox.Left - (SelectIndicator.Width + 10);
            }
            if(toHere==2)
            {
                SelectIndicator.Left = RunBox.Left - (SelectIndicator.Width + 10);
            }
        }

        public bool getHunt()
        {
            return gethim;
        }

        int wait = 0;

        private void CombatTimer_Tick(object sender, EventArgs e)
        {
            //wait++;
            random = rand.Next(0,2);
            random2 = rand.Next(30, 100);
            //if (wait <= 1000)
            //{
            //    myturn = false;
            //}

            double temp = random2 / 100;

            if(myturn==false)
            {
                CombatTimer.Stop();
                //MessageBox.Show("ENEMY TURN "+random);
                if(random==0)
                {
                    if(player.getDodge()>=1)
                    {
                        myturn = true;
                        //MessageBox.Show("ULTIMATE DODGE");
                    }
                    
                    if(random2%100<=player.getDodge())
                    {
                        //.Show(player.getDodge() + " Pdodge " + random2 % 100);
                        myturn = true;
                    }

                    else
                    {
                        hitOnPl++;
                        player.HealthLoss(player.getHealth(), enemy.getATT());
                        MessageBox.Show("HIT PLAYER");
                        playerhealthbar.Image = player.getHealthBar(hitOnPl);
                        myturn = true;
                    }
                }
                if(random==1)
                {
                    enemy.doTheDodge();

                    myturn = true;
                }
                CombatTimer.Start();
            }

            
            Player.Image = animateFights(fightIdleP, ploc);

            Enemy.Image = animateFights(fightIdleE, eloc);
        }

        private void FIGHTSCREEN_Activated(object sender, EventArgs e)
        {
            CombatTimer.Start();
        }
    }


}
