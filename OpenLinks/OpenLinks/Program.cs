using OpenLinks.Links;
using OpenLinks.Themes;

using System.Collections.Generic;

namespace OpenLinks
{
    class Program
    {
        static void Main()
        {
            InterfaceProgram interfaceProgram = InterfaceProgram.Instance;

            interfaceProgram.AddTheme(
                new Theme()
                {
                    Name = "GitHub",
                    Links = new List<Link>
                    {
                        new Link(url:"https://github.com/HUHA-Kay" , name:"Author account" )
                    }
                },  // GitHub
                new Theme()
                {
                    Name = "YouTube",
                    Links = new List<Link>()
                    {
                        new Link(url: "https://www.youtube.com/", name: "Youtube"),
                        new Link(url: "https://www.youtube.com/channel/UCMJx9bAuYr_dy8slqKe13JQ" , name: "Channel-Bad Rrogrammer"),
                        new Link(url: "https://www.youtube.com/feed/subscriptions", name: "Subscriptions"),
                        new Link(url: "https://www.youtube.com/feed/history", name: "History")
                    }
                },  // YouTube
                new Theme()
                {
                    Name = "VK",
                    Links = new List<Link>
                    {
                        new Link(url: "https://vk.com/feed", name: "VK-Feed"),
                        new Link(url: "https://vk.com/im", name: "Messages"),
                        new Link(url: "https://vk.com/friends", name: "Friends")
                    }
                }   // VK
            );

            interfaceProgram.ChooseTheme();
        }
    }
}
