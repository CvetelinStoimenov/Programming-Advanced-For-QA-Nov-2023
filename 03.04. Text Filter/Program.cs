string[] banWords = Console.ReadLine()
     .Split(", ");
string textToReplaceWords = Console.ReadLine();

foreach (var banWord in banWords)
{
    textToReplaceWords = textToReplaceWords.Replace(banWord, new string('*', banWord.Length));
}
Console.WriteLine(textToReplaceWords);