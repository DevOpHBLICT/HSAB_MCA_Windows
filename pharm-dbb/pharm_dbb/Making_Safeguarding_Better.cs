
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace SAFA
{






    public class Making_Safeguarding_Better : ContentPage
    {
        private ListView listView;
        private ListView _pharmacylist;


        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Making_Safeguarding_Better();
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



        public Making_Safeguarding_Better()
        {

            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Making Safeguarding Personal", TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };



            var t = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "", Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };
            var u = new Label { Text = "", FontSize = 10 };

            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";

            App.app_title = "Personal Safeguarding";
            Title = "Personal Safeguarding";
            BackgroundColor = Color.White;

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.FromHex("#FCDED4");



            /*
            var data = new List<GetFrontPage2>  {

            new GetFrontPage2("Making safeguarding personal is a shift in culture and professional practice.", "Arrow1.png"),
            new GetFrontPage2("It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety.", "Arrow2.png"),
            new GetFrontPage2("It is about empowering the adult at risk to ensure that their wishes/desired outcomes are considered as part of the safeguarding process.", "Arrow3.png"),
            new GetFrontPage2("It is about seeing people as experts in their own lives and working alongside them.", "Arrow25.png"),
            new GetFrontPage2("The alerter must note the person’s wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority.", "Arrow4.png"),
  
            };
            */
            Label L_title= new Label { TextColor = Color.FromHex("7d4d68"), Font = Font.SystemFontOfSize(25,FontAttributes.Bold), Text = "Making safeguarding personal" };

            Label L1 = new Label { TextColor = Color.FromHex("5e3a4e"), Font = Font.SystemFontOfSize(20) , Text = "\u2022 Making safeguarding personal is a shift in culture and professional practice." };

            Label L2 = new Label { TextColor = Color.FromHex("7d4d68"), Font = Font.SystemFontOfSize(20) , Text = "\u2022 It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety." };
            Label L3 = new Label { TextColor = Color.FromHex("5e3a4e"), Font = Font.SystemFontOfSize(20) , Text = "\u2022 It is about empowering the adult at risk to ensure that their wishes/desired outcomes are considered as part of the safeguarding process." };
            Label L4 = new Label { TextColor = Color.FromHex("7d4d68"), Font = Font.SystemFontOfSize(20) , Text = "\u2022 It is about seeing people as experts in their own lives and working alongside them." };
            Label L5 = new Label { TextColor = Color.FromHex("5e3a4e"), Font = Font.SystemFontOfSize(20) , Text = "\u2022 The alerter must note the person’s wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority." };
  
            
            /*
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
            */
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


            



           

            var k = new StackLayout
            {
                Padding = 1,
                //  BackgroundColor = Color.White,
                Children = {
             //       _pharmacylist

                }
            };

            var grid = new Grid
            {
                Padding = 1,
                RowSpacing = 1
            };

   

            Label Risk_Label = new Label {TextColor=Color.Black, Text = "Making safeguarding personal is a shift in culture and professional practice." };
            Image Risk_Image = new Image { Source = "Arrow1.png" };

            Label freq = new Label {TextColor = Color.Black,Text =  "It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety. " };
           Image fi = new Image { Source = "Arrow2.png" };

             Label harm = new Label {TextColor=Color.Black, Text = "It is about empowering the adult at risk to ensure that their wishes/desired outcomes are considered as part of the safeguarding process." };
            Image h = new Image { Source = "Arrow3.png" };

            Label lifestyle = new Label { TextColor = Color.Black, Text = "It is about seeing people as experts in their own lives and working alongside them." };
            Image l = new Image { Source = "Arrow1.png" };

            Label kk = new Label { TextColor = Color.Black, Text = "The alerter must note the person’s wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority." };
            Image arrow2 = new Image { Source = "Arrow2.png" };


            grid.Children.Add(Risk_Image,0, 0);
            grid.Children.Add(Risk_Label, 1, 6,0,1);

            grid.Children.Add(fi, 0, 1);
            grid.Children.Add(h, 0, 3);
            grid.Children.Add(l,0, 4);
            grid.Children.Add(arrow2, 0, 5);


            grid.Children.Add(freq,1, 6,1,3);
            grid.Children.Add(harm, 1, 6, 3, 5);

            grid.Children.Add(lifestyle, 1, 6, 4, 5);

            grid.Children.Add(kk, 1, 6, 5, 6);


                    Content = new StackLayout {
                        Padding = new Thickness(6, 6, 6, 6),
                        Children = {L_title,L1,L2,L3,L4,L5 }
            };





            


              
        }
    }
}