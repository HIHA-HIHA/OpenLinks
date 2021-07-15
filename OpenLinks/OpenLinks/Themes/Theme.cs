using OpenLinks.Links;

using System;
using System.Collections.Generic;

namespace OpenLinks.Themes
{
    public class Theme
    {
        public string Name { get; set; }
        public List<Link> Links { get; set; }

        public Theme()
        {
            
        }

        public virtual void ShowLinks()
        {
            Console.WriteLine("Ссылки: ");

            for (int i = 0; i < Links.Count; i++)
            {
                Console.WriteLine($"* [ID: {i} ] [ {Links[i].Name} ]");
            }
        }
    }
}
