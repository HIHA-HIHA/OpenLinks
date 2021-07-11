using OpenLinks.Links;

namespace OpenLinks.Themes
{
    class VKTheme : Theme
    {
        public VKTheme()
        {
            Name = "VK";

            var vkProfile = new Link(
                url: "https://vk.com/suandfo", 
                name: "Author profile in VK"
            );

            var vkDirectMessage = new Link(
                url: "https://vk.com/im",
                name: "VK Message"
            );

            Links = new Link[] { vkProfile, vkDirectMessage };
        }
    }
}




