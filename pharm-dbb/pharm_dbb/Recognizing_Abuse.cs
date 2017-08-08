
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace SAFA
{






    public class Recognizing_Abuse : ContentPage
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




        
        public class GetFrontPage
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }



        public Recognizing_Abuse()
        {

            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Recognizing Abuse", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(25, FontAttributes.Bold) };



            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            BackgroundColor = Color.FromHex("#FCDED4");




            var data = new List<GetFrontPage>  {

            new GetFrontPage("Risk is not in itself a safeguarding issue, as not all risks will result in a negative impact on the individual.", "Risk.png"),
                new GetFrontPage("Abuse may be an isolated incident or multiple, affecting one or more people.", "Frequency.png"),
                   new GetFrontPage("Harm should be taken to include not only ill treatment but also the impairment of, or avoidable deterioration in, physical or mental health and the impairment of physical, intellectual, emotional, social or behavioural development.", "Harm.png"),


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
                  NavigationPage.SetHasNavigationBar(this, false);
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
            var ss = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Recognizing Abuse", TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };

            var grid = new Grid
            {
                Padding = 10,
                RowSpacing = 10
            };

            Label Risk_Label = new Label { TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20), Text = "Risk is not in itself a safeguarding issue, as not all risks will result in a negative impact on the individual." };
            Image Risk_Image = new Image { Source = "Risk.png" };

            Label freq = new Label { TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20), Text =  "Abuse may be an isolated incident or multiple, affecting one or more people." };
           Image fi = new Image { Source = "Frequency.png" };


            Label harm = new Label { TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20), Text = "Harm should be taken to include not only ill treatment but also the impairment of, or avoidable deterioration in, physical or mental health and the impairment of physical, intellectual, emotional, social or behavioural development." };
            Image h = new Image { Source = "Harm.png" };


            grid.Children.Add(Risk_Image,0, 0);
            grid.Children.Add(Risk_Label, 1, 4,0,1);

           grid.Children.Add(fi, 0, 1);
          grid.Children.Add(h, 0, 2);

            grid.Children.Add(freq,1, 4,1,2);

            grid.Children.Add(harm, 1, 4, 2, 3);



            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)), Text = "Next", IsVisible = true, Image = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White };
            yes.Clicked += OnyesButtonClicked;
            yes.HeightRequest = 70;

            //    grid.Children.Add(fi, 0, 1,0,1); // Left, Second element 
            //       grid.Children.Add(freq, 1, 2,1,1); // Right, Second element 
            /*
                        grid.Children.Add(h, 0, 2); // Left, Second element 
                        grid.Children.Add(harm, 1, 2); // Right, Second element 

            */
            Content = new StackLayout
            {
                Padding=5,
                Children = { ss, grid ,yes}
            };


        //    Content = grid;






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