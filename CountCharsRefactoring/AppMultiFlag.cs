using System.Drawing;

namespace CountCharsRefactoring
{
    internal class AppMultiFlag
    {
        public static void Run()
        {
            var norway = new Flag(ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue);
            norway.Show();

            var iceland = new Flag(ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.Red);
            iceland.Show();

            var denmark = new Flag(ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White);
            denmark.Show();

            var sweden = new Flag(ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Yellow);
            sweden.Show();
        }
    }
}
