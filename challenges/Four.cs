using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace challenges
{
    public class Four
    {
        public static string Run(string decode)
        {
            while (Regex.IsMatch(decode, @"\([^()]*\)"))
            {
                decode = Regex.Replace(decode, @"\(([^()]*)\)", m =>
                {
                    // Invertir el texto encontrado entre los paréntesis
                    char[] caracteres = m.Groups[1].Value.ToCharArray();
                    Array.Reverse(caracteres);
                    return new string(caracteres);
                });
            }

            return decode;
        }
    }
}

/*
En el taller de Santa 🎅, algunos mensajes navideños han sido escritos de manera peculiar: las letras dentro de los paréntesis deben ser leídas al revés

Santa necesita que estos mensajes estén correctamente formateados.
Tu tarea es escribir una función que tome una cadena de texto y revierta los caracteres dentro de cada par de paréntesis, eliminando los paréntesis en el mensaje final.

Eso sí, ten en cuenta que pueden existir paréntesis anidados, por lo que debes invertir los caracteres en el orden correcto.
*/