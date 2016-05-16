using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Emoticon2Tap.Resources;
using Emoticon2Tap.GoogleAuth;
namespace Emoticon2Tap
{
    public partial class MainPage : PhoneApplicationPage
    {
        public static string GoogleClientId = "594793876729-q9a61764k2dq7t4ggc3hceircufqquu9.apps.googleusercontent.com";
        public static string GoogleClientSecret = "CJmOh2h3ROWdWmvuw4NRXo4U";
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private async void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.loggedin)
            {
                OAuthAuthorization authorization = new OAuthAuthorization(
                "https://accounts.google.com/o/oauth2/auth",
                "https://accounts.google.com/o/oauth2/token");
                TokenPair tokenPair = await authorization.Authorize(
                    GoogleClientId,
                    GoogleClientSecret,
                    new string[] { GoogleScope.UserinfoEmail });

       
                TokenPair refreshTokenPair = await authorization.RefreshAccessToken(
                    GoogleClientId,
                    GoogleClientSecret,
                    tokenPair.RefreshToken);
            }
        }

        private void NG_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //NavigationService.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
            NavigationService.Navigate(new Uri("/View/Game.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Score_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        }

        private void Setting_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {

            NavigationService.Navigate(new Uri("/View/HighScore.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Guide_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Guide.xaml", UriKind.RelativeOrAbsolute));
        }


        //public List<string> GetGoogleUserInfo()
        //{
        //    List<string> UserInfo = new List<string>();
        //    UserInfo.Add(GoogleScope.UserinfoProfile);
        //}


        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/View/Game.xaml", UriKind.RelativeOrAbsolute));
        //}


        // private async void Layout_Loaded 
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}