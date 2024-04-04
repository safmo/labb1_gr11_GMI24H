using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labb1__algoritmen_gr11
{
    //###############################################################################
    // Ersätt vokaler i en sträng med asterisktecken
    // Funktionen tar emot en sträng och ersätter varje vokal med "*". Returnerar den ersatta strängen.
    // Pseudokod:
    /*
    FUNCTION ErsattVokaler(sträng)
        FOR varje tecken i sträng
            OM tecken är en vokal
                Ersätt tecken med "*"
        RETURN sträng
    */

    //###############################################################################
    internal class VowelReplacer
    {
        
        public static string ErsättVokaler(string sträng)
        {
            HashSet<char> vokalerSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            StringBuilder resultat = new StringBuilder(sträng.Length);

            foreach (char c in sträng) // (O(n))
            {
                if (vokalerSet.Contains(c)) //  (O(1))
                {
                    resultat.Append('*'); // (O(1))
                }
                else
                {
                    resultat.Append(c); // (O(1))
                }
            }

            return resultat.ToString(); 
        }
    }
}
