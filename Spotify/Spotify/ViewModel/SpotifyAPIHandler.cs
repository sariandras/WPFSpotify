using Spotify.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ViewModel
{
    public class SpotifyAPIHandler
    {
        public Authenticate GetAPIKey { get; set; }
        public string? APIKey { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
        public SpotifyAPIHandler()
        {
            GetAPIKey = new Authenticate(this);
        }
    }
}
