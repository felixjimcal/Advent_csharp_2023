namespace challenges
{
    public class Three
    {
        public static string Run(string original, string modified)
        {
            Dictionary<char, int> charCount = [];

            // Contar la frecuencia de cada carácter en 'original'
            foreach (char ch in original)
            {
                if (charCount.TryGetValue(ch, out int value))
                {
                    charCount[ch] = ++value;
                }
                else
                {
                    charCount[ch] = 1;
                }
            }

            // Ajustar la frecuencia basada en 'modified' y encontrar el carácter adicional
            foreach (char ch in modified)
            {
                if (!charCount.TryGetValue(ch, out int value))
                {
                    return ch.ToString(); // Este es el carácter adicional
                }

                charCount[ch] = --value;
                if (value < 0)
                {
                    return ch.ToString(); // Este es el carácter adicional
                }
            }

            // Buscar cualquier carácter que falte en 'modified'
            foreach (KeyValuePair<char, int> pair in charCount)
            {
                if (pair.Value > 0)
                {
                    return pair.Key.ToString(); // Este es el carácter faltante
                }
            }

            return ""; // Si no se encuentra ningún carácter adicional o faltante
        }
    }
}

/*
En el taller de Santa, un elfo travieso ha estado jugando en la cadena de fabricación de regalos, añadiendo o eliminando un paso no planificado.

Tienes la secuencia original de pasos en la fabricación original y la secuencia modificada modified que puede incluir un paso extra o faltar un paso.

Tu tarea es escribir una función que identifique y devuelva el primer paso extra que se ha añadido o eliminado en la cadena de fabricación. Si no hay ninguna diferencia entre las secuencias, devuelve una cadena vacía.

const original = 'abcd'
const modified = 'abcde'
findNaughtyStep(original, modified) // 'e'

const original = 'stepfor'
const modified = 'stepor'
findNaughtyStep(original, modified) // 'f'

const original = 'abcde'
const modified = 'abcde'
findNaughtyStep(original, modified) // ''
A tener en cuenta:

Siempre habrá un paso de diferencia o ninguno.
La modificación puede ocurrir en cualquier lugar de la cadena.
La secuencia original puede estar vacía
 */