using System.Windows.Forms;

namespace Appotheekcl
{
    interface IPage
    {
        bool LoginRequired { get; set; }
        Form PageForm { get; set; }
    }
}