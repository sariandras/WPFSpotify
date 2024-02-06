using Spotify.Model;
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

        public string ArtistID { get; set; } = "06HL4z0CvFAxyc27GXpf02";
        private Artist taylor;

        public Artist Taylor
        {
            get { return taylor; }
            set { taylor = value; OnPropertyChanged(nameof(Taylor)); }
        }

        public SpotifyAPIHandler()
        {
            taylor = new();
            GetAPIKey = new Authenticate(this);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
