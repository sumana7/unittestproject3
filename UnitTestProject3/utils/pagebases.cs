﻿using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.utils
{
    public class pagebases : baseclass
    {
        private Global global;

        public pagebases(Global global) : base(global.Driver)
        {
            this.global = global;
            PageFactory.InitElements(Driver, this);
        }
    }
}
