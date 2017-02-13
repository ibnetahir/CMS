using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MIDDLE
{
    public class verifier
    {
        // for the verification of the customer login
        public bool verifyCustomer(ref string name, string passowrd)
        {
            FileStream file = new FileStream("customers.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            
            while(sr.ReadLine()!=null)
            {

                //if(Regex.IsMatch(str,@"^[0-9]+$"))
                //{
                    string s = sr.ReadLine(); string p = sr.ReadLine();
                    if(s == name && p == passowrd)
                    {
                        name = s;
                        file.Close();
                        sr.Close();
                        return true;
                    }
                //}
            }
            file.Close();
            sr.Close();
            return false;
        }
    }
}
