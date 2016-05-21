using Emoticon2Tap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace Emoticon2Tap.ScoreClient
{
    public class ScoreStateChangedEventArgs:EventArgs
    {
        public Score item { get; private set; }
        public ScoreStateChangedEventArgs(Score score)
        {
            item = score;
        }



    }

   public sealed partial class ScoreDetail : UserControl
    {
        private bool isnewscore;

        public bool IsNewScore
        {
            get { return isnewscore; }
            set {
                

                isnewscore = value;
                }
        }


        public ScoreDetail() {
            //  this.I
            DataContext = new Score();
            //IsNewItem = false;
        }
    }
}
