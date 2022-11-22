namespace CountCharsRefactoring
{
    /*
     * 1: Innføre variabel
     * 2: Innføre funksjon/metode
     * 3: Innføre klasse
     */
    internal class App
    {
        public static void Run()
        {
            var range = 250;
            var counts = new int[range];
            while (true)
            {
                var text = Console.ReadLine();
                CountCharacters(text, counts);
                ShowCharactersAndCounts(range, counts);
            }
        }

        private static void ShowCharactersAndCounts(int range, int[] counts)
        {
            for (var characterAsciiNumber = 0; characterAsciiNumber < range; characterAsciiNumber++)
            {
                var howManyOfThisCharacter = counts[characterAsciiNumber];
                if (howManyOfThisCharacter > 0)
                {
                    var character = (char) characterAsciiNumber;
                    Console.WriteLine(character + " - " + howManyOfThisCharacter);
                }
            }
        }

        private static void CountCharacters(string? text, int[] counts)
        {
            foreach (var character in text)
            {
                var characterAsciiNumber = ConvertCharacterToNumber(character);
                counts[characterAsciiNumber]++;
            }
        }

        private static int ConvertCharacterToNumber(char character)
        {
            var characterAsciiNumber = (int) character;
            return characterAsciiNumber;
        }
    }
}
