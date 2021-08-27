using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalgame
{
    public class Player:Character
    {
        public Player()
        {
            sprites4animationL[0] = Properties.Resources.MC_SIDE_LEFT_1;
            sprites4animationL[1] = Properties.Resources.MC_SIDE_LEFT_2;
            sprites4animationL[2] = Properties.Resources.MC_SIDE_LEFT_3;

            sprites4animationR[0] = Properties.Resources.MC_SIDE_MOVE_1;
            sprites4animationR[1] = Properties.Resources.MC_SIDE_MOVE_2;
            sprites4animationR[2] = Properties.Resources.MC_SIDE_MOVE_3;

            sprites4animationU[0] = Properties.Resources.MC_MOVE_UP_1;
            sprites4animationU[1] = Properties.Resources.MC_MOVE_UP_2;

            sprites4animationD[0] = Properties.Resources.MC_MOVE_DOWN_1;
            sprites4animationD[1] = Properties.Resources.MC_MOVE_DOWN_2;
        }
        int attk = 15;
        
        int row = 0;
        int col = 0;

        public int getRow()
        {
            return row;
        }
        public void setRow(int x)
        {
            row = x;
        }
        public int getCol()
        {
            return col;
        }
        public void setCol(int x)
        {
            col = x;
        }

 

        public int BeenHit()
        {
            Enemy x=new Enemy();
            health = HealthLoss(health, x.getATT());
            return health;
        }

        //public void setHealth(int newHealth)
        //{
        //    health = newHealth;
        //}
     
        public int getAttack()
        {
            return attk;
        }
    }
}
