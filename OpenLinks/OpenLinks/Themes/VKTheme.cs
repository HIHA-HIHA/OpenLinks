using OpenLinks.Links;
using System;

namespace OpenLinks.Themes
{
    class VKTheme : Theme
    {
        public VKTheme()
        {
            Name = "VK";

            VKLink AuthorProfileInVK = new VKLink(url: "https://vk.com/suandfo", name: "Author profile in VK");
            VKLink VKMessage = new VKLink(url: "https://vk.com/im", name: "VK Message");

            Links = new Link[] { AuthorProfileInVK, VKMessage };
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




