
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace SAFA
{






    public class Recognizing_Abuse2 : ContentPage
    {
        private ListView listView;
        private ListView _pharmacylist;


        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Recognizing_Abuse2();
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }




        
        public class GetFrontPage2
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage2(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }



        public Recognizing_Abuse2()
        {

            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Recognizing Abuse", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };



            var t = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "", Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };
            var u = new Label { Text = "", FontSize = 10 };

            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";

            App.app_title = "Recognizing Abuse";
            Title = "Recognizing Abuse";
            BackgroundColor = Color.White;

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.FromHex("#FCDED4");




            var data = new List<GetFrontPage2>  {

            new GetFrontPage2("They may not take as much care as normal with their appearance, such as not bathing, shaving or washing their hair", "Hygine.png"),
                new GetFrontPage2("They may become  withdrawn, depressed or tearful. They may also be angry or aggressive for little reason.", "Behaviour.png"),
                   new GetFrontPage2("They may have unexplained or frequent injuries.", "Injuries.png"),
    new GetFrontPage2("They may stop going out, not  have any money to buy food or access leisure services, not want to be left alone with certain people or lose their appetite", "Lifestyle.png"),


            };

            _pharmacylist = new ListView
            {

                SeparatorColor = Color.FromHex("#ddd"),
            };
            _pharmacylist.ItemsSource = data;
            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("1760ae"));
            //  cell.SetValue(TextCell.TextProperty, );

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
            _pharmacylist.ItemTemplate = cell;
            // _pharmacylist.ItemTemplate = new DataTemplate(typeof(ImageCell));
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.TextProperty, "Name");
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Image");
            // _pharmacylist.SetValue(TextCell.TextColorProperty, Color.White);
            //  _pharmacylist.HeightRequest = 500;
            _pharmacylist.RowHeight = 130;
            _pharmacylist.HasUnevenRows = true;
            var a = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand

                //  Padding = new Thickness (5, 5, 5, 5), 
            };
            if (Device.OS == TargetPlatform.Windows)
            {

                //  Padding = new Thickness (5, 5, 5, 5), 
                a.Children.Add(s);
                a.Children.Add(t);
                a.Children.Add(u);
                NavigationPage.SetHasNavigationBar(this, false);
            }
            else
            {
                a.Children.Add(t);
                a.Children.Add(u);


            }



            //   var p = new StackLayout
            //   {
            //       Padding = 5,
            //       Children = { title }
            //   };



            var logo = new StackLayout
            {
                Padding = new Thickness(5, 5, 5, 5),
                Orientation = StackOrientation.Horizontal,

                Children = {
          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.CenterAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                          HeightRequest=30,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "HSAB.png" )
            }
                }

            };

            var k = new StackLayout
            {
                Padding = 5,
                //  BackgroundColor = Color.White,
                Children = {
                    _pharmacylist,logo

                }
            };

            var grid = new Grid
            {
                Padding = 10,
                RowSpacing = 10
            };
            var ss = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Recognizing Abuse (cont.)", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(25, FontAttributes.Bold) };

            Label Risk_Label = new Label { TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20), Text = "They may not take as much care as normal with their appearance, such as not bathing, shaving or washing their hair." };
            Image Risk_Image = new Image { Source = "Hygine.png" };

            Label freq = new Label { TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20), Text = "They may become  withdrawn, depressed or tearful. They may also be angry or aggressive for little reason." };
           Image fi = new Image { Source = "Behavior.png" };


            Label harm = new Label { TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20), Text = "They may have unexplained or frequent injuries." };
            Image h = new Image { Source = "Injuries.png" };

            Label lifestyle = new Label { TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20), Text = "They may stop going out, not  have any money to buy food or access leisure services, not want to be left alone with certain people or lose their appetite." };
            Image l = new Image { Source = "Lifestyle.png" };



            grid.Children.Add(Risk_Image,0, 0);
            grid.Children.Add(Risk_Label, 1, 4,0,1);

            grid.Children.Add(fi, 0, 1);
            grid.Children.Add(h, 0, 2);
            grid.Children.Add(l,0, 3);

            grid.Children.Add(freq,1, 4,1,2);
            grid.Children.Add(harm, 1, 4, 2, 3);

            grid.Children.Add(lifestyle, 1, 4, 3, 4);
       


            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)), Text = "Next", IsVisible = false, Image = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White };

            yes.HeightRequest = 20;

             Content = new StackLayout {
               Children = {s,yes, grid }
            };






            _pharmacylist.ItemSelected += (sender, e) =>
            {


                if (e.SelectedItem == null) return;
                var user = (GetFrontPage2)e.SelectedItem;
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
                    App.app_title = "Safeguarding Adults from Abuse (SAFA)";
                    var tg = new d("14", "safeguarding Adults from Abuse (SAFA)", "#bfbfbf");
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
                    var tg = new d("21", "Making safeguarding personal", "#bfbfbf");

                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }



                if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
                                                    // do something with e.SelectedItem
                ((ListView)sender).SelectedItem = null; // de-select the row

            };
        }
    }
}