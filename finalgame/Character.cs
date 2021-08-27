using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace finalgame
{
    public class Character
    {
        public int health = 100;
        int location = 0;
        double dodgeChance = .2;
        public Image[] sprites4animationIDLEL = new Image[3];
        public Image[] sprites4animationIDLER = new Image[3];
        public Image[] sprites4animationIDLEU = new Image[3];
        public Image[] sprites4animationIDLED = new Image[3];

        Image[] healthProgress = new Image[15];

        public Image[] sprites4animationIDLEB = new Image[2];
        public Image[] sprites4DEATH = new Image[5];

        public Image[] sprites4animationL = new Image[3];
        public Image[] sprites4animationR = new Image[3];
        public Image[] sprites4animationU = new Image[2];
        public Image[] sprites4animationD = new Image[2];

        public PictureBox nm;
        public Character()
        {
            healthProgress[0] = Properties.Resources.Life_Bar_1;
            healthProgress[1] = Properties.Resources.Life_Bar_2;
            healthProgress[3] = Properties.Resources.Life_Bar_3;
            healthProgress[4] = Properties.Resources.Life_Bar_4;
            healthProgress[5] = Properties.Resources.Life_Bar_5;
            healthProgress[6] = Properties.Resources.Life_Bar_6;
            healthProgress[7] = Properties.Resources.Life_Bar_7;
            healthProgress[8] = Properties.Resources.Life_Bar_8;
            healthProgress[9] = Properties.Resources.Life_Bar_9;
            healthProgress[10] = Properties.Resources.Life_Bar_10;
            healthProgress[11] = Properties.Resources.Life_Bar_11;
            healthProgress[12] = Properties.Resources.Life_Bar_12;
            healthProgress[13] = Properties.Resources.Life_Bar_13;
            healthProgress[14] = Properties.Resources.Life_Bar_14;
        }

        public Image getHealthBar(int x)
        {
            return healthProgress[x];
        }

        public int GetHealth()
        {
            return health;
        }

        public int HealthLoss(int curr, int ENatt)
        {
            health = curr - ENatt;
            return curr-ENatt;
        }

        public Image animate(Image[] images)
        {
            if (location + 1 < images.Length)
            {
                location++;
                return images.ElementAt(location);
            }
            else
                location = 0;
                return images.ElementAt(location);
        }

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int toThis)
        {
            health = toThis;
        }

        public void doTheDodge()
        {
            dodgeChance += .2;
        }

        public double getDodge()
        {
            return dodgeChance;
        }

    }
}
