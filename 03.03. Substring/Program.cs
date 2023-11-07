/*Problem: Substring
 You are given a text and a remove word
Remove all substrings that are equal to the remove word

ice
kicegiceiceb -> kgb

abc
tcabctqw     -> tctqw

key
keytextkey   -> text

word
wordawordbwordc -> abc*/

string key = Console.ReadLine();
string textToCut = Console.ReadLine();

int index = textToCut.IndexOf(key);

while (index != -1)
{
    textToCut = textToCut.Remove(index, key.Length);
    index = textToCut.IndexOf(key);
}
Console.WriteLine(textToCut);