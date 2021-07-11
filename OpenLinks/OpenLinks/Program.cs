using OpenLinks.Themes;

namespace OpenLinks
{
    class Program
    {
        static void Main()
        {
            InterfaceProgram interfaceProgram = InterfaceProgram.Instance;
            interfaceProgram.AddTheme(
                new YouTubeTheme(),
                new VKTheme(),
                new GitHubTheme()
            );
            interfaceProgram.ChooseTheme();
        }
    }
}
