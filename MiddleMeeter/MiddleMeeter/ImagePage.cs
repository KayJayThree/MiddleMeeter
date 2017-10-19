using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace MiddleMeeter
{
    class ImagePage : ContentPage
    {
        public ImagePage()
        {
            var button1 = new Button { Text = "Jason ALexander" };
            button1.Clicked += Button1_Clicked;

            var picker = new Picker { Title = "Mode" };
            foreach (var mode in new string[] { "Coffee", "Food", "Drinks" })
            {
                picker.Items.Add(mode);
            }

            Title = "Image Page";

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                     new TableSection("A JCALEX APP...")
                    {
                        new ImageCell()
                        {
                            Height = 150,
                            
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
                    //button2,
                }
            };
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.Firebrick;
        }

        // Method to get the format to retreive the image for Platform specific detaisl
        private ImageSource getSource()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"));
                case Device.Android:
                    
                    WidthRequest = 600;
                    HeightRequest = 600;
                    MinimumHeightRequest = 600;
                    MinimumWidthRequest = 600;
                    return ImageSource.FromFile("Icon.png");

                    //VerticalOptions = LayoutOptions.End;
                    //HorizontalOptions = LayoutOptions.End;
                    //Aspect = Aspect.AspectFill;         //.AspectFit//.Fill  
                    
                case Device.WinPhone:
                    return ImageSource.FromFile("Images/waterfront.jpg");
                default:
                    return ImageSource.FromFile("Images/waterfront.jpg");
            }
        }
    }
}
