using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace finalgame
{ 
    public partial class Form1 : Form
    {
        public int HELP = 0;
        bool firstEncounter=true;
        bool Troom = false;
        bool Eroom = false;
        bool eXIT = false;
        bool gold = false;
        bool toTheLeft = false;
        bool toTheRight = false;
        bool below = true;
        bool above = false;
        public bool hunt = false;
        bool keydelay = false;

        int newRoomDelay = 0;
        int hitCount = 0;
        int lootCount = 0;
        int prow, pcol;

        Image[] lootCounterChange = new Image[10];

        //todo ATTACK, DODGE -- DONE
        //todo MAKE SURE THE SCREENS LOAD THEIR THING, AKA 6-FINISH
        //todo FINISH ROOM

        //LEFT-RIGHT COLS
        //UP-DOWN ROWS

        Player p1 = new Player();
        Enemy en1 = new Enemy();
        MapMaker mm = new MapMaker();
        Image[,] bgs = new Image[3,3];
        Image[] stuff = new Image[3];
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        
        public Form1()
        {
            lootCounterChange[0] = Properties.Resources._0;
            lootCounterChange[1] = Properties.Resources._1;
            lootCounterChange[2] = Properties.Resources._2;
            lootCounterChange[3] = Properties.Resources._3;
            lootCounterChange[4] = Properties.Resources._4;
            lootCounterChange[5] = Properties.Resources._5;
            lootCounterChange[6] = Properties.Resources._6;
            lootCounterChange[7] = Properties.Resources._7;
            lootCounterChange[8] = Properties.Resources._8;
            lootCounterChange[9] = Properties.Resources._9;

            this.WindowState = FormWindowState.Maximized;
            play.SoundLocation = "C:\\Users\\conti\\Desktop\\Old_Finals\\final-2019-s-alpha\\finalgame\\01 Cave Story.wav";
            
            //todo start sound
            play.Play();
            pcol = 0; prow = 0;

            InitializeComponent();
            KeyDown += new KeyEventHandler(KeyPressed);

            mm.generateMap();
        }

        void KeyPressed(object sen, KeyEventArgs keys)
        {
            if (keydelay)
            {
                if (keys.KeyCode == Keys.W)
                {
                    dummy.Top -= 7;
                    p1.nm.Image=p1.animate(p1.sprites4animationU);
 
                    if(updoor.Visible)
                    {
                        if (dummy.Bounds.IntersectsWith(updoor.Bounds))
                        {
                            if (pcol > 0)
                            {
                                pcol--;
                                p1.setCol(pcol);
                                dummy.Top += 600;
                                bgChanger(pcol, prow);
                                newRoomDelay = 250;
                                en1.nm.Top = this.Height + 300; en1.nm.Left = updoor.Left;
                            }
                            else
                                dummy.Top += 7;
                        }
                    }
                }
                if (keys.KeyCode == Keys.A)
                {
                    dummy.Left -= 7;
                    p1.nm.Image=p1.animate(p1.sprites4animationL);

                    if(lefdoor.Visible)
                    {
                        if (dummy.Bounds.IntersectsWith(lefdoor.Bounds))
                        {
                            if (prow > 0)
                            {
                                prow--;
                                p1.setRow(prow);
                                dummy.Left += 1100;
                                bgChanger(pcol, prow);
                                newRoomDelay = 250;
                                en1.nm.Top = lefdoor.Top; en1.nm.Left = this.Width + 300;
                            }
                            else
                                dummy.Left += 7;
                        }
                    }
                }
                if (keys.KeyCode == Keys.S)
                {
                    p1.nm.Image=p1.animate(p1.sprites4animationD);

                    dummy.Top += 7;
                    if(downdoor.Visible)
                    {
                        if (dummy.Bounds.IntersectsWith(downdoor.Bounds))
                        {
                            if (pcol < 2)
                            {
                                pcol++;
                                p1.setCol(pcol);
                                dummy.Top -= 600;
                                bgChanger(pcol, prow);
                                newRoomDelay = 250;
                                en1.nm.Top = -300; en1.nm.Left = updoor.Left;
                            }
                            else
                                dummy.Top -= 7;
                        }
                    }
                }
                if (keys.KeyCode == Keys.D)
                {
                    dummy.Left += 7;

                    p1.nm.Image=p1.animate(p1.sprites4animationR);

                    if(rigdoor.Visible)
                    {
                        if (dummy.Bounds.IntersectsWith(rigdoor.Bounds))
                        {
                            if (prow < 2)
                            {
                                prow++;
                                p1.setRow(prow);
                                dummy.Left -= 1100;
                                newRoomDelay = 250;
                                bgChanger(pcol, prow);
                                en1.nm.Top = lefdoor.Top; en1.nm.Left = -300;
                            }
                            else
                                dummy.Left -= 7;
                        }
                    }
                }

                //todo delete after testing 
                if(keys.KeyCode==Keys.C)
                {
                    hunt = !hunt;
                }

                if(keys.KeyCode==Keys.Escape)
                {
                    this.Close();
                }

                //todo delete this after testing
                if(keys.KeyCode==Keys.F)
                {
                    worldTimer.Stop();
                    FIGHTSCREEN fightNight = new FIGHTSCREEN();
                    fightNight.ShowDialog();
                    hunt = fightNight.getHunt();
                    p1.nm.Top = (this.Height / 2) + 100;
                    p1.nm.Left = this.Width / 2;
                    worldTimer.Start();
                }

                if (keys.KeyCode == Keys.M)
                {
                    MAPWINDOW map = new MAPWINDOW();

                    map.playerBlock(p1.getCol(), p1.getRow());

                    map.fillSquares(mm.readm());

                    map.ShowDialog();
                }
                boundcheck();

                if(en1.nm.Top==this.Height|| en1.nm.Bottom == 0)
                {
                    en1.nm.Left = updoor.Left;
                }
                if(en1.nm.Left==this.Width|| en1.nm.Right == 0)
                {
                    en1.nm.Top = lefdoor.Top;
                }

                keydelay = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doors();

           

            dummy.Top = (this.Height / 2) + 100;
            dummy.Left = this.Width / 2;

            ENEMYBOX.Left = (this.Width / 2) - (ENEMYBOX.Width / 2);
            ENEMYBOX.Top = 100;

            p1.nm = dummy;
            en1.nm = ENEMYBOX;

            rigdoor.Top = (this.Height / 2) - 75;
            lefdoor.Top = (this.Height / 2) - 75;
            rigdoor.Left = this.Width - rigdoor.Width - 10;

            updoor.Left = this.Width / 2 - (updoor.Width / 2) - 10;
            downdoor.Left = this.Width / 2 - (updoor.Width / 2) - 10;
            downdoor.Top = this.Height - downdoor.Height - 25;

            bgs[0, 0] = Properties.Resources.BACKGROUND_2;
            bgs[0, 1] = Properties.Resources.BACKGROUND_2;
            bgs[0, 2] = Properties.Resources.BACKGROUND_3;

            bgs[1, 0] = Properties.Resources.BACKGROUND_3;
            bgs[1, 1] = Properties.Resources.BACKGROUND_3;
            bgs[1, 2] = Properties.Resources.BACKGROUND_2;

            bgs[2, 0] = Properties.Resources.BACKGROUND_3;
            bgs[2, 1] = Properties.Resources.BACKGROUND_2;
            bgs[2, 2] = Properties.Resources.BACKGROUND_1;

            bgChanger(0, 0);

            p1.sprites4animationIDLED[0] = (Properties.Resources.MC_IDLE_1);
            p1.sprites4animationIDLED[1] = Properties.Resources.MC_IDLE_2;

            lootNote.Top = 0;
            lootNote.Left = this.Width - lootNote.Width;

            pictureBox1.Left = lootNote.Right - (25 + pictureBox1.Width);
            pictureBox2.Left = pictureBox1.Right - (25 + pictureBox1.Width);
            pictureBox3.Left = pictureBox2.Right - (25 + pictureBox1.Width);
            pictureBox4.Left = pictureBox3.Right - (25 + pictureBox1.Width);
            ShowOFF.Top = pictureBox1.Top;
            ShowOFF.Left = pictureBox4.Left - 50;

            worldTimer.Start();
        }

        public void boundcheck()
        {
            if (p1.nm.Bounds.IntersectsWith(en1.nm.Bounds))
            {
                if (!firstEncounter)
                {
                    p1.HealthLoss(p1.GetHealth(), en1.getATT());
                    p1.BeenHit();

                    hitCount++;
                    
                    if(hitCount<=14)
                    {
                        HealthBar.Image = p1.getHealthBar(hitCount);
                    }
                    
                    if (p1.GetHealth() <= 0)
                    {
                        p1.nm.Image = Properties.Resources.MC_DEATH_1;
                        en1.nm.Image = Properties.Resources.Enemy_Victory_Pose;
                        Thread.Sleep(100);
                        p1.nm.Image = Properties.Resources.MC_DEATH_2;
                        Thread.Sleep(100);
                        p1.nm.Image = Properties.Resources.MC_DEATH_3;
                        Thread.Sleep(100);
                        p1.nm.Image = Properties.Resources.MC_DEATH_4;
                        Thread.Sleep(100);
                        p1.nm.Image = Properties.Resources.MC_DEATH_5;
                        Thread.Sleep(100); 
                    }

                    if (below)
                    {
                        p1.nm.Top += 20;
                    }
                    else if (toTheRight)
                    {
                        p1.nm.Left += 20;
                        en1.nm.Image = en1.animate(en1.sprites4animationR);
                    }
                    else if (above)
                    {
                        p1.nm.Top -= 20;
                        en1.nm.Image = en1.animate(en1.sprites4animationU);
                    }
                    else if (toTheLeft)
                    {
                        p1.nm.Left -= 20;
                        en1.nm.Image = en1.animate(en1.sprites4animationL);
                    }
                }
                else if(firstEncounter)
                {
                    worldTimer.Stop();
                    FIGHTSCREEN fightNight = new FIGHTSCREEN();
                    fightNight.ShowDialog();
                    hunt = fightNight.getHunt();
                    p1.nm.Top = (this.Height / 2) + 100;
                    p1.nm.Left = this.Width / 2;
                    worldTimer.Start();
                    firstEncounter = false;
                }
            }

            if(p1.nm.Bounds.IntersectsWith(potionBox.Bounds))
            {
                potionBox.Visible = false;
                potionBox.Top = -100;
                HealthBar.Image = Properties.Resources.Life_Bar_1;
                p1.setHealth(100);
                p1.getHealthBar(0);
                hitCount = 0;
            }

            if(p1.nm.Bounds.IntersectsWith(obstacles00.Bounds))
            {
                whichDirection(obstacles00);
                if(above)
                {
                    p1.nm.Top -= 10;
                }
                if(below)
                {
                    p1.nm.Top += 10;
                }
                if(toTheLeft)
                {
                    p1.nm.Left -= 10;
                }
                if(toTheRight)
                {
                    p1.nm.Left += 10;
                }
            }

            if (p1.nm.Bounds.IntersectsWith(obstacles01.Bounds))
            {
                whichDirection(obstacles01);
                if (above)
                {
                    p1.nm.Top -= 10;
                }
                if (below)
                {
                    p1.nm.Top += 10;
                }
                if (toTheLeft)
                {
                    p1.nm.Left -= 10;
                }
                if (toTheRight)
                {
                    p1.nm.Left += 10;
                }
            }

            if (p1.nm.Bounds.IntersectsWith(obstacles02.Bounds))
            {
                whichDirection(obstacles02);
                if (above)
                {
                    p1.nm.Top -= 10;
                }
                if (below)
                {
                    p1.nm.Top += 10;
                }
                if (toTheLeft)
                {
                    p1.nm.Left -= 10;
                }
                if (toTheRight)
                {
                    p1.nm.Left += 10;
                }
            }

            if (p1.nm.Bounds.IntersectsWith(obstacles03.Bounds))
            {
                whichDirection(obstacles03);
                if (above)
                {
                    p1.nm.Top -= 10;
                }
                if (below)
                {
                    p1.nm.Top += 10;
                }
                if (toTheLeft)
                {
                    p1.nm.Left -= 10;
                }
                if (toTheRight)
                {
                    p1.nm.Left += 10;
                }
            }

            if (p1.nm.Bounds.IntersectsWith(lootyDooty.Bounds))
            {
                lootyDooty.Visible = false;
                lootyDooty.Top = -100;
                lootCount += 100;
                pictureBox3.Image = lootCounterChange[lootCount/100];
            }

            if(p1.nm.Bounds.IntersectsWith(treasureChest.Bounds))
            {
                treasureChest.Image = Properties.Resources.Chest_Open;
                lootCount += 100;
                pictureBox3.Image = lootCounterChange[lootCount / 100];
            }
        }

        public void whichDirection(PictureBox pic)
        {
            if (p1.nm.Top < en1.nm.Top)
            {
                above = true;
                below = false;
                toTheRight = false;
                toTheLeft = false;
            }
            else if (p1.nm.Bottom > pic.Bottom)
            { 
                below = true;
                above = false;
                toTheRight = false;
                toTheLeft = false;
            }
            else if (p1.nm.Right < pic.Left)
            { 
                toTheLeft = true;
                below = false;
                toTheRight = false;
                above = false;
            }
            else if (p1.nm.Left > pic.Right)
            {
                toTheRight = true;
                below = false;
                above = false;
                toTheLeft = false;
            }
            }

        public void doors()
        {
            if (!(mm.nextDoor(prow, pcol, "L")))
            {
                lefdoor.Visible = false;
            }
            else if (mm.nextDoor(prow, pcol,"L"))
            {
                lefdoor.Visible = true;
            }

            if (!(mm.nextDoor(prow, pcol, "U")))
            {
                updoor.Visible = false;
            }
            else if (mm.nextDoor(prow, pcol,"U"))
            {
                updoor.Visible = true;
            }

            if (!(mm.nextDoor(prow, pcol, "D")))
            {
                downdoor.Visible = false;
            }
            else if(mm.nextDoor(prow,pcol,"D"))
            {
                downdoor.Visible = true;
            }

            if (!(mm.nextDoor(prow, pcol, "R")))
            {
                rigdoor.Visible = false;
            }
            else if(mm.nextDoor(prow,pcol,"R"))
            {
                rigdoor.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            keydelay = true;

            if (newRoomDelay > 0)
            {
                newRoomDelay--;
                en1.nm.Visible = false;
                if(newRoomDelay==0)
                { en1.nm.Visible = true;  }
                
            }
            else if (hunt)
            {
                en1.chase(p1.nm.Top, p1.nm.Left);

                whichDirection(en1.nm);
                if(above)
                {
                    en1.nm.Image = en1.animate(en1.sprites4animationU);
                }
                if (below)
                {
                    en1.nm.Image = en1.animate(en1.sprites4animationD);
                }
                if (toTheLeft)
                {
                    en1.nm.Image = en1.animate(en1.sprites4animationL);
                }
                if (toTheRight)
                {
                    en1.nm.Image = en1.animate(en1.sprites4animationR);
                }
            }
        }

        Random obsTop = new Random();
        Random obsLeft = new Random();
        public void bgChanger(int x, int y)
        {
            int top = obsTop.Next(100, 500);
            int left = obsLeft.Next(100,1000);

            doors();
            BackgroundImage = bgs[x, y];
            obstacles00.Top=top;
            obstacles00.Left = left;

            top = obsTop.Next(100, 500);
            left = obsLeft.Next(100, 1000);
            obstacles01.Top = top;
            obstacles01.Left = left;

            top = obsTop.Next(100, 500);
            left = obsLeft.Next(100, 1000);
            obstacles02.Top = top;
            obstacles02.Left = left;

            top = obsTop.Next(100, 500);
            left = obsLeft.Next(100, 1000);
            obstacles03.Top = top;
            obstacles03.Left = left;

            if (mm.roomCode(x,y)==3)
            {
                Troom = true;
                lootyDooty.Visible = true;
                downdoor.BackColor = Color.Transparent;
                treasureChest.Visible = true;
                treasureChest.Top = this.Height / 2;
                treasureChest.Left = this.Width / 2;
            }
            if(mm.roomCode(x,y)==4)
            {
                Eroom = true;
                en1.nm.Visible = true;
                en1.nm.Left = this.Width / 2;
                en1.nm.Top = 200;
            }
            if(mm.roomCode(x,y)==6)
            {
                eXIT = true;
                downdoor.BackColor = Color.Transparent;
                downdoor.Visible = true;
            }
            if(mm.roomCode(x,y)==7)
            { 
                treasureChest.Visible = true;
                treasureChest.Top = this.Height / 2;
                treasureChest.Left = this.Width / 2;
            }

        }

        public bool changeHunt()
        {
            hunt = !(hunt);
            return hunt;

        }
    }

}