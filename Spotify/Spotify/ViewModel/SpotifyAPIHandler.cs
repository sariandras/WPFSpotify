using Spotify.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ViewModel
{
    public class SpotifyAPIHandler : INotifyPropertyChanged
    {
        public Authenticate GetAPIKey { get; set; }
        public string? APIKey { get; set; }
        public string ClientID { get; set; } = "32dd7535aabd44b3a88f135db4bbad8a";
        public string ClientSecret { get; set; } = "47fe45d514c84f9ab2201b394911c6da";
        public SpotifyAPIHandler()
        {
            GetAPIKey = new Authenticate(this);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
