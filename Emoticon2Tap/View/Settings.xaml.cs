using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Emoticon2Tap.View
{
    public partial class Settings : PhoneApplicationPage
    {
        public Settings()
        {
            InitializeComponent();
            string[] speedname = {"Slow","Medium","Fast"};
            int[] speed = { 150,350,600};

            pkSpeed.ItemsSource = speedname;
            for (int i = 0; i < speed.Length; i++)
            {
                pkSpeed.SelectedIndex = i;
            }
            pkSpeed.UpdateLayout();
        }

        private void Save_Change(object sender, RoutedEventArgs e)
        {
          
            string content= "";
            if (txtPlayer.Text != null)
            {

                NavigationService.Navigate(new Uri("/View/Game.xaml?name=" + txtPlayer.Text + "&time=" + slideTime.Value+"&level="+ content, UriKind.RelativeOrAbsolute));
                MessageBox.Show("Save Changed!!");
            }
            else
            {
                MessageBox.Show("Please Provide Play Name!");
            }
            
        }

        private void slideTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int step = 30;
            (sender as Slider).Value = (e.NewValue % step != 0) ? (step - e.NewValue % step) + e.NewValue : e.NewValue;
        }
    }
}