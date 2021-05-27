using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.forms1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new Page1();
            //MainPage = _1;
            //MainPage =  ;
            MainPage = new NavigationPage(new Xamarin.forms1.Page1());

        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
