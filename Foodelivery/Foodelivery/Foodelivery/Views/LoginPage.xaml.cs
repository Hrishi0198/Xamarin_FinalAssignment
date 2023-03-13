using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Foodelivery.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new LoginPageModel();

            if (Device.RuntimePlatform == Device.iOS)
            {
                user.TextColor = Color.Black;
            }
            else
            {
                user.TextColor = Color.Black;
            }
        }
    }
}

