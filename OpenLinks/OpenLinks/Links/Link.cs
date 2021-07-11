using System.Diagnostics;

namespace OpenLinks.Links
{
    public class Link
    {
								public Link(string url, string name)
								{
            Url = url;
            Name = name;
								}

        public string Url { get; private set; } 
        public string Name { get; private set; }

        public void OpenUrl()
								{
            Process.Start(Url);
        }
    }
}
