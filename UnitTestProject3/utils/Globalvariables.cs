using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.utils
{
    public class Globalvariables
    {
        public static readonly string ArmpageUrl = ConfigurationManager.AppSettings["ArmpageUrl"].ToString();
    }
}
