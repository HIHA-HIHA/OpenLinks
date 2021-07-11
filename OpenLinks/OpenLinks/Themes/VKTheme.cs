using OpenLinks.Links;
using System;

namespace OpenLinks.Themes
{
    class VKTheme : Theme
    {
        public VKTheme()
        {
            Name = "VK";

            VKLink VKMe = new VKLink(url: "https://vk.com/suandfo", name: "VKME");
            VKLink VKMessage = new VKLink(url: "https://vk.com/im", name: "VKMessage");

            Links = new Link[] { VKMe, VKMessage };
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




