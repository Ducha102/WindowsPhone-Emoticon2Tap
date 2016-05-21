using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Emoticon2Tap.Model;
namespace Emoticon2Tap.ScoreClient
{
  public static class ScoreClient
    {
        public static readonly HttpClient client;
        public static Uri ApiBaseUri {
          get{ return new Uri("http://localhost:55642/api/Scores"); }
        }

        static ScoreClient() {
            client = new HttpClient(new ScoreHttpMSHandler());
        }

        //GET All Score API
        public static async Task<List<Score>> GetAllAsync()
        {
            var response = await client.GetAsync(new Uri(ApiBaseUri, "Scores"));
            var scores = await response.Content.ReadAsAsync<List<Score>>();
            return scores;
        }

        public static async Task<List<Score>> QueryAsync(string player)
        {
            var url = string.Format("Scores?player={0}", Uri.EscapeDataString(player));
            var response = await client.GetAsync(new Uri(ApiBaseUri, url));
            var scores = await response.Content.ReadAsAsync<List<Score>>();
            return scores;
        }


        public static async Task<Score> SaveAsync(Score score)
        {
            var response = await client.PostAsJsonAsync(new Uri(ApiBaseUri, "Scores"), score);
            score = await response.Content.ReadAsAsync<Score>();
            return score;
        } 


    }
}
