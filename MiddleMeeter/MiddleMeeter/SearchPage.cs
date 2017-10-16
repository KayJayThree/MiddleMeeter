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
                    new TableSection("Table Section")
                    {
                        new TextCell
                        {
                            Text = "Text Cell",
                            Detail = "With Detail Text",
                        },
                        new ImageCell
                        {
                            ImageSource = getSource(),
                            Text = "Image Cell",
                            Detail = "With Detail Text",
                        },
                         new SwitchCell
                        {
                            Text = "Switch Cell"
                        },
                        new EntryCell
                        {
                            Label = "Entry Cell",
                            Placeholder = "Type text here"
                        },
                        new ViewCell
                        {
                            View = new Label
                            {
                                Text = "A View Cell can be anything you want!"
                            }
                        }
                    },
                }
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView,
                }
            };


        }

        private ImageSource getSource()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"));
                case Device.Android:
                    //return ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"));
                    //return ImageSource.FromFile("waterfront.jpg");
                    return ImageSource.FromFile("icon.png");
                case Device.WinPhone:
                    return ImageSource.FromFile("Images/waterfront.jpg");
                default:
                    return ImageSource.FromFile("Images/waterfront.jpg");
            }
        }
    }
}