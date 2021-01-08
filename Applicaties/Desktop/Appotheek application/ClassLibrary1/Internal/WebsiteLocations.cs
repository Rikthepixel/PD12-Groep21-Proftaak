using System;
using System.Collections.Generic;
using System.Text;

namespace Appotheekcl.Internal
{
    public static class WebsiteLocations
    {
        private const string MainURL = "https://app-otheek.it-tutorial.info/";//http://127.0.0.1/
        private const string QueryPagePath = "Producten/FetchData.php";
        private const string LoginPagePath = "Users/Login/LoginMain.php";

        public static string MainSite { get { return MainURL; } }
        public static string QueryPage { get { return MainURL + QueryPagePath; } }
        public static string LoginPage { get { return MainURL + LoginPagePath; } }
    }
}
