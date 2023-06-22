//Imporation de la librairie
using LibrairieConversionNote;


Console.CancelKeyPress += delegate
{

    Console.WriteLine("Merci d'avoir utilise ce logiciel!");

};

//Création nouvel objet de notre librairie
Conversion conversionObj = new Conversion();

//On roule l'application non-stop, tant que CTRL+C
while (true)
{
    Console.WriteLine("Type de conversion à faire : ");
    var input = Console.ReadLine();

    //Si l'utilisateur tape note
    if (input?.ToUpperInvariant() == "NOTE")
    {
        //On demande en boucle la conversion 
        while (true)
        {
            Console.Write("Conversion à faire : ");
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
            Console.Write("Conversion à faire : ");
            var note = Console.ReadLine();
            var noteRetour = conversionObj.NoteToAlpha(note);
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
    
}

