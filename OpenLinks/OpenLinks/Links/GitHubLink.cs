using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLinks.Links
{
    class GitHubLink  : Link
    {
        public GitHubLink(string url, string name)
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
