using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var22
{
    public class Class
    {
        public string Kolvo { set; get; }

        public string isTempIce()
        {
            string end;
            int last = int.Parse(Kolvo[Kolvo.Length - 1].ToString());
            if (last == 1)
            {
                if (int.Parse(Kolvo) == 11)
                {
                    end = "бов";
                    return end;
                }
                end = "б";
                return end;
            }

            else if ((last == 2) || (last == 3) || (last == 4)) 
            {
                if ((int.Parse(Kolvo) == 12) && (int.Parse(Kolvo) == 13) && (int.Parse(Kolvo) == 14))
                { 
                end = "бов";
                return end;
                }
                end = "ба";
                return end;
            }

            else if ((last == 5) || (last == 6) || (last == 7) || (last == 8) || (last == 9) || (last == 0)) 
            {
                end = "бов";
                return end;
            }
            else
            {
                end = "0";
                return end;
            }

        }
    }
}
