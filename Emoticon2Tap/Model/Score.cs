﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sqlite;
namespace Emoticon2Tap.Model
{
  public class Score
    {
       [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }
        public int score { get; set; }
        public string player { get; set; }

        public string playdate { get; set; }

        public Score() { }
        public Score(int score, string player, string playdate) {
            this.score = score;
            this.player = player;
            //this.Datetime = datetime
            this.playdate = playdate;
        }
    }
}
