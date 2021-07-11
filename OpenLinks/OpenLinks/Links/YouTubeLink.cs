

using System.Diagnostics;

namespace OpenLinks.Links
{
    class YouTubeLink : Link
    {
        public YouTubeLink(string url, string name)
        {

            Url = url;
            Name = name;
        }

        public override void OpenUrl()
        {
            Process.Start(Url);
        }
    }
}
