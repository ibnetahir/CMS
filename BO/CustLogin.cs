using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIDDLE;
namespace BO
{
    public class CustLogin
    {
        verifier verify = new verifier();
        // for the customer login Data
        public bool loginData(ref string name,string password)
        {
            return verify.verifyCustomer(ref name, password);
        }
    }
}
