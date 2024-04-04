namespace labb1__algoritmen_gr11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testa algoritmen för att avgöra dupliceringar i en array av heltal
            int[] arrayA = { 1, 2, 3, 4, 5, 6 };
            int[] arrayB = { 1, 2, 3, 3, 4, 5, 5 };

            Console.WriteLine("Uppgift 3:DuplicateCheck");
            Console.WriteLine("Array A har dupliceringar: " + DuplicateCheck.HarDupliceringar(arrayA));
            Console.WriteLine("Array B har dupliceringar: " + DuplicateCheck.HarDupliceringar(arrayB));

            // Testa algoritmen för att ersätta vokaler med asterisktecken i en sträng
            string testSträng = "Det här är en teststräng med vokaler.";

            try
            {
                Console.WriteLine("\nUppgift 4:VowelReplacer");
                Console.WriteLine("Ersatt vokaler: " + VowelReplacer.ErsättVokaler(testSträng));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Uppgift 4: " + ex.Message);
            }
        }
    }
}
