using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1__algoritmen_gr11
{
    //###############################################################################
    //Avgöra om en given array av heltal innehåller några duplicerade element
    // Funktionen tar emot en array av heltal och returnerar true om det finns dupliceringar, annars false.
    // Pseudokod:
    /*
    FUNCTION HarDupliceringar(array)
        SET sätt = NY Uppsetning() // Skapar en uppsättning för att hålla reda på unika element
        FOR varje element i array
            OM sätt innehåller element
                RETURN SANT // Det finns en duplicering
            ANNARS
                LÄGG TILL element i sätt
        RETURN FALSKT // Inga dupliceringar hittades
    */

    //###############################################################################
    internal class DuplicateCheck
    {
        
        public static bool HarDupliceringar(int[] array)
        {
            if (array == null || array.Length == 0) //  (O(1))
            {
                throw new ArgumentException("Arrayen får inte vara null eller tom.");
            }

            HashSet<int> set = new HashSet<int>(); // (O(1))

            foreach (int num in array) //  (O(n))
            {
                if (!set.Add(num)) //  (O(1))
                {
                    return true; 
                }
            }

            return false; 
        }
    }
    
}
