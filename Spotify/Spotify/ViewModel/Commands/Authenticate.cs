using Spotify.ViewModel.Helpers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Spotify.ViewModel.Commands
{
    public class Authenticate : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        SpotifyAPIHandler handler;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            SpotifyAPIHelper.RequestAPIKey(handler.ClientID, handler.ClientSecret, handler);
        }

        public Authenticate(SpotifyAPIHandler handler)
        {
            this.handler = handler;
        }
    }
}
