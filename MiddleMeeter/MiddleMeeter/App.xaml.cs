using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MiddleMeeter
{
    public partial class App : Application
    {
        public App ()
        {
            MainPage = new NavigationPage(new SearchPage());
        }
    }
}