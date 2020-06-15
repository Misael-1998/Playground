using System;

namespace Playground.Extras
{
    public class Menu
    {
        public string Name { get; set; } = "Menu";
        private string[] Options { get; } = { "salir" };
        public int NumberOfOptions
        {
            get => Options.Length;
        }

        public Menu(int optionsNumber)
        {
            if (optionsNumber < 1) return;
            Options = new string[optionsNumber];
        }

        public bool TryAddOption(string optionName, int posicition)
        {
            if (posicition < 0 || posicition >= Options.Length) return false;
            Options[posicition] = optionName;
            return true;
        }

        public void ShowMenu()
        {
            Console.WriteLine(Name);
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine(Options[i]);
            }

        }



    }
}