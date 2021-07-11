using OpenLinks.Links;



namespace OpenLinks.Themes
{
    abstract class Theme
    {
        /// <summary>
        /// Name theme.
        /// </summary>
        public string Name;

        /// <summary>
        /// Array links in theme.
        /// </summary>
        public Link[] Links;

        /// <summary>
        /// Show list links in theme.
        /// </summary>
        public abstract void ShowLinks();
    }

}
