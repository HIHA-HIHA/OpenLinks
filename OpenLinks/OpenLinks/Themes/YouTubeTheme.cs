using OpenLinks.Links;

using System;


namespace OpenLinks.Themes
{
    class YouTubeTheme : Theme
    {
        public YouTubeTheme()
        {
            Name = "YouTube";

            YouTubeLink MyChannal = new YouTubeLink(url: "https://www.youtube.com/channel/UCMJx9bAuYr_dy8slqKe13JQ", name: "Youtube-MyChannal");
            YouTubeLink Youtube = new YouTubeLink(url: "https://www.youtube.com/", name: "YouTube");

            Links = new Link[] { MyChannal, Youtube };
        }

        public override void ShowLinks()
        {
            Console.WriteLine("Ссылки: ");
            for (int i = 0; i < Links.Length; i++)
            {
                Console.WriteLine($"* [ID: {i} ] [ {Links[i].Name} ]");
            }
        }
    }
}
