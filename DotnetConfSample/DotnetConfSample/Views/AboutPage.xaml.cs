using System;
using DotnetConfSample.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DotnetConfSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            //NameSaved.Text = Settings.GeneralSettings;
             
            NameSaved.Text = Preferences.Get("MyName", "default_value");


        }
    }
}