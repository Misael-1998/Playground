using System;

namespace Playground.Extras
{
    public static class MethodExtension
    {
        public static void WriteLines(this CustomConsole console, params string[] lines) {
            foreach(string line in lines)
            {
                console.Print(line);
            }
        }
    }
}
