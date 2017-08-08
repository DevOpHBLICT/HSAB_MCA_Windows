using SAFA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using Newtonsoft.Json.Linq;
using System.IO;
using Xamarin.Forms;

namespace SAFA
{




    public class definition : ContentPage
    {

        Button home;
        Button back;

        private string sp;
        private string t;
        private string yesnext;
        private string nonext;
        String _BGColor;





        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new d(yesnext, t, _BGColor);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        void BackButtonClicked(object sender, EventArgs e)
        {
            back.IsEnabled = false;

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }
        void HomeButtonClicked(object sender, EventArgs e)
        {

            var page = Navigation.NavigationStack.First();
            while (page.Navigation.NavigationStack.Count > 1)
            { page.Navigation.PopAsync(); }




        }




        public definition(string startpage, String Titles, String BGColor)
        {
            BackgroundColor = Color.White;

            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
                BackgroundColor = Color.FromHex("#FCDED4");


            }

            var ss = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = Titles, TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };

              Label l = new Label {FontSize=15, Text = "According to The Care Act (2014), an adult at risk is a person who:", TextColor = Color.FromHex("a51b26") };
            Image logo =
          new Image
          {

              //     BackgroundColor =Color.White,
              VerticalOptions = LayoutOptions.CenterAndExpand,
              HorizontalOptions = LayoutOptions.CenterAndExpand,
              HeightRequest = 30,
              //   WidthRequest=90,
              //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
              Source = ImageSource.FromFile("down.png")


          };

            Image logo2 =
          new Image
          {

              //     BackgroundColor =Color.White,
              VerticalOptions = LayoutOptions.CenterAndExpand,
              HorizontalOptions = LayoutOptions.CenterAndExpand,
              //   WidthRequest=90,
              HeightRequest = 30,
              //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
              Source = ImageSource.FromFile("down.png")


          };
            Image P1 =
       new Image
       {

           //     BackgroundColor =Color.White,
           VerticalOptions = LayoutOptions.CenterAndExpand,
           HorizontalOptions = LayoutOptions.CenterAndExpand,
           //   WidthRequest=90,
           HeightRequest = 130,
           //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
           Source = ImageSource.FromFile("p1.png")


       };
            Image P2 =
                  new Image
                  {

                      //     BackgroundColor =Color.White,
                      VerticalOptions = LayoutOptions.CenterAndExpand,
                      HorizontalOptions = LayoutOptions.CenterAndExpand,
                      //   WidthRequest=90,
                      HeightRequest = 130,
                      //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                      Source = ImageSource.FromFile("p2.png")


                  };

            Image P3 =
      new Image
      {

          //     BackgroundColor =Color.White,
          VerticalOptions = LayoutOptions.CenterAndExpand,
          HorizontalOptions = LayoutOptions.CenterAndExpand,
          //   WidthRequest=90,
          HeightRequest = 130,
          //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
          Source = ImageSource.FromFile("p3.png")


      };


            ContentView s = new ContentView
            {
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),
                BackgroundColor = Color.FromHex("c0504d"),
                Content =

                    new Label
                    {
                        FontFamily = "Calibri",
                        FontSize = 20,

                        TextColor = Color.White,
                        Text = "Has care and support needs, whether or not the Local Authority e.g. Hertfordshire County Council (HCC) is meeting any of those needs And;"
                    }
            };

            ContentView t = new ContentView
            {
                BackgroundColor = Color.FromHex("953735"),
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),

                Content =
                new Label
                {
                    FontFamily = "Calibri",
                    FontSize = 20,
                    TextColor = Color.White,
                    Text = "Is experiencing, or at risk of, abuse or neglect; And"
                }
            };
            ContentView u = new ContentView
            {
                BackgroundColor = Color.FromHex("632523"),
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),

                Content =
               new Label
               {
                   FontFamily = "Calibri",
                   FontSize = 20,

                   TextColor = Color.White,
                   Text = "As a result of those care and support needs is unable to protect themselves from abuse or neglect or the risk of it. "
               }
            };

            var a = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,

                  Padding = new Thickness (5, 5, 5, 5), 
            };
            if (Device.OS == TargetPlatform.Windows)
            {

                Label spacer = new Label { };
                a.Children.Add(ss);
                a.Children.Add(spacer);
                NavigationPage.SetHasNavigationBar(this, false);
            }


            a.Children.Add(l);
            a.Children.Add(P1);
            a.Children.Add(logo);
            a.Children.Add(P2);
            a.Children.Add(logo2);
            a.Children.Add(P3);



            Content = a;
        }
    }
}
