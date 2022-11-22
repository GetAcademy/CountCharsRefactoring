/*
 * 1: Innføre variabel
 * 2: Innføre funksjon/metode
 * 3: Innføre klasse
 */

var range = 250;
var counts = new int[range];
while (true)
{
    var text = Console.ReadLine();
    foreach (var character in text)
    {
        var characterAsciiNumber = (int)character;
        counts[characterAsciiNumber]++;
    }
    for (var characterAsciiNumber = 0; characterAsciiNumber < range; characterAsciiNumber++)
    {
        var howManyOfThisCharacter = counts[characterAsciiNumber];
        if (howManyOfThisCharacter > 0)
        {
            var character = (char)characterAsciiNumber;
            Console.WriteLine(character + " - " + howManyOfThisCharacter);
        }
    }
}

// DRY = Don't Repeat Yourself
/*
var a = 2;
var b = 7;
var myBase = a * b/ 723;
var x = myBase + 14;
var y = myBase - 39;
var z = 2 * myBase;
*/