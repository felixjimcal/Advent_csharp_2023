static List<string> Two(List<string> words, string letters)
{
    List<string> presents = [];
    HashSet<char> hashLetters = new(letters);
    foreach (var word in words)
    {
        HashSet<char> hashWord = new(word);

        if (hashWord.IsSubsetOf(hashLetters))
        {
            presents.Add(word);
        }
    }
    return presents;
}

List<string> words = ["tren", "oso", "pelota"];
string letters = "tronesa";

List<string> result = Two(words, letters);
foreach (var item in result)
{
    Console.WriteLine(item);
}