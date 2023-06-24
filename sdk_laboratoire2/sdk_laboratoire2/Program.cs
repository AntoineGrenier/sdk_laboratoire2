//Imporation de la librairie
using LibrairieConversionNote;

//Création nouvel objet de notre librairie
Conversion conversionObj = new Conversion();

//On roule l'application non-stop, tant que CTRL+C
while (true)
{
    Console.Write("Type de conversion à effectuer, tapez 'NOTE' pour convertir un alphabet en note, pour l'inverse tapez 'ALPHA': ");
    var input = Console.ReadLine();

    //Si l'utilisateur tape note
    if (input?.ToUpperInvariant() == "NOTE")
    {
        //On demande en boucle la conversion 
        while (true)
        {
            Console.Write("Entrez la l'alphabet que vous voulez convertir : ");
            var Alphabet = Console.ReadLine();
            var noteRetour = conversionObj.AlphaToNote(Alphabet);
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
    //Si l'utilisateur tape alpha
    else if (input?.ToUpperInvariant() == "ALPHA")
    {
        while (true)
        {
            Console.Write("Entrez la note que vous voulez convertir : ");
            var note = Console.ReadLine();
            var AlphabetRetour = conversionObj.NoteToAlpha(note);
            Console.Write(AlphabetRetour);
            Console.WriteLine();
        }
    }
}
