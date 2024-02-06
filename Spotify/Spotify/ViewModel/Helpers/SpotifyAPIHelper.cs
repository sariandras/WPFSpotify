using Newtonsoft.Json;
using Spotify.Model;
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
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", clientID),
                new KeyValuePair<string, string>("client_secret", clientSecret)
            });
            using var client = new HttpClient();
            using var response = await client.PostAsync("https://accounts.spotify.com/api/token", content);

            string responseBody = await response.Content.ReadAsStringAsync();
            handler.APIKey = responseBody.Split('"')[3];
            Debug.WriteLine(handler.APIKey);

            RequestArtist(handler);
        }

        public static async void RequestArtist(SpotifyAPIHandler handler)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {handler.APIKey}");

            using var response = await client.GetAsync($"https://api.spotify.com/v1/artists/{handler.ArtistID}");

            string responseBody = await response.Content.ReadAsStringAsync();
            Artist ajtiszt = JsonConvert.DeserializeObject<Artist>(responseBody);
            handler.Taylor = ajtiszt;
        }
    }
}
