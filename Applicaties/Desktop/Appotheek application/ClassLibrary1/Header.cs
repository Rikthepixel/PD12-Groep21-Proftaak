using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Appotheekcl
{
    class Header
    {
        DataAccess dataAccess;
        public Header()
        {
            dataAccess = new DataAccess();
        }

        public IPage ActivePage { get; set; }
        public List<IPage> pages { get; set; }

        public void SetActivePage()
        {

        }

        public void SetNameTag()
        {

        }

        public void GetLoggedIn()
        {

        }


    }
}
