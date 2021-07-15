using System;
using OpenLinks.Themes;
using OpenLinks.Links;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace OpenLinks
{
    public class InterfaceProgram
    {
        private readonly List<Theme> themes;

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
            themes = new List<Theme>();
        }

        public void AddTheme(params Theme[] themesToAdd)
        {
            foreach (var theme in themesToAdd)
            {
                themes.Add(theme);
            }
        }

        public void ChooseTheme()
        {
            while (true)
            {
                ShowAllThemes();

                if (InputIsCorrect(themes, out var correctId))
                {
                    ShowMenuTheme(correctId);
                }
                else
                {
                    ShowErrorMessage();
                    continue;
                }
            }
        }

        private void ShowMenuTheme(int idTheme)
        {
            Console.Clear();
            Console.WriteLine($"Тема: {themes[idTheme].Name}");
            themes[idTheme].ShowLinks();

            ChooseUrl(links: themes[idTheme].Links);
        }

        private void ChooseUrl(List<Link> links)
        {
            Console.Write("ID ссылки: ");

            if (InputIsCorrect(links, out var correctId))
            {
                links[correctId].OpenUrl();
                Console.Clear();
            }
            else
            {
                ShowErrorMessage();
                return;
            }
        }

        private void ShowAllThemes()
        {
            Console.WriteLine("Список тем: ");

            for (int i = 0; i < themes.Count; i++)
            {
                Console.WriteLine($"*- [ID: {i}] {themes[i].Name}");
            }

            Console.Write("ID темы: ");
        }

        private bool InputIsCorrect<T>(IEnumerable<T> elementsArray, out int correctId)
        {
            var isCorrect = int.TryParse(Console.ReadLine(), out int urlId);
            correctId = urlId;

            return isCorrect && IdInRange(correctId, elementsArray);
        }

        private bool IdInRange<T>(int id, IEnumerable<T> array)
        {
            return id >= 0 && id < array.Count();
        }

        private void ShowErrorMessage()
        {
            Console.WriteLine("Неверный ввод!");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
