using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using Emoticon2Tap.ViewModel;
namespace Emoticon2Tap.View
{
    public partial class HighScore : PhoneApplicationPage
    {
        ObservableCollection<Model.Score> db_score = new ObservableCollection<Model.Score>();
        public HighScore()
        {
            InitializeComponent();
        }

        private void listboc(object sender, RoutedEventArgs e)
        {
            ReadScores rs = new ReadScores();
            db_score = rs.ReadAllScore();
            listboxscore.ItemsSource = db_score.OrderByDescending(i => i.score).ToList();
        }
    }
}