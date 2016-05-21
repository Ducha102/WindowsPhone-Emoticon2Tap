using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Emoticon2Tap.ScoreClient;
using Emoticon2Tap.Model;

namespace Emoticon2Tap
{
    public partial class ScoreCenter : PhoneApplicationPage
    {
        public ScoreCenter()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            List<Score> list;
            base.OnNavigatedTo(e);
            try
            {
                list = await ScoreClient.ScoreClient.GetAllAsync();
                listboxCenter.ItemsSource = list.OrderByDescending(i => i.score);
            }
            catch (Exception)
            {

                //throw;
                MessageBox.Show("Sorry! No Connection to GameCenter");
            }
        }

       
    }
}