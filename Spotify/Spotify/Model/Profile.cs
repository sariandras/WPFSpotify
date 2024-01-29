using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Model
{
    public class ExternalUrls
    {
        public string? Spotify { get; set; }
    }
    public class Followers
    {
        public string? Href { get; set; }
        public int Total { get; set; }
    }
    public class ProfileImage
    {
        public string? Url { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public class Profile
    {
        public string? DisplayName { get; set; }
        public Followers? Followers { get; set; }
        public ExternalUrls? ExternalUrls { get; set; }
        public string? Href { get; set; }
        public string? Id { get; set; }
        public List<ProfileImage>? Images { get; set; }
        public string? Type { get; set; }
        public string? Uri { get; set; }
    }
}
