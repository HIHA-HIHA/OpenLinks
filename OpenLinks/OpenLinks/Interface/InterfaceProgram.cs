using System;



using OpenLinks.Themes;
using OpenLinks.Links;
using System.Threading;

namespace OpenLinks
{
    class InterfaceProgram
    {

        private Theme[] themes { get; }

        private static InterfaceProgram interfaceProgram;
        public static InterfaceProgram Instance
        {
            get
            {
                if (interfaceProgram != null)
                {
                    return interfaceProgram;
                }
                else
                {
                    interfaceProgram = new InterfaceProgram();
                    return interfaceProgram;
                }
            }

        }

        private InterfaceProgram()
        {

            Theme vkTheme = new VKTheme();
            Theme youTubeTheme = new YouTubeTheme();
            themes = new Theme[] { vkTheme, youTubeTheme };
        }

        
        public void ChoiseTheme()
        {
            while (true)
            {
                Console.WriteLine("Список тем: ");
                for (int i = 0; i < themes.Length; i++)
                {
                    Console.WriteLine($"*- [ID: {i}] {themes[i].Name}");
                }
                Console.Write("ID темы: ");

                
                if (Int32.TryParse(Console.ReadLine(), out int idTheme) && idTheme <= themes.Length)
                {
                    ShowMenuTheme(themes: themes, idTheme: idTheme);
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                    Thread.Sleep(1000);  // wait programm 500 miliseconds.
                    Console.Clear();
                    continue;
                }                                                              
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="themes">Array themes.</param>
        /// <param name="idTheme">ID the right one theme</param>
        private void ShowMenuTheme(Theme[] themes, int idTheme)
        {
            

            Console.Clear();
            Console.WriteLine($"Тема: {themes[idTheme].Name}");
            themes[idTheme].ShowLinks();
            ChosieUrl(links: themes[idTheme].Links);



        }

        /// <summary>
        /// Choise link from theme for open in browser.
        /// </summary>
        /// <param name="links"> Array links in theme.</param>
        private void ChosieUrl(Link[] links)
        {
            Console.Write("ID ссылки: ");
            
            if (Int32.TryParse(Console.ReadLine(), out int idUrl)&& idUrl <= links.Length)
            {
                links[idUrl].OpenUrl();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
                Thread.Sleep(1000);  // wait programm 500 miliseconds.
                Console.Clear();
                return;
            }
        }

    }
}
