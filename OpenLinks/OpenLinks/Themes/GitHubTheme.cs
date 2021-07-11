

using OpenLinks.Links;
using System;

namespace OpenLinks.Themes
{
class GitHubTheme : Theme
{
        public GitHubTheme()
        {
            Name = "GitHub";

            GitHubLink AuthorProfile = new GitHubLink(url: "https://github.com/HUHA-Kay", name: "Author's profile");
           
            Links = new Link[] { AuthorProfile };
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
