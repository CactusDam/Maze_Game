using System;
using System.Windows.Forms;

namespace finalgame
{
    public partial class MAPWINDOW : Form
    {
        MapMaker mapper = new MapMaker();
        string[,] hell = new string[3, 3];
        PictureBox[,] themBoxes = new PictureBox[3, 3];
        public MAPWINDOW()
        {
            InitializeComponent();

            themBoxes[0, 0] = c0r0;
            themBoxes[0, 1] = c0r1;
            themBoxes[0, 2] = c0r2;

            themBoxes[1, 0] = c1r0;
            themBoxes[1, 1] = c1r1;
            themBoxes[1, 2] = c1r2;

            themBoxes[2, 0] = c2r0;
            themBoxes[2, 1] = c2r1;
            themBoxes[2, 2] = c2r2;

            KeyDown += new KeyEventHandler(KeyPressed);
        }

        void KeyPressed(object sen, KeyEventArgs keys)
        {
            if(keys.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }


            private void MAPWINDOW_Load(object sender, EventArgs e)
        {
            //top left
            c0r0.Top = 0; c0r0.Left = 0;
            c0r0.Width = this.Width / 3;
            c0r0.Height = this.Height / 3;

            //middle left
            c0r1.Left = c0r0.Left;
            c0r1.Top = c0r0.Bottom;
            c0r1.Width = this.Width / 3;
            c0r1.Height = this.Height / 3;

            //middle bottom
            c0r2.Left = c0r0.Left;
            c0r2.Top = c0r1.Bottom;
            c0r2.Width = this.Width / 3;
            c0r2.Height = this.Height / 3;

            //center top
            c1r0.Left = c0r0.Right;
            c1r0.Top = c0r0.Top;
            c1r0.Width = this.Width / 3;
            c1r0.Height = this.Height / 3;

            //true middle
            c1r1.Left = c1r0.Left;
            c1r1.Top = c0r1.Top;
            c1r1.Width = this.Width / 3;
            c1r1.Height = this.Height / 3;

            //center bottom
            c1r2.Left = c1r0.Left;
            c1r2.Top = c0r2.Top;
            c1r2.Width = this.Width / 3;
            c1r2.Height = this.Height / 3;

            //top right
            c2r0.Left = c1r0.Right;
            c2r0.Top = c0r0.Top;
            c2r0.Width = this.Width / 3;
            c2r0.Height = this.Height / 3;

            //right middle
            c2r1.Left = c2r0.Left;
            c2r1.Top = c0r1.Top;
            c2r1.Width = this.Width / 3;
            c2r1.Height = this.Height / 3;

            //bottom right
            c2r2.Left = c2r0.Left;
            c2r2.Top = c0r2.Top;
            c2r2.Width = this.Width / 3;
            c2r2.Height = this.Height / 3;

            

        }

        public void fillSquares(string[,] fromHere)
        {
            for(int x=0;x<3;x++)
            {
                for(int y=0;y<3;y++)
                {
                    if(fromHere[x,y]=="2")
                    {
                        themBoxes[x, y].BackgroundImage = Properties.Resources.black;
                    }
                }
            }
        }

        public void playerBlock(int x, int y)
        {
            MessageBox.Show("HERE " + x + "" + y);
            themBoxes[y, x].Image = Properties.Resources.MC_IDLE_1;
        }

        public string readm()
        {
            string heyo = "";
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    heyo += " " + hell[x, y];
                }
            }
            return heyo;
        }


    }
}
