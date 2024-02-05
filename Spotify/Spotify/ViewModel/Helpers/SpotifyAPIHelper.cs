using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ViewModel.Helpers
{
    public static class SpotifyAPIHelper
    {
        public static async void RequestAPIKey(string clientID, string clientSecret, SpotifyAPIHandler handler)
        {
            var config = SpotifyClientConfig.CreateDefault();

            var request = new ClientCredentialsRequest(clientID, clientSecret);
            var response = await new OAuthClient(config).RequestToken(request);
            handler.APIKey = response.AccessToken;
        }
    }
}
