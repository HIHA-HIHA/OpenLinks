using OpenLinks.Links;

using System;

namespace OpenLinks.Themes
{
    public class Theme
    {
        public string Name { get; protected set; }
        public Link[] Links { get; protected set; }

        public virtual void ShowLinks()
        {
            Console.WriteLine("Ссылки: ");

            for (int i = 0; i < Links.Length; i++)
            {
                Console.WriteLine($"* [ID: {i} ] [ {Links[i].Name} ]");
            }
        }
    }
}
