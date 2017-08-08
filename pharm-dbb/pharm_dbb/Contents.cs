
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace SAFA
{






    public class Contents : ContentPage
    {
        private ListView listView;
        private ListView _pharmacylist;





        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }




        public void Recognizing_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Safeguarding Adults from Abuse (SAFA)";
            var tg = new d("14", "safeguarding Adults from Abuse (SAFA)", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Reporting_Concerns_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Reporting a Concern";
            var tg = new d("17", "Reporting a concern", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Making_Safeguarding_Personal_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Making Safeguarding Personal";
            var tg = new d("21", "Making safeguarding personal", "#bfbfbf");

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }



        public class GetFrontPage
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage(string name, string image)
            {
                Name = name;
                Image = (FileImageSource)ImageSource.FromFile(image);


           


            }

        }



        public Contents()
        {

            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "HSAB Safeguarding Adults Prompts", TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };
      
            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";

            App.app_title = "HSAB SAFA Prompts";
            Title = "HSAB SAFA Prompts";

            BackgroundColor = Color.White;

            Label title = null;

    

            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
                  BackgroundColor = Color.FromHex("#FCDED4");


            }





            var data = new List<GetFrontPage>  {

            new GetFrontPage("Definition of an Adult at Risk", "Flag1.png"),
                new GetFrontPage("What is Safeguarding?", "Flag2.png"),
                   new GetFrontPage("Categories of Abuse", "Flag3.png"),
               new GetFrontPage("Recognizing Abuse", "Flag4.png"),
                 new GetFrontPage("Reporting a Concern", "Flag5.png"),
                 new GetFrontPage("Making Safeguarding Personal", "Flag6.png"),

            };

            _pharmacylist = new ListView
            {

                SeparatorColor = Color.FromHex("#ddd"),
            };
            _pharmacylist.ItemsSource = data;
            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("a51b26"));
            cell.SetValue(TextCell.TextProperty, Color.FromHex("a51b26"));


            //  cell.SetValue(TextCell.TextProperty, );

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
            _pharmacylist.ItemTemplate = cell;
            // _pharmacylist.ItemTemplate = new DataTemplate(typeof(ImageCell));
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.TextProperty, "Name");
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Image");
            // _pharmacylist.SetValue(TextCell.TextColorProperty, Color.White);
            //  _pharmacylist.HeightRequest = 500;
            _pharmacylist.RowHeight = 65;

            var a = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand

                //  Padding = new Thickness (5, 5, 5, 5), 
            };
            if (Device.OS == TargetPlatform.Windows)
            {

                Label spacer = new Label { };
                a.Children.Add(s);
                a.Children.Add(spacer);
                 NavigationPage.SetHasNavigationBar(this, false);
            }
            var logo = new StackLayout
            {
                Padding = new Thickness(5, 5, 5, 5),
                Orientation = StackOrientation.Horizontal,

                Children = {
          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.CenterAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                         // HeightRequest=30,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                           Source= (FileImageSource)ImageSource.FromFile("HSAB.png")

        }
                }

            };

            var k = new StackLayout
            {
                Padding = 5,
                //  BackgroundColor = Color.White,
                Children = {
                a,  _pharmacylist,logo
           //  logo
                }
            };

            Content = k;






            _pharmacylist.ItemSelected += (sender, e) =>
            {


                if (e.SelectedItem == null) return;
                var user = (GetFrontPage)e.SelectedItem;
                if (user.Name == "Definition of an Adult at Risk")
                {
                    App.app_title = "Definition of an Adult at Risk";
                    var tg = new definition("1", "Definition of an Adult at Risk", "#953735");
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "What is Safeguarding?")
                {
                    App.app_title = "What is Safeguarding?";
                    var tg = new What_Is_Safeguarding();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

                }
                if (user.Name == "Categories of Abuse")
                {
                    App.app_title = "Categories of Abuse";
                    var tg = new Categories_Abuse();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Recognizing Abuse")
                {
                    App.app_title = "Recognizing Abuse";
                    var tg = new Recognizing_Abuse();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }


                if (user.Name == "Reporting a Concern")
                {
                    App.app_title = "Reporting a concern";
                    var tg = new d("17", "Reporting a concern", "#bfbfbf");
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Making Safeguarding Personal")
                {
                    App.app_title = "Making Safeguarding Personal";
                    var tg = new Making_Safeguarding_Better();

                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }



                if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
                                                    // do something with e.SelectedItem
                ((ListView)sender).SelectedItem = null; // de-select the row

            };
        }
    }
}