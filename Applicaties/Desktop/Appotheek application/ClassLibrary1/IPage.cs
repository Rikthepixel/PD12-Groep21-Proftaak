using System.Windows.Forms;

namespace Appotheekcl
{
    public interface IPage
    {
        bool LoginRequired { get; set; }
    }
}