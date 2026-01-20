

List<string> words = new List<string>{ "hello", "world", "!" };
List<string> words2 = new List<string>{ "Salom", "Hello", "Zdrasti" };
words.AddRange(words2);
foreach (var item in words)
{
    Console.WriteLine(item);
}
