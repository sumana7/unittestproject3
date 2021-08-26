using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject3.utils;


namespace UnitTestProject3.pageobjects
{
    public class basepageobject
    {
        private readonly Global browser;
        public armhomepage Ahp;
        public linksverify lvp;
        public titleverification Tvc;
        public aahomepage hp;
        public aaguestpage gp;
        public Nikehomepage Nhp;
        public Nikeallshoes Nas;
        public addtobagepage Abp;
        public verifiyingtheshoe Vts;

        public basepageobject(Global browser)
        {
            this.browser = browser;
            Ahp = new armhomepage(browser);
            lvp = new linksverify(browser);
            Tvc = new titleverification(browser);
            hp = new aahomepage(browser);
            gp = new aaguestpage(browser);
            Nhp = new Nikehomepage(browser);
            Nas = new Nikeallshoes(browser);
            Abp = new addtobagepage(browser);
            Vts = new verifiyingtheshoe(browser);
        }
    }

}


