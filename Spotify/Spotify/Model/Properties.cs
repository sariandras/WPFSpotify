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
    public class Image
    {
        public string? Url { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
