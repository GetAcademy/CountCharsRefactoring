namespace CountCharsRefactoring
{
    internal class FlagApp
    {
        public static void Run()
        {
            //RepeatFlagLineType1(6);
            Repeat(FlagLineAllColors, 6);
            FlagLineWhiteAndBlue();
            Repeat(FlagLineBlue, 2);
            FlagLineWhiteAndBlue();
            Repeat(FlagLineAllColors, 6);

            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static void RepeatFlagLineType1(int n )
        {
            for (var i = 0; i < n; i++)
            {
                FlagLineAllColors();
            }
        }

        private static void Repeat(Action action, int count)
        {
            for (var i = 0; i < count; i++)
            {
                action();
            }
        }

        private static void FlagLineAllColors()
        {
            Write(ConsoleColor.Red, 6);
            Write(ConsoleColor.White);
            Write(ConsoleColor.Blue, 2);
            Write(ConsoleColor.White);
            Write(ConsoleColor.Red, 12);
            WriteLineAndBlack();
        }

        private static void FlagLineWhiteAndBlue()
        {
            Write(ConsoleColor.White, 7);
            Write(ConsoleColor.Blue, 2);
            Write(ConsoleColor.White, 13);
            WriteLineAndBlack();
        }

        private static void FlagLineBlue()
        {
            Write(ConsoleColor.Blue, 22);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteLineAndBlack();
        }
        private static void WriteLineAndBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        private static void Write(ConsoleColor color, int count = 1, char character = ' ')
        {
            Console.BackgroundColor = color;
            Console.Write("".PadLeft(count*2, character));
        }
    }
}
