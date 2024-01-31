using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Model
{
    // https://api.spotify.com/v1/me/top/tracks
    public class Artist
    {
        public ExternalUrls? ExternalUrls { get; set; }
        public string? Href { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Uri { get; set; }
    }

    public class Album
    {
        public string? AlbumType { get; set; }
        public List<Artist>? Artists { get; set; }
        public List<string>? AvailableMarkets { get; set; }
        public ExternalUrls? ExternalUrls { get; set; }
        public string? Href { get; set; }
        public string? Id { get; set; }
        public List<Image>? Images { get; set; }
        public string? Name { get; set; }
        public string? ReleaseDate { get; set; }
        public string? ReleaseDatePrecision { get; set; }
        public int TotalTracks { get; set; }
        public string? Type { get; set; }
        public string? Uri { get; set; }
    }

    public class ExternalIds
    {
        public string? Isrc { get; set; }
    }

    public class TopTrackItem
    {
        public Album? Album { get; set; }
        public List<Artist>? Artists { get; set; }
        public List<string>? AvailableMarkets { get; set; }
        public int DiscNumber { get; set; }
        public int DurationMs { get; set; }
        public bool Explicit { get; set; }
        public ExternalIds? ExternalIds { get; set; }
        public ExternalUrls? ExternalUrls { get; set; }
        public string? Href { get; set; }
        public string? Id { get; set; }
        public bool IsLocal { get; set; }
        public string? Name { get; set; }
        public int Popularity { get; set; }
        public string? PreviewUrl { get; set; }
        public int TrackNumber { get; set; }
        public string? Type { get; set; }
        public string? Uri { get; set; }
    }

    public class TopTracks
    {
        public List<TopTrackItem>? Items { get; set; }
        public int Total { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public string? Href { get; set; }
        public string? Next { get; set; }
        public object? Previous { get; set; }
    }


}
