using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalgame
{
    class MapMaker
    {
        string[,] maplog = new string[3, 3];
        string readstuff;

        public MapMaker()
        {

        }

        public void generateMap()
        {
            Random rand = new Random();
            int x = 1;
            //int x = rand.Next(0, 2);

            if (x == 1)
            {
                string text = System.IO.File.ReadAllText(@"C:\\Users\\conti\\Desktop\\Old_Finals\\final-2019-s-alpha\\FILLE1.txt");
                readstuff = text;
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        maplog[y, z] = text.Substring(0, 1);
                        text = text.Substring(1);
                    }
                }
                
            }
            else if (x == 2)
            {
                string text = System.IO.File.ReadAllText(@"C:\\Users\\conti\\Desktop\\Old_Finals\\final-2019-s-alpha\\FILLE2.txt");
                readstuff =text;
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        maplog[y, z] = text.Substring(0, 1);
                        text = text.Substring(1);
                    }
                }
                
            }
            else
            {
                string text = System.IO.File.ReadAllText(@"C:\\Users\\conti\\Desktop\\Old_Finals\\final-2019-s-alpha\\FILLE3.txt");
                readstuff = text;
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        if (text.Length > 1)
                        {
                            maplog[y, z] = text.Substring(0, 1);
                            text = text.Substring(1);
                        }
                    }
                }
            }
            
        }

        public string sendGrid()
        {
            return readstuff;
        }

        public string[,] readm()
        {
            string[,] temp=new string[3,3];

            for(int x=0;x<3;x++)
            {
                for(int y=0;y<3;y++)
                {
                    temp[x, y] = maplog[x, y];
                }
            }

            return temp;
        }

        public int roomCode(int x, int y)
        {
            return Convert.ToInt32(maplog[x, y]);
        }
 
        //x is across and y is down
        public bool nextDoor(int x, int y, string direction)
        {
            if(direction=="L")
            {
                if(x > 0)
                {
                    if (maplog[x - 1, y] == "2")
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                {
                    return false;
                }
            }
            else if(direction=="R")
            {
                if (x < 2)
                {
                    if (maplog[x + 1, y] == "2")
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
            else if(direction=="U")
            {
                if (y > 0)
                {
                    if (maplog[x, y - 1] == "2")
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
            else
            {
                if (y < 2)
                {
                    if (maplog[x, y + 1] == "2")
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
        }
    }
}
