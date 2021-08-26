using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject3.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3.pageobjects
{
   public class titleverification : pagebases
    {
        private Global global;
        public titleverification(Global global) : base(global)
        {
            this.global = global;
        }
        public void armtitle()
        {
            string m = Driver.Title;
            Console.WriteLine(m);
        }
    }
}
