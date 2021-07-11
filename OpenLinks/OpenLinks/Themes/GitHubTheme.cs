using OpenLinks.Links;

namespace OpenLinks.Themes
{
    class GitHubTheme : Theme
    {
        public GitHubTheme()
        {
            Name = "GitHub";

            var authorProfile = new Link(
                url: "https://github.com/HUHA-Kay",
                name: "Author's profile"
            );

            Links = new Link[] { authorProfile };
        }
    }
}
