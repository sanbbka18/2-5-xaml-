using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.forms1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        
  


        public Page1()
        {
            InitializeComponent();
        }
        private void Button_clicked(object sender, EventArgs e)
        {
            Label1.Text = Entry1.Text;
        }

        private async void Play_Clicked(object sender, EventArgs e)
        {
            // MainPage = new Level(); так не работает
            await Navigation.PushAsync(new Level());
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}