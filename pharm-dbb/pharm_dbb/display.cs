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




    public class d : ContentPage
    {

        Button home;
        Button back;

        private string sp;
        private string t;
        private string yesnext;
        private string nonext;
        String _BGColor;



        void OnnoButton1Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:0300 123 4042"));
        }
        void OnnoButton2Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:0300 777 0707"));
        }

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
            while (page.Navigation.NavigationStack.Count>1)
            { page.Navigation.PopAsync(); }

         


        }
      



        public d(string startpage, String Titles, String BGColor)
        {

            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
    
            BackgroundColor = Color.FromHex("#FCDED4");

         
            sp = startpage;

                List<Pages> pages = new List<Pages>();

                pages.Add(new Pages {title="Definition adult at risk" ,description = "According to The Care Act (2014), an adult at risk is an person who:  <p><div style='border-radius: 20px 20px 20px 20px;background-color:#D16460; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '><p>Has care and support needs, whether or not the Local Authority e.g. Hertfordshire County Council (HCC) is meeting any of those needs <b>And;</b></div> <p> <div style='border-radius: 20px 20px 20px 20px;background-color:#A03E3C; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '>Is experiencing, or at risk of, abuse or neglect; <b>And</b> </div><p> <div style='border-radius: 20px 20px 20px 20px;background-color:#8F4E4D; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '> As a result of those care and support needs is unable to protect themselves from abuse or neglect or the risk of it.</div>", id = "1" });
                pages.Add(new Pages { title="What is Safeguarding?",description = "Safeguarding means protecting an adult's right to live in safety, free from abuse and neglect. Stop abuse or neglect where possible. Prevent harm and reduce the risk of abuse or neglect in a way that supports them in making choices and having control about how they want to live. Raise public awareness to enable communities as a whole, together with professionals, help to prevent, identify and respond to abuse and neglect.", id = "2" });
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Physical Abuse</h3> Include assault, hitting, slapping, pushing, misusing medication, restraint or inappropriate physical sanctions.", id = "3", yesbutton = "2", nobutton = "1", yesnext = "17", nonext = "6" });
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Domestic Abuse</h3> Psychological, physical, sexual, financial, emotional abuse and so called 'honour based' abuse.", id = "4",yesbutton="2", yesnext="17" });
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Sexual abuse</h3> Include rape, indecent exposure, sexual harassment, inappropriate looking or touching, sexual teasing or innuendo, sexual photography, subjection to pornography or witnessing sexual acts, sexual assault or sexual acts to which the adult has not consented or was pressured into consenting.", id = "5", yesbutton = "2", nobutton = "2", yesnext = "17", nonext = "8" });
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Psychological abuse</h3> Includes emotional abuse, threats of harm or abandonment, humiliation, blaming, controlling, intimidation, coercion, harassment, verbal abuse, cyber bullying, isolation or unreasonable and unjustified withdrawal of service or supportive networks. <p/> * Individuals who are susceptible to radicalisation (within the Prevent agenda) may also be considered in this category.", id = "6" ,yesbutton="2",yesnext="17"});
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Financial or material abuse</h3> Includes theft, fraud, internet scamming, coercion in relation to an adult's financial affairs or arrangement, including in connection with wills, property, inheritance or financial transactions, or the misuse or misappropriation of property, possessions or benefits.", id = "7", yesbutton = "2",nobutton="1", yesnext = "17" ,nonext="11"});
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Modern Slavery</h3> Encompasses slavery, human trafficking, forced labour and domestic servitude. Traffickers and slave masters use whatever means they have at their disposal to coerce, deceive and force individuals into a life of abuse, servitude and inhumane treatment.", id = "8",yesbutton="2",yesnext="17" });
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Discriminatory abuse </h3>Includes forms of harassment, slurs or similar treatment because of race, gender and gender identity, age, disability, sexual orientation or religion.", id = "9", yesbutton = "2", nobutton = "2", yesnext = "17", nonext = "12" });
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Organisational abuse </h3>Includes neglect and poor practice within an institution or specific care setting such as a hospital or care home, or in relation to care provided in one's own home. This may range from one off incidents to ongoing ill-treatment. It can be through neglect or poor professional practice as a result of the structure, policies, processes and practices within an organisation.", id = "10" ,yesbutton="2",yesnext="17"});
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Neglect and acts of omission</h3> Includes ignoring medical, emotional or physical care needs, failure to provide access to appropriate care and support or educational services, withholding the necessities of life such as medication, adequate nutrition and heating.", id = "11", yesbutton = "2", nobutton = "1", yesnext = "17", nonext = "14" });
                pages.Add(new Pages { title = "Categories of abuse", description = "<h3 style='color:#D16460'>Self-neglect</h3> This covers a wide range of behaviour such as neglecting to care for one's personal hygiene, health or surroundings and includes behaviours such as hoarding. <p> *For more advice on hoarding - contact your local District Borough Council", id = "12", yesbutton = "2", yesnext = "17" });
                pages.Add(new Pages {title="Recognising abuse", description = "<b>Risk<b/> <br/> is not in itself a safeguarding issue, as not all risks will result in a negative impact on the individual. <b>Frequency<b/> <p> Abuse may be an isolated incidentor multiple, affecting one or more people. <b>Harm<b/> <p> Harm should be taken to include not only ill treatment but also the impairment of, or avoidable deterioration in, physical or mental health and the impairement of physical, intellectual, emotional, social or behavioural development. ", id="14", yesbutton = "1", nobutton = "1", yesnext = "50", nonext = "16" });
                pages.Add(new Pages { title = "Recognising abuse", description = "You may notice signs that someone is being abused. <p><b>Personal hygiene</b> They may not take as much care as normal with their appearance, such as not bathing, shaving or washing their hair. Behaviour. They may become withdrawn, depressed or tearful. They may also be angry or aggressive for little reason. They may have unexplained or frequent injuries. They may stop going out, not having any money to buy food or access leisure services, not want to be left alone with certain people, or lose their appetite. ", id = "50"});
                pages.Add(new Pages {title="Reporting a concern", description = "<h3>Reporting a concern</h3> <p><b> The safeguarding concern may be disclosed, witnessed or suspected.</b><p color:'#Ad1D73'> It is your duty under the Care Act (2014) to comply with the following 4 step process:</p><p><b> 1. Assess the risk</b><p> If the person is in immediate danger and a crime has been committed contact the <b>Police</b> on <b>999</b> or <b>101</b> if there is no immediate risk.", id = "17", yesbutton = "1", nobutton = "1", yesnext = "18" });
                pages.Add(new Pages { title = "Reporting a concern", description = "<h3>Reporting a concern</h3><p><b>2. Complete the HSAB Safeguarding Adult concern form.</b></p> <p> The alerter must raise a safeguarding concern to the <b>Local Authority</b> (Health and Community Services) on 0300 123 4042 and follow up in writing using the Safeguarding Adult concern form", id = "18", yesbutton = "1", yesnext = "19" ,nobutton="1"});
                pages.Add(new Pages { title = "Reporting a concern", description = "<h3>Reporting a concern</h3><p><b>3. Mental Health considerations</b> </p><p> If the person is under 65 and receiving Mental Health Services, any safeguarding concerns should be raised directly to Hertfordshire Partnership Foundation NHS Trust on 0300 7770707.", id = "19",yesbutton="1",yesnext="20",nobutton="2" });
                pages.Add(new Pages { title = "Reporting a concern", description = "<h3>Reporting a concern</h3><b>4. Remember to:</b> <p> Make a clear, concise, factual referral so that the person receiving the form understand the key issues. <p>Follow your own agency's Safeguarding Policy and the HSAB Safeguarding Adults Policy. <p> Make a referral to Safeguarding Children where necessary: Safeguarding Children referral form. <p><font color='red'><b>You are accountable for what you do and what you choose not to do.</b></font>", id = "20", nobutton = "0", yesbutton = "9", yesnext = "22" });
                pages.Add(new Pages {title="Making Safeguarding Personal", description = "<div style='padding:5px 5px 5px 5px;background-color:#731351; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '> Making safeguarding personal is a shift in culture and professional practice.</div><br/><div style='background-color:#7D4D68; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '><br/> It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety.</div><br/><div style='background-color:#7030A0; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '> It is about empowering the adult at risk to ensure that their wishes/ desired outcomes are considered as part of the safeguaridng process.</div><br/><div style='background-color:#731351; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '> It is about seeing people as experts in thie own lives and working alongside them.</div><br/><div style='background-color:#7D4D68; color: white; vertical-align: middle; padding: 10px 10px 10px 10px; '> The alerter must note the person's wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority.</div>", id = "21" });
   


            string      yesenabled = "";
              string   noenabled = "";
            string     printout = "";
                foreach (var p in pages)
                {
                    if (p.id == startpage)
                    {
                        yesnext = p.yesnext;
                        nonext = p.nonext;
                        yesenabled = p.yesbutton;
                        noenabled = p.nobutton;
                        printout = p.description;
                    Title = p.title;
                    }

                };
            
             Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), Text = "Next", IsVisible = false, Image = "tick", BackgroundColor = Color.FromHex("#953735"),TextColor=Color.White };
            yes.Image = (FileImageSource)ImageSource.FromFile("tick.png");
            Button no = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), Text = "Back", IsVisible = false, Image = "cross", BackgroundColor = Color.FromHex("#bfbfbf"),TextColor=Color.White };
            no.Image = (FileImageSource)ImageSource.FromFile("cross.png");

            var output2 = new WebView();

            output2.HeightRequest = 600;


            if (yesenabled == "1")
            {
                yes.IsVisible = true;
                yes.HeightRequest = 55;
                output2.HeightRequest = 320;
            }
            if (yesenabled == "2")
            {
                yes.Text = "Suspected";
                yes.IsVisible = true;
                yes.HeightRequest = 55;
                output2.HeightRequest = 320;
            }

            if (noenabled=="1")
            {
                no.IsVisible = true;
                no.Text = "Call 0300 123 4042";
                no.Clicked += OnnoButton1Clicked;

            }
            if (noenabled =="2")
            {
                no.IsVisible = true;
                no.Text = "Call 03007770707";
                no.Clicked += OnnoButton2Clicked;

            }
            no.HeightRequest = 60;
             yes.Clicked += OnyesButtonClicked;
        
            var output1   = new Label();
     
          
             var htmlSource = new HtmlWebViewSource();
           
            //   htmlSource.Html = "<div style='background-color:transparent;padding:5px;width=100%;font-size:20px'>" + k.Description + "</div><div style=';padding:5px;width=100%;'></div><p>";
            htmlSource.Html = "<HTML><body style ='background-color:#FCDED4;'><div style='background-color:#FCDED4;width=100%;font-size:18px;font-family:calibri;color:#a51b26'>" + printout + "</div><div width=100%;'></body></html>";
             output2.WidthRequest = 500;
            output2.Source = htmlSource;
 
            var x = new StackLayout
            {
               BackgroundColor=Color.FromHex("#FCDED4"),

                Padding = new Thickness(10, 10, 10, 10),
                Children = {

                    //     header,
                    //         picker,
                    //       boxView1,
                    
                    output2,
                    no,
                    yes,
                }
            };


            Content = new ScrollView { BackgroundColor = Color.FromHex("#FCDED4"),
            Content = x };
                


        }
    }
}
