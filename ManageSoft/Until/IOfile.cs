using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ManageSoft.Until
{
   public class IOfile
    {
        public static void SaveAccount(String username,String password)
        {
            StreamWriter sw = new StreamWriter("account");
            sw.WriteLine(username + "\n" + password);
            sw.Flush();
            sw.Close();
        }
        public static String[] LoadAccount()
        {
            String[] s = { "", "" };
            StreamReader sr = new StreamReader("account");
            s[0]= sr.ReadLine();
            s[1] = sr.ReadLine();
            sr.Close();
            return s;
        }
    }
}
