using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin.forms1
{
    public class _1 : ContentPage
    {
        public _1()
        {
            Entry Entry1 = new Entry
            {
                Placeholder = "Write",
                TextColor = Color.Brown
            };
            Button Button1 = new Button()
            {
                Text = "Tap"
            };

            Content = new StackLayout
            {
                Children = { Entry1, Button1 }
            };
        }
    }
}