
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SAFA
{


    

    

    public class Categories_Abuse : ContentPage
    {
     

       


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }

        public void Physical_Abuse_Clicked(object sender, EventArgs args) {
            App.app_title = "Physical Abuse";
            var tg = new d("3", "Physical Abuse", "#953735");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
      
        }
        public void Domestic_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Domestic Abuse";
            var tg = new d("4", "Domestic Abuse", "#d99694");
          Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
     
        }
     
        public void Sexual_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Sexual Abuse";
            var tg = new d("5", "Sexual Abuse", "#e6b9b8"); ;
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
           
        }
     

        public void Psychological_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Psychological Abuse";
            var tg = new d("6", "Psychological Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Financial_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Financial or Material Abuse";
            var tg = new d("7", "Financial or Material Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Modern_Slavery_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Modern Slavery";
            var tg = new d("8", "Modern Slavery", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Discriminatory_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Discriminatory Abuse";
            var tg = new d("9", "Discriminatory Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Organisational_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Organisational Abuse";
            var tg = new d("10", "Organisational Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Neglect_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Neglect and acts of omission";
            var tg = new d("11", "Neglect and acts of omission", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Self_Neglect_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Self Neglect";
            var tg = new d("12", "Self Neglect", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
      



        public Categories_Abuse()
        {


             BackgroundColor = Color.White;

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Categories of Abuse", TextColor = Color.FromHex("a51b26"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };


            BackgroundColor = Color.FromHex("#FCDED4");

          
            if (Device.OS == TargetPlatform.Windows)
            {

                 NavigationPage.SetHasNavigationBar(this, false);
            }
           
           
            //  var pharm = database.GetContents();

            //  BackgroundImage = "people.jpg";
            Button Physical_Abuse = new Button {  Text = "Physical", BackgroundColor = Color.FromHex("#7D4D68"), TextColor = Color.White, VerticalOptions=LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Domestic_Abuse = new Button {  Text = "Domestic", BackgroundColor = Color.FromHex("#31859C"), TextColor = Color.White, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand , FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
             Button Sexual_Abuse = new Button { Text = "Sexual", BackgroundColor = Color.FromHex("#C0504D"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Psychological_Abuse = new Button { Text = "Psychological", BackgroundColor = Color.FromHex("#9BBB59"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Financial_Abuse = new Button { Text = "Financial/Material", BackgroundColor = Color.FromHex("#376092"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
            Button Modern_Slavery = new Button { Text = "Modern Slavery", BackgroundColor = Color.FromHex("#AD1D73"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Discriminatory_Abuse = new Button { Text = "Discriminatory", BackgroundColor = Color.FromHex("#7030A0"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Organisational_Abuse = new Button { Text = "Organisational", BackgroundColor = Color.FromHex("#4BACC6"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Neglect_Abuse = new Button { Text = "Neglect/Acts omission", BackgroundColor = Color.FromHex("#FF5050"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)) };
            Button Self_Neglect = new Button { Text = "Self-neglect", BackgroundColor = Color.FromHex("#731351"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };

            var grid = new Grid
            {
                Padding=10,
                RowSpacing = 5
            };


            grid.Children.Add(Physical_Abuse, 0, 0); // Left, First element 
            grid.Children.Add(Domestic_Abuse, 1, 0); // Right, First element 
            grid.Children.Add(Sexual_Abuse, 0, 1); // Left, Second element 
            grid.Children.Add(Psychological_Abuse, 1, 1); // Right, Second element 
            grid.Children.Add(Financial_Abuse, 0, 2); // Left, Second element 
            grid.Children.Add(Modern_Slavery, 1, 2); // Right, Second element 
            grid.Children.Add(Discriminatory_Abuse, 0, 3); // Left, Second element 
            grid.Children.Add(Organisational_Abuse, 1, 3); // Right, Second element 
            grid.Children.Add(Neglect_Abuse, 0, 4); // Left, Second element 
            grid.Children.Add(Self_Neglect, 1, 4); // Right, Second element 




            if (Device.OS == TargetPlatform.Windows)
            {
               Physical_Abuse.HeightRequest = 90;
               Domestic_Abuse.HeightRequest = 90;
               Sexual_Abuse.HeightRequest = 90;
                Psychological_Abuse.HeightRequest = 90;
               Financial_Abuse.HeightRequest = 120;
               Modern_Slavery.HeightRequest = 90 ;
               Discriminatory_Abuse.HeightRequest = 90;
               Organisational_Abuse.HeightRequest = 90;
               Neglect_Abuse.HeightRequest = 90;
               Self_Neglect.HeightRequest = 90;

            }


            Physical_Abuse.Clicked += Physical_Abuse_Clicked;
            Domestic_Abuse.Clicked +=Domestic_Abuse_Clicked;
            Sexual_Abuse.Clicked += Sexual_Abuse_Clicked;
            Psychological_Abuse.Clicked += Psychological_Abuse_Clicked;
            Financial_Abuse.Clicked += Financial_Abuse_Clicked;
            Modern_Slavery.Clicked += Modern_Slavery_Clicked;
            Discriminatory_Abuse.Clicked += Discriminatory_Abuse_Clicked;
            Organisational_Abuse.Clicked += Organisational_Abuse_Clicked;
            Neglect_Abuse.Clicked += Neglect_Abuse_Clicked;
            Self_Neglect.Clicked += Self_Neglect_Abuse_Clicked;




            Content = new StackLayout { Children = { s, grid } };
            //    grid;
        }
    }
}