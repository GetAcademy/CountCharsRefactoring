namespace CountCharsRefactoring
{
    internal class Flag
    {
        private ConsoleColor[] _colors;

        public Flag(params ConsoleColor[] colors)
        {
            _colors = colors;
        }

        public void Show()
        {
            //RepeatFlagLineType1(6);
            Repeat(FlagLineAllColors, 6);
            FlagLineWhiteAndBlue();
            Repeat(FlagLineBlue, 2);
            FlagLineWhiteAndBlue();
            Repeat(FlagLineAllColors, 6);

            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void RepeatFlagLineType1(int n)
        {
            for (var i = 0; i < n; i++)
            {
                FlagLineAllColors();
            }
        }

        private void Repeat(Action action, int count)
        {
            for (var i = 0; i < count; i++)
            {
                action();
            }
        }

        private  void FlagLineAllColors()
        {
            Write(_colors[0], 6);
            Write(_colors[1]);
            Write(_colors[2], 2);
            Write(_colors[1]);
            Write(_colors[0], 12);
            WriteLineAndBlack();
        }

        private  void FlagLineWhiteAndBlue()
        {
            Write(_colors[1], 7);
            Write(_colors[2], 2);
            Write(_colors[1], 13);
            WriteLineAndBlack();
        }

        private  void FlagLineBlue()
        {
            Write(_colors[2], 22);
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
            Console.Write("".PadLeft(count * 2, character));
        }
    }
}
