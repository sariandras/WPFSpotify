using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Model
{
    public class Item
    {
        public ExternalUrls? ExternalUrls { get; set; }
        public Followers? Followers { get; set; }
        public List<string>? Genres { get; set; }
        public string? Href { get; set; }
        public string? Id { get; set; }
        public List<Image>? Images { get; set; }
        public string? Name { get; set; }
        public int Popularity { get; set; }
        public string? Type { get; set; }
        public string? Uri { get; set; }
    }

    public class TopItems
    {
        public string? Href { get; set; }
        public int Limit { get; set; }
        public string? Next { get; set; }
        public int Offset { get; set; }
        public string? Previous { get; set; }
        public int Total { get; set; }
        public List<Item>? Items { get; set; }
    }
}
