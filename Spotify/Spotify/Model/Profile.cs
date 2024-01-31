using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Model
{
    // https://api.spotify.com/v1/me
    public class ExplicitContent
    {
        public bool FilterEnabled { get; set; }
        public bool FilterLocked { get; set; }
    }

    public class Profile
    {
        public string? Country { get; set; }
        public string? DisplayName { get; set; }
        public string? Email { get; set; }
        public ExplicitContent? ExplicitContent { get; set; }
        public ExternalUrls? ExternalUrls { get; set; }
        public Followers? Followers { get; set; }
        public string? Href { get; set; }
        public string? Id { get; set; }
        public List<Image>? Images { get; set; }
        public string? Product { get; set; }
        public string? Type { get; set; }
        public string? Uri { get; set; }
    }
}
