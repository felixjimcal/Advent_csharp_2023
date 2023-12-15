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
/*
En el taller de Santa, los elfos tienen una lista de regalos que desean fabricar y un conjunto limitado de materiales.

Los regalos son cadenas de texto y los materiales son caracteres. Tu tarea es escribir una función que, dada una lista de regalos y los materiales disponibles, devuelva una lista de los regalos que se pueden fabricar.

Un regalo se puede fabricar si contamos con todos los materiales necesarios para fabricarlo.

const gifts = ['tren', 'oso', 'pelota']
const materials = 'tronesa'

manufacture(gifts, materials) // ["tren", "oso"]
// 'tren' SÍ porque sus letras están en 'tronesa'
// 'oso' SÍ porque sus letras están en 'tronesa'
// 'pelota' NO porque sus letras NO están en 'tronesa'

const gifts = ['juego', 'puzzle']
const materials = 'jlepuz'

manufacture(gifts, materials) // ["puzzle"]

const gifts = ['libro', 'ps5']
const materials = 'psli'

manufacture(gifts, materials) // []
*/