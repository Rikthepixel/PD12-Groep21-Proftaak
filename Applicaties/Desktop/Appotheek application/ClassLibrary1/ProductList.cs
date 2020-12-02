using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Appotheekcl
{
    public class ProductList : IPage
    {
        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public List<Product> Products { get; set; }
    }
}
