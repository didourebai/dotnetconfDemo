using System;
using DotnetConfSample.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DotnetConfSample.Models;
using DotnetConfSample.ViewModels;
using Xamarin.Essentials;

namespace DotnetConfSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private void Save_OnClicked(object sender, EventArgs e)
        {
            //Settings.GeneralSettings = MyName.Text;
            Preferences.Set("MyName", MyName.Text);
            Navigation.PushModalAsync(new NavigationPage(new AboutPage()));
        }
    }
}