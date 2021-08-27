using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace finalgame
{
    public class Enemy:Character
    {
        int attk = 10; //int health = 150;
        int speed = 1; 

        Image[] enIdleL = new Image[2];
        Image[] enIdleR = new Image[2];
        Image[] enIdleU = new Image[2];
        Image[] enIdleD = new Image[2];

        Image[] enBI = new Image[2];
        Image[] enDE = new Image[5];

        Image[] enL = new Image[3];
        Image[] enR = new Image[3];
        Image[] enU = new Image[2];
        Image[] enD = new Image[2];

        public Enemy()
        {
            sprites4animationIDLEB[0] = Properties.Resources.Enemy_Battle_Idel_1;
            sprites4animationIDLEB[1] = Properties.Resources.Enemy_Battle_Idel_2;

            sprites4DEATH[0] = Properties.Resources.Enemy_Death_1;
            sprites4DEATH[1] = Properties.Resources.Enemy_Death_2;
            sprites4DEATH[2] = Properties.Resources.Enemy_Death_3;
            sprites4DEATH[3] = Properties.Resources.Enemy_Death_4;
            sprites4DEATH[4] = Properties.Resources.Enemy_Death_5;

            sprites4animationIDLEL[0] = Properties.Resources.Enemy_Idel_Left_1;
            sprites4animationIDLEL[1] = Properties.Resources.Enemy_Idel_Left_2;

            sprites4animationIDLER[0] = Properties.Resources.Enemy_Idle_1;
            sprites4animationIDLER[1] = Properties.Resources.Enemy_Idle_2;

            sprites4animationIDLEU[0] = Properties.Resources.Enemy_Idle_Up_1;
            sprites4animationIDLEU[0] = Properties.Resources.Enemy_Idle_Up_2;

            sprites4animationIDLED[0] = Properties.Resources.Enemy_Idle_Down_1;
            sprites4animationIDLED[0] = Properties.Resources.Enemy_Idle_Down_1;

            sprites4animationL[0] = Properties.Resources.Enemy_Move_Left_1;
            sprites4animationL[1] = Properties.Resources.Enemy_Move_Left_2;
            sprites4animationL[2] = Properties.Resources.Enemy_Move_Left_3;

            sprites4animationR[0] = Properties.Resources.Enemy_Move_Right_1;
            sprites4animationR[1] = Properties.Resources.Enemy_Move_Right_2;
            sprites4animationR[2] = Properties.Resources.Enemy_Move_Right_3;

            sprites4animationU[0] = Properties.Resources.Enemy_Move_Up_1;
            sprites4animationU[1] = Properties.Resources.Enemy_Move_Up_2;

            sprites4animationD[0] = Properties.Resources.Enemy_Move_Down_1;
            sprites4animationD[1] = Properties.Resources.Enemy_Move_Down_2;

            setHealth(150);
        }

        public int getATT()
        {
            return attk;
        }

        public void chase(int x, int y)
        {
            if(x>nm.Top)
            {
                nm.Top+=speed;
            }
            if(x<nm.Top)
            {
                nm.Top -= speed;
            }
            if(y>nm.Left)
            {
                nm.Left+=speed;
            }
            if(y<nm.Left)
            {
                nm.Left -= speed;
            }
        }

        public int Hit()
        {
            Player x = new Player();
            health = HealthLoss(health, x.getAttack());
            return health;
        }
    }
}
