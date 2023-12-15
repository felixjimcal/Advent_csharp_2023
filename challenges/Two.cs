public class Two()
{
    public static void Run()
    {
        List<string> words = ["tren", "oso", "pelota"];
        string letters = "tronesa";

        List<string> result = run(words, letters);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    private static List<string> run(List<string> words, string letters)
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
}