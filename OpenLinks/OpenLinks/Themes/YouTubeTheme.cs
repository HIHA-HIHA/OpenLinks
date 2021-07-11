using OpenLinks.Links;

namespace OpenLinks.Themes
{
    class YouTubeTheme : Theme
    {
        public YouTubeTheme()
        {
            Name = "YouTube";

            var authorChannel = new Link(
                url: "https://www.youtube.com/channel/UCMJx9bAuYr_dy8slqKe13JQ",
                name: "Channal author in youtube"
            );

            var youtube = new Link(
                url: "https://www.youtube.com/", 
                name: "YouTube"
            );

            Links = new Link[] { authorChannel, youtube };
        }
    }
}
