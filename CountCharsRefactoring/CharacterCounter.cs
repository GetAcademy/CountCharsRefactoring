namespace CountCharsRefactoring
{
    internal class CharacterCounter
    {
        private int[] _counts;

        public CharacterCounter()
        {
            var range = 250;
            _counts = new int[range];
        }

        public void ShowCharactersAndCounts()
        {
            for (var characterAsciiNumber = 0; characterAsciiNumber < _counts.Length; characterAsciiNumber++)
            {
                var howManyOfThisCharacter = _counts[characterAsciiNumber];
                if (howManyOfThisCharacter > 0)
                {
                    var character = (char)characterAsciiNumber;
                    Console.WriteLine(character + " - " + howManyOfThisCharacter);
                }
            }
        }

        public void CountCharacters(string? text)
        {
            foreach (var character in text)
            {
                var characterAsciiNumber = ConvertCharacterToNumber(character);
                _counts[characterAsciiNumber]++;
            }
        }

        private static int ConvertCharacterToNumber(char character)
        {
            var characterAsciiNumber = (int)character;
            return characterAsciiNumber;
        }
    }
}
