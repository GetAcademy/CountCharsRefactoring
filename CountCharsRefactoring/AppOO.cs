namespace CountCharsRefactoring
{
    internal class AppOO
    {
        public static void Run()
        {
            var characterCounter1 = new CharacterCounter();
            var characterCounter2 = new CharacterCounter();
            while (true)
            {
                var text = Console.ReadLine();
                characterCounter1.CountCharacters(text);
                characterCounter1.ShowCharactersAndCounts();
                characterCounter2.CountCharacters(text.ToUpper());
                characterCounter2.ShowCharactersAndCounts();
            }
        }
    }
}
