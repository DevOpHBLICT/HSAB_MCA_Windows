using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace SAFA
{
    public class App : Application
    {
        public static string data;
        public static string version_no;
        public static string current_version;
        public static int loaded;
        public static int Network_Connection;
        public static List<Pages> pages = new List<Pages>();

        public static String app_title { get; set; }

        public static NavigationPage NavPage { get; set; }
        public NavigationPage nav;
        public void Home_Clicked(object sender, EventArgs args)
        {
            if ((Device.OS == TargetPlatform.WinPhone) || (Device.OS == TargetPlatform.Windows))
            {

                var page = nav.Navigation.NavigationStack.First();

                while (page.Navigation.NavigationStack.Count > 1)
                {
                    page.Navigation.PopAsync();
                }
            }
            else
            { nav.PopToRootAsync(); }


            // Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PopToRootAsync());
        }
        public void Back_Clicked(object sender, EventArgs args)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PopAsync());
        }



        public App()
        {
            nav = new NavigationPage(new Contents());
            nav.BarTextColor = Color.White;
            nav.BackgroundColor = Color.White;
            nav.BarBackgroundColor = Color.FromHex("1760ae");

            ToolbarItem tbbSync = new ToolbarItem() { Icon = "homee.png" };
            tbbSync.Text = "Home";
            tbbSync.Clicked += Home_Clicked;
            tbbSync.Order = Device.OnPlatform(ToolbarItemOrder.Primary, ToolbarItemOrder.Primary, ToolbarItemOrder.Primary);
            nav.ToolbarItems.Add(tbbSync);

            ToolbarItem tbbSettings = new ToolbarItem() { Icon = "back.png" };
            tbbSettings.Text = "Back";
            tbbSettings.Clicked += Back_Clicked;
            tbbSettings.Order = Device.OnPlatform(ToolbarItemOrder.Primary, ToolbarItemOrder.Primary, ToolbarItemOrder.Primary);
            nav.ToolbarItems.Add(tbbSettings);




        
        MainPage = nav;

        }

     


        async static void GetOnlineData()
        {
            MovieCollection res = new MovieCollection();
            const string fileName = "Mental_Capacity.txt";
            var fileService = DependencyService.Get<ISaveAndLoad>();
           data = "";
            try
            {
                string Url = String.Format("https://onedrive.live.com/download?cid=2B765942C77D4869&resid=2B765942C77D4869%21173&authkey=ADv_kBeaPSLyM70");
                HttpClient hc = new HttpClient();
              
               data= await hc.GetStringAsync(Url);
                Network_Connection = 1;
             
            }
            catch (System.Exception sysExc)
            {
                Network_Connection = 0;
              
            }
            // Parse JSON into dynamic object, convenient! 
            JArray results = JArray.Parse(data);

            foreach (JObject o in results.Children<JObject>())
            {
                string id = "";
                string description = "";
                string yesbutton = "";
                string nobutton = "";
                string yesnext = "";
                string nonext = "";

                foreach (JProperty p in o.Properties())
                {
                    string name = p.Name;
                    if (name == "description")
                    {
                        description = (string)p.Value;
                    }
                    if (name == "id")
                    {
                        id = (string)p.Value;
                    }
                    if (name == "yesbutton")
                    {
                        yesbutton = (string)p.Value;
                    }
                    if (name == "nobutton")
                    {
                        nobutton = (string)p.Value;
                    }
                    if (name == "yesnext")
                    {
                        yesnext = (string)p.Value;
                    }
                    if (name == "nonext")
                    {
                        nonext = (string)p.Value;
                    }

                    pages.Add(new Pages { description = description, id = id, yesbutton = yesbutton, nobutton = nobutton, yesnext = yesnext, nonext = nonext });

                }




            }
            loaded = 1;
        }




        public static ListView p;


        async static void CheckVersion()
        {

            var fileService = DependencyService.Get<ISaveAndLoad>();
            var i = "";
          
                string Url = String.Format("https://onedrive.live.com/download?cid=2B765942C77D4869&resid=2B765942C77D4869%21173&authkey=ADv_kBeaPSLyM70");
                HttpClient hc = new HttpClient();
           
               version_no = await hc.GetStringAsync(Url);

            i = version_no;
        }
        async static void SaveOnlineData()
        {
            var fileService = DependencyService.Get<ISaveAndLoad>();
            await fileService.SaveTextAsync("Mental_Capacity.txt", data);
        }

        async static void LoadCurrentData()
        {

            var fileService = DependencyService.Get<ISaveAndLoad>();
            current_version = await fileService.LoadTextAsync("Mental_Capacity_Version.txt");
        }
            async static void CheckCurrentVersion()
        {
            var fileService = DependencyService.Get<ISaveAndLoad>();
            try
            {
                current_version = await fileService.LoadTextAsync("Mental_Capacity_Version.txt");
            }catch
            {
                current_version = "0";
            }
        }
     
        protected override void OnStart()
        {
        //    CheckCurrentVersion();

        //    CheckVersion();


        //    if (Convert.ToInt32(version_no) > Convert.ToInt32(current_version))
        //    {
        //        GetOnlineData();
        //    }

               
        //    SaveOnlineData();

           
            var st = "\t\u2022 This app has been developed by the Hertfordshire Safeguarding Adults Board (HSAB) ";
            st = st + "It is to be used for guidance and information only\r\n";
            st = st + "\t\u2022 Click on each button and information section to see more guidance\r\n ";
    
            var answer =  App.Current.MainPage.DisplayAlert("Disclaimer", st, "I agree");
            // Handle when your app starts
        }




        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
    }
}