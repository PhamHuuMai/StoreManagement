using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoft.Until
{
   public class Static
    {
        public static String userName;
        public static string ConnectString = "";
        public static int Separate(String loccation)
        {
            try
            {
                String[] strs = loccation.Split('-');
                return Convert.ToInt32(strs[0])-1 + (Convert.ToInt32(strs[1])-1)*40;
            }
            catch(Exception ee)
            {
                throw ee;
            }
        }
        public static String ConvertPosition(int pos)
        {
            try
            {
                String s = "";
                int x = pos % 40 + 1;
                int y = (pos - pos % 40) / 40 + 1;
                s = x + "-" + y;
                return s;
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }
}
