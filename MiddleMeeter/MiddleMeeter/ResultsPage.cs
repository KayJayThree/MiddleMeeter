using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace MiddleMeeter
{
    class ResultsPage : ContentPage
    {
        public ResultsPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "ResultsPage"
                    },

                }
            };
        }
    }
}
