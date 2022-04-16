using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Viewer {
        public static void Show(string Text)
        {
             Console.Clear();
             Console.BackgroundColor = ConsoleColor.White;
             Console.ForegroundColor = ConsoleColor.Black;
             Console.Clear();
             Console.WriteLine("MODO VISUALIZAÇÃO");
             Console.WriteLine("-----------------");
             Replace(Text);
             Console.WriteLine("-----------------");
             Console.ReadKey();
             Menu.Show();
        }

        public static void Replace(string Text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            Console.WriteLine(strong);
        }
    }
}