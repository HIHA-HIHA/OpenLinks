

namespace OpenLinks.Links
{
    abstract class Link
    {
        /// <summary>
        /// Adress link.
        /// </summary>
        public string Url { get;  protected set; } 

        /// <summary>
        /// Name link.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Open link in browser.
        /// </summary>
        public abstract void OpenUrl();

       
    }
}
