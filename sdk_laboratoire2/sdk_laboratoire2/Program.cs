//Imporation de la librairie
using LibrairieConversionNote;

//Création nouvel objet de notre librairie
Conversion conversionObj = new Conversion();

//On roule l'application non-stop, tant que CTRL+C
while (true)
{
    Console.Write("Veuillez choisir un type de conversion (NOTE ou ALPHA) : ");
    var input = Console.ReadLine();

    //Si l'utilisateur tape note
    if (input?.ToUpperInvariant() == "NOTE")
    {
        //On demande en boucle la conversion 
        while (true)
        {
            Console.Write("Veuillez saisir une lettre (A,B,C,C,E,F ou G : ");
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
            Console.Write("Veuillez saisir une Note (DO,RE,MI,FA,SOL,LA,SI : ");
            var note = Console.ReadLine();
            var noteRetour = conversionObj.NoteToAlpha(note); //Mettre votre appel ici;
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
}
