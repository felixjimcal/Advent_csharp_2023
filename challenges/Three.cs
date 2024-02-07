namespace challenges
{
    public class Three
    {
        public static string Run(string original, string modified)
        {
            // Convertir las cadenas a arrays de caracteres y ordenarlos
            char[] originalArr = original.ToCharArray();
            char[] modifiedArr = modified.ToCharArray();
            Array.Sort(originalArr);
            Array.Sort(modifiedArr);

            // Recorrer el array más corto
            int minLength = Math.Min(originalArr.Length, modifiedArr.Length);
            for (int i = 0; i < minLength; i++)
            {
                // Si los caracteres no coinciden, devolver el extra/faltante
                if (originalArr[i] != modifiedArr[i])
                {
                    return originalArr.Length < modifiedArr.Length ? modifiedArr[i].ToString() : originalArr[i].ToString();
                }
            }

            // Si se recorrió toda la cadena sin encontrar diferencias, el caracter extra/faltante está al final de la cadena más larga
            if (originalArr.Length != modifiedArr.Length)
            {
                return originalArr.Length < modifiedArr.Length ? modifiedArr[minLength].ToString() : originalArr[minLength].ToString();
            }

            // Si no se encuentra ninguna diferencia, devolver cadena vacía
            return "";
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