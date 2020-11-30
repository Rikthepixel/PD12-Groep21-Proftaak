using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Appotheekcl
{
    class Order : IPage
    {
        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public ProductList Products { get; set; }

        public void InsertNewOrder()
        {

        }
    }
}
