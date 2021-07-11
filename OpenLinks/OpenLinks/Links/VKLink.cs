
using System.Diagnostics;

namespace OpenLinks.Links
{
    class VKLink : Link
    {
        public VKLink(string url, string name)
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
