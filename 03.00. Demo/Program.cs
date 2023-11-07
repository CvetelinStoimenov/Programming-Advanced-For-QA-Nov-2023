
using System.Diagnostics;
using System.Text;

string str = "Hello, C#";


// string to char Arrey
char[] str2 = str.ToCharArray();

Console.WriteLine("String to char Arrey-> " + string.Join('+', str2));


//string by char index
char ch = str[2];
Console.WriteLine("String by char index-> The second char in string is: " + ch);


//use the + or the += operator
string text = "Hello, ";
text += "Jhon!";
Console.WriteLine("Use the + or the += operator-> " + text);


//Use the Concact() method
string greet = "Hi, ";
string name = "Pesho!";
string result = string.Concat("Use the Concact() method-> " + greet, name);
Console.WriteLine(result);


//string.Join("", .....) concatenates strings
string join = string.Join("", "con", "ca", "ten", "ate" );
Console.WriteLine("Use the string.Join(\"\", \"con\", \"ca\", \"ten\", \"ate\" )-> " + join);


//Usful for repeating a string
string s = "abc";
string[] arr = new string[3];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = s;
}

string repeated = string.Join("", arr);
Console.WriteLine("Usful for repeating a string-> " + repeated);

/*Problem: Repeat Strings
Read an array from strings
Repeat each word n times, where n is the length of the word

hi abc add  ->  hihiabcabcabcaddaddadd
work  ->  workworkworkwork
ball  ->  ballballballball*/

Console.WriteLine("Enter string to repeat: hi abc add");
//string[] words = Console.ReadLine().Split();
string[] words = { "hi", "abc", "add" };
string repeatResult = "";

foreach (string word in words)
{
    int repeatTimes = word.Length;
    for (int i = 0; i < repeatTimes; i++)
    {
        repeatResult += word;
    }
}

Console.WriteLine("Problem: Repeat Strings " + repeatResult);

//IndexOf() return the firs mattch index or -1
string fruits = "banana, apple, kiwi, banana, apple";
Console.WriteLine("IndexOf() return the firs mattch index: " + fruits.IndexOf("banana"));
Console.WriteLine("IndexOf() return -1 because orange is missing: " + fruits.IndexOf("orange"));

// LastIndexOf()- finds the last occurrance
Console.WriteLine("LastIndexOf() return the last mattch index: " + fruits.LastIndexOf("banana"));
Console.WriteLine("LastIndexOf() return -1 because orange is missing: " + fruits.LastIndexOf("orange"));


//Contains() checks whether one string contains another
string textCont = "I love fruits.";
Console.WriteLine("Contains() checks whether one string contains another " + textCont.Contains("fruits"));
Console.WriteLine("Contains() checks whether one string contains another " + textCont.Contains("banana"));


//Substring(int startIndex, int length)
string card = "10C";
string power = card.Substring(0, 2);
Console.WriteLine("Extract substring from 10C: " + power);

string textToExtractFrom = "My name is Jhon";
string extractWord = textToExtractFrom.Substring(11);
Console.WriteLine("Extract substring from \"My name is Jhon\": " + extractWord);

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
//string key = Console.ReadLine();
//string textToCut = Console.ReadLine();
string key = "ice";
string textToCut = "kicegiceiceb";

int index = textToCut.IndexOf(key);

while (index != -1)
{
    textToCut = textToCut.Remove(index, key.Length);
    index = textToCut.IndexOf(key);
}
Console.WriteLine("Problem: Substring: " + textToCut);

//Spliting a string by given separator
string textToSplit = "Hello, jhon@softuni.org, you have been using jhon@softuni.org in your registration";
string[] splitedWords = textToSplit.Split(", ");
Console.WriteLine(string.Join("|", splitedWords));

//Split by multiple separators
char[] separators = new char[] { ' ', ',', '.' };
string[] splitByMultiSeparators = textToSplit.Split(separators);
Console.WriteLine(string.Join("|", splitByMultiSeparators));


//Replace(match, replacement) replaces all occurrences
string replacedText = textToSplit
        .Replace("jhon@softuni.org", "john@softuni.com");
Console.WriteLine(replacedText);


/*Problem: Text Filter
 You are given a text and a string of banned words
Replace all banned words in the text with asterisks
Linux, Windows
input: It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality...
Output: It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality...*/

//string[] banWords = Console.ReadLine()
//     .Split(", ");
//string textToReplaceWords = Console.ReadLine();
string[] banWords = { "Linux", "Windows"};
string textToReplaceWords = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality...";

foreach (var banWord in banWords)
{
    textToReplaceWords = textToReplaceWords.Replace(banWord, new string('*', banWord.Length));
}
Console.WriteLine("Problem: Text Filter: " + textToReplaceWords);


//Use the StringBilder to build / modify string
StringBuilder sb = new StringBuilder();
//Append(…) – add text or a string representation of an objectto the end of a string
sb.Append("Concatenating strings is slower than StringBuilder: ");
sb.Append("Hello, ");
sb.Append("Jhon! ");
sb.Append("I sent you an email.");
Console.WriteLine(sb);


//Concatenating strings is a slow operation because eachiteration creates a new string
Stopwatch sw = new Stopwatch();
sw.Start();
string testText = "";
for (int i = 0; i < 20000; i++)
    testText += i;
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

Stopwatch swStringBuilder = new Stopwatch();
swStringBuilder.Start();
StringBuilder testBuilder = new StringBuilder();
for (int i = 0; i < 20000; i++)
    testBuilder.Append(i);
swStringBuilder.Stop();
Console.WriteLine(swStringBuilder.ElapsedMilliseconds);

//Length – holds the length of the string in the buffer
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Hello Peter, how are you?");
Console.WriteLine(stringBuilder.Length);
//stringBuilder.Clear(); – removes all characters


//[int index] – returns the char on current index
Console.WriteLine(stringBuilder[1]); // e

//Insert(int index, string str) – inserts a stringat the specified character position
stringBuilder.Insert(11, " Ivanov");
Console.WriteLine(stringBuilder); // Hello Peter Ivanov, how are you? 


//Replace(string oldValue, string newValue) – replaces all occurrences of a specified string
//with another specified string
stringBuilder.Replace("Peter", "George");
Console.WriteLine(stringBuilder); // Hello George Ivanov, how are you? 

//ТoString() – converts the value of this instance to a String
string stringBuilderToString = stringBuilder.ToString();
Console.WriteLine(stringBuilderToString);
