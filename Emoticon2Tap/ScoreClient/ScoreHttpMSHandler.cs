using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Emoticon2Tap.Model;
using Newtonsoft.Json;
namespace Emoticon2Tap.ScoreClient
{
   public class ScoreHttpMSHandler:HttpClientHandler
    {
        public static bool ShowKittens { get; set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
            if (!ShowKittens ||
              request.Method != HttpMethod.Get ||
              !request.RequestUri.OriginalString.EndsWith("1"))
                return base.SendAsync(request, cancellationToken);

            var scoreinfo = new Score();
            scoreinfo.Id = 1;
            scoreinfo.score = 1;
            scoreinfo.player = "Player";

            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            var json = JsonConvert.SerializeObject(scoreinfo);
            response.Content = new StringContent(json);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/json");
            return Task.FromResult(response);
        }
    }
}
