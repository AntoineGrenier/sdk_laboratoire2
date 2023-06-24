//Imporation de la librairie
using LibrairieConversionNote;

//Création nouvel objet de notre librairie
Conversion conversionObj = new Conversion();

//On roule l'application non-stop, tant que CTRL+C
while (true)
{
    Console.Write("Entrer NOTE pour convertir une lettre en note de musique OU entrer ALPHA pour convertir une note en lettre : ");
    var input = Console.ReadLine();

    //Si l'utilisateur tape note
    if (input?.ToUpperInvariant() == "NOTE")
    {
        //On demande en boucle la conversion 
        while (true)
        {
            Console.Write("Entrer la lettre: ");
            var note = Console.ReadLine();
            var noteRetour = conversionObj.AlphaToNote(note);
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
    //Si l'utilisateur tape alpha
    else if (input?.ToUpperInvariant() == "ALPHA")
    {
        while (true)
        {
            Console.Write("Entrer la note : ");
            var note = Console.ReadLine();
            string noteRetour = conversionObj.NoteToAlpha(note);
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
}
