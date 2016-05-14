using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoticon2Tap.ViewModel
{
    class ReadScores
    {
        DataHelpersClass dbHelp = new DataHelpersClass();
        public ObservableCollection<Model.Score> ReadAllScore()
        {
            return dbHelp.SelectScore();
        }
    }
}
