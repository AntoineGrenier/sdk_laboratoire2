// Imporation de la librairie
using LibrairieConversionNote;

class Program
{
    static void Main(string[] args)
    {
        // Création d'un nouvel objet de notre librairie
        Conversion conversionObj = new Conversion();

        // On exécute l'application en continu, jusqu'à ce que l'utilisateur utilise CTRL+C pour quitter
        while (true)
        {
            Console.Write("Type de conversion à faire : ");
            var input = Console.ReadLine();

            // Si l'utilisateur tape "note"
            if (input?.ToUpperInvariant() == "NOTE")
            {
                // On demande en boucle la conversion
                while (true)
                {
                    Console.Write("Conversion à faire : ");
                    var note = Console.ReadLine();
                    var noteRetour = conversionObj.AlphaToNote(note);
                    Console.Write(noteRetour);
                    Console.WriteLine();
                }
            }
            // Si l'utilisateur tape "alpha"
            else if (input?.ToUpperInvariant() == "ALPHA")
            {
                while (true)
                {
                    Console.Write("Conversion à faire : ");
                    var note = Console.ReadLine();
                    var noteRetour = conversionObj.NoteToAlpha(note);
                    Console.Write(noteRetour);
                    Console.WriteLine();
                }
            }
        }
    }
}
