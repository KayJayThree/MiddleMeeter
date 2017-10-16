using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

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
                            // Some differences with loading images in initial release.
                            ImageSource =
#pragma warning disable CS0618 // Type or member is obsolete
                                Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                                                  ImageSource.FromFile("ide_xamarin_studio.png"),
                                                  ImageSource.FromFile("Images/ide-xamarin-studio.png")),
#pragma warning restore CS0618 // Type or member is obsolete
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
                    }
                }
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView
                }
            };
        }
    }
}