using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace MiddleMeeter
{
    class SearchPage : ContentPage
    {
        public SearchPage()
        {
            //BackgroundColor = Color.Black;
            Title = "Game Release Countdown";
            Padding = 20;

            var button1 = new Button { Text = "Search...", HorizontalOptions = LayoutOptions.End, WidthRequest=200 };
            button1.Clicked += Button1_Clicked;

            var picker = new Picker { Title = "Mode" };
            foreach (var mode in new string[] { "Coffee", "Food", "Drinks" })
            {
                picker.Items.Add(mode);
            }

            Label header = new Label
            {
                Text = "TableView for a form",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("TableView Title")
                {
                    new TableSection("A JCALEX APP...")
                    {
                        new ImageCell
                        {
                            // This is the call to method getSource() 
                            ImageSource = getSource(),
                            Text = "Call of Duty - WWII",
                            Detail = "This is a little detail of the information...",
                        },
                    },
                }
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    //header,
                    tableView,

                    // Move this to its own label ////////////////////////////////////////////
                    new Label { Text = "Your  Location"},
                    new Entry { Placeholder = "Your location"},
                    new Label { Text = "Their  Location"},
                    new Entry { Placeholder = "Their location"},
                    new Label { Text = "mode:"},
                    picker,

                    button1,
                }
            };


        }

        // related to button1 above and what to do when pressed
        void Button1_Clicked(object sender, EventArgs e)
        {
            var results = new Result[] {
                new MiddleMeeter.Result { Name = "Starbucks", Description = "Some Coffee" },
                new MiddleMeeter.Result { Name = "Seattle Tea", Description = "Some moew Coffee" } ,
                new MiddleMeeter.Result { Name = "Dutch Brothers", Description = "Other kind of Coffee" },
            };
            Navigation.PushAsync(new ResultsPage(results));
        }

        // Method to get the format to retreive the image for Platform specific detaisl
        private ImageSource getSource()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"));
                case Device.Android:
                    //return ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"));
                    //return ImageSource.FromFile("waterfront.jpg");
                    return ImageSource.FromFile("Icon.png");
                case Device.WinPhone:
                    return ImageSource.FromFile("Images/waterfront.jpg");
                default:
                    return ImageSource.FromFile("Images/waterfront.jpg");
            }
        }
    }
}