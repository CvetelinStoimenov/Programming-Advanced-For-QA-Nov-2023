/*Problem: Text Filter
 You are given a text and a string of banned words
Replace all banned words in the text with asterisks
Linux, Windows
input: It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality...
Output: It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality...*/

string[] banWords = Console.ReadLine()
     .Split(", ");
string textToReplaceWords = Console.ReadLine();

foreach (var banWord in banWords)
{
    textToReplaceWords = textToReplaceWords.Replace(banWord, new string('*', banWord.Length));
}
Console.WriteLine(textToReplaceWords);