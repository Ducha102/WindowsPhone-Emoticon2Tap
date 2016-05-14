using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;

namespace Emoticon2Tap.ViewModel
{
  public class DataHelpersClass
    {
        SQLiteConnection conn;


        public async Task<bool> CheckFile (string filename)
        {
            try
            {
                var storage = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(filename);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }

        public async Task<bool> CreateDB (string dbPath)
        {
            try
            {
                if (!CheckFile(dbPath).Result)
                {
                    using (conn = new SQLiteConnection(dbPath))
                    {
                        conn.CreateTable<Model.Score>();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                //throw;
                return false;
            }
        }


        public ObservableCollection<Model.Score> SelectScore ()
        {
            using (var conn = new SQLiteConnection(App.db_path))
            {
                List<Model.Score> listscore = conn.Table<Model.Score>().ToList<Model.Score>();
                ObservableCollection<Model.Score> scores = new ObservableCollection<Model.Score>(listscore);
                return scores;
             }
        }

        public void Insert (Model.Score newscore)
        {
            using (conn = new SQLiteConnection(App.db_path))
            {
                conn.RunInTransaction(() => {
                    conn.Insert(newscore);
                });
            }
        }
    }
}
