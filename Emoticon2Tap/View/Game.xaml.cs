using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using Emoticon2Tap.Model;
using System.Windows.Media.Imaging;
using Windows.UI.Popups;
using Emoticon2Tap.Model;
using Emoticon2Tap.ViewModel;
namespace Emoticon2Tap.View
{
    public partial class Game : PhoneApplicationPage
    {
        private DispatcherTimer timer;
        private int timetoTick = 0;
        public int timeTicked = 60;
        private int score = 0;
        private Images ig;
        public String im;
        public  int gettime;
        DataHelpersClass dhc = new DataHelpersClass();
        // public string time



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string name = string.Empty ;
            string time = string.Empty;
            //gettime = Convert.ToInt16(NavigationContext.QueryString["time"]);
            //if (e.IsNavigationInitiator == true) {
            //    gettime = Convert.ToInt16(NavigationContext.QueryString["time"]);
            //}
            //else
            //{
            //    gettime = 60;
            //}
            GettimeSetting(gettime);
            //string level = NavigationContext.QueryString["level"];
            // lblTimer.Text = timeTicked.ToString();
            if (NavigationContext.QueryString.TryGetValue("name", out name) && NavigationContext.QueryString.TryGetValue("time", out time)) 
            {
                txtPlayer.Text = name;
                gettime = Convert.ToInt16(time);
            }

            else
            {
                gettime = 60;
            }

        }


        private static String[] images =
       {
            "01.png", "02.png", "03.png" , "04.png" , "05.png" , "06.png" , "07.png" ,
            "08.png","09.png","10.png","11.png","12.png","13.png","14.png","15.png",
            "16.png","17.png","18.png","19.png","20.png","21.png","22.png","23.png",
            "24.png","25.png","26.png","27.png","28.png","29.png","30.png","31.png",
            "32.png","33.png","34.png","35.png","36.png"
        };

        public static string RandomImage()
        {
            String im;
            im = images[new Random().Next(0, images.Length)];
            return im;
        }

        public void TimerSetup()
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 350);
            timer.Start();
        }

        public int InitTimeTicked ()
        {
           int timeTicked = GettimeSetting(gettime);
            return timeTicked;
        }

        

        void Timer_Tick(object sender, object e)
        {
           //timeTicked = InitTimeTicked();
            //timeTicked = GettimeSetting(gettime);
            // timeTicked = Convert.ToInt16(lblTimer.Text);
           
            lblTimer.Text = timeTicked.ToString();
            //im = images[new Random().Next(0, images.Length)];
            Emoji.Source = new BitmapImage(new Uri("/Assets/" + RandomImage(), UriKind.RelativeOrAbsolute));

            if (timeTicked <= timetoTick)
            {
                timer.Stop();
                if (MessageBoxResult.OK == MessageBox.Show("Time End!! \n Your Score " + txtScore.Text + "", "Are you want save Score?", MessageBoxButton.OKCancel))
                {
                    dhc.Insert(new Score(Convert.ToInt16(txtScore.Text), txtPlayer.Text));
                    MessageBox.Show("Save!!");
                }
                //btnStart.IsHitTestVisible = false;
                Emoji.IsHitTestVisible = false;

            }
            timeTicked--;
            //throw new NotImplementedException();
        }

        public int ScoreInit()
        {
            score = 0;
            switch (RandomImage())
            {
                case "01.png":
                    score += 20;
                    break;

                case "02.png":
                    score += -30;
                    break;

                case "03.png":
                    score += -5;
                    break;

                case "04.png":
                    score += -10;
                    break;

                case "05.png":
                    score += 5;
                    break;

                case "06.png":
                    score += (-10);
                    break;

                case "07.png":
                    score += (-5);
                    break;

                case "08.png":
                    score += (-5);
                    break;

                case "09.png":
                    score += 25;
                    break;


                case "10.png":
                    score += 15;
                    break;


                case "11.png":
                    score += 30;
                    break;

                case "12.png":
                    score += 10;
                    break;

                case "13.png":
                    score += -1;
                    break;

                case "14.png":
                    score += -40;
                    break;

                case "15.png":
                    score += 20;
                    break;

                case "16.png":
                    score += 30;
                    break;

                case "17.png":
                    score += 0;
                    break;

                case "18.png":
                    score += 1;
                    break;

                case "19.png":
                    score += 20;
                    break;

                case "20.png":
                    score += 35;
                    break;

                case "21.png":
                    score += 25;
                    break;

                case "22.png":
                    score += 50;
                    break;

                case "23.png":
                    score += 25;
                    break;

                case "24.png":
                    score += -35;
                    break;

                case "25.png":
                    score += -10;
                    break;

                case "26.png":
                    score += 30;
                    break;

                case "27.png":
                    score += 20;
                    break;

                case "28.png":
                    score += 40;
                    break;

                case "29.png":
                    score += 40;
                    break;

                case "30.png":
                    score += 45;
                    break;

                case "31.png":
                    score += 0;
                    break;

                case "32.png":
                    score += 35;
                    break;

                case "33.png":
                    score += -15;
                    break;

                case "34.png":
                    score += -30;
                    break;

                case "35.png":
                    score += -45;
                    break;

                case "36":
                    score += -20;
                    break;
            }
            return score;
        }

        public Game()
        {
            InitializeComponent();
            //TimerSetup();
            string name = string.Empty;
            //if (NavigationContext.QueryString.TryGetValue("name", out name))
            //{
            //    txtPlayer.Text = name;
            //}

        }

        private static int  GettimeSetting( int timesetting)
        {
            return timesetting;
        }

        private async void Emoticon_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //TimerSetup();
           
            
            txtScore.Text = "0";
            txtScore.Text = ScoreInit().ToString();

            if (RandomImage() == "02.png" || RandomImage() == "07.png" || RandomImage() == "35.png" || timeTicked == timetoTick) 
            {

                timer.Stop();
                //MessageBox.Show("Your Dead!! \n Your Score is: " + txtScore.Text);
                if (MessageBoxResult.OK== MessageBox.Show("Your Dead!! \n Your Score "+txtScore.Text+"", "Are you want save Score?", MessageBoxButton.OKCancel))
                {
                    dhc.Insert(new Score(Convert.ToInt16(txtScore.Text) ,txtPlayer.Text));
                    MessageBox.Show("Save!!");
                }
                Emoji.IsHitTestVisible = false;
            }
            //playername.IsHitTestVisible = false;
            //if (btnStart.IsHitTestVisible == false ||
            //Emoji.IsHitTestVisible == false)
            //{
            //    //playername.IsHitTestVisible = true;
            //}
        }

       

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Settings.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // 
            NavigationService.Navigate(new Uri("/View/Game.xaml", UriKind.RelativeOrAbsolute));

        }

        private void DoubleTap_Start(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (timeTicked == 60 || timeTicked <= timetoTick)
            {
                TimerSetup();
            }
            else
            {
                btnStart.IsHitTestVisible = false;
            }
        }
    }
}