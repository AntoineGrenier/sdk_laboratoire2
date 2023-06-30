using System;

namespace LibrairieConversionNote
{
    /// <summary>
    /// Classe de conversion
    /// </summary>
    public class Conversion
    {
        /// <summary>
        /// Retourne la note du alphanumerique
        /// </summary>
        /// <param name="str">La note alphanumerique</param>
        /// <returns></returns>
        public string AlphaToNote(string str)
        {
            // Variable de retour
            string strReturnValue = string.Empty;

            // On met toutes les valeurs passées en majuscules
            switch (str.ToUpperInvariant())
            {
                case "A":
                    strReturnValue = "LA";
                    break;
                case "B":
                    strReturnValue = "SI";
                    break;
                case "C":
                    strReturnValue = "DO";
                    break;
                case "D":
                    strReturnValue = "RE";
                    break;
                case "E":
                    strReturnValue = "MI";
                    break;
                case "F":
                    strReturnValue = "FA";
                    break;
                case "G":
                    strReturnValue = "SOL";
                    break;
                default: // Valeur n'est pas dans la liste du haut
                    strReturnValue = "La note n'existe pas";
                    break;
            }

            // Retourne la valeur
            return strReturnValue;
        }

        /// <summary>
        /// Retourne l'alphanumerique de la note
        /// </summary>
        /// <param name="str">La note musicale</param>
        /// <returns></returns>
        public string NoteToAlpha(string str)
        {
            string strReturnValue = string.Empty;

            switch (str.ToUpperInvariant())
            {
                case "DO":
                    strReturnValue = "C";
                    break;
                case "RE":
                    strReturnValue = "D";
                    break;
                case "MI":
                    strReturnValue = "E";
                    break;
                case "FA":
                    strReturnValue = "F";
                    break;
                case "SOL":
                    strReturnValue = "G";
                    break;
                case "LA":
                    strReturnValue = "A";
                    break;
                case "SI":
                    strReturnValue = "B";
                    break;
                default:
                    strReturnValue = "La note n'existe pas";
                    break;
            }

            return strReturnValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conversion conversion = new Conversion();
            string conversionType = string.Empty;

            // Demande le type de conversion à effectuer (Note vers alphabétique)
            Console.WriteLine("Quel type de conversion souhaitez-vous effectuer ? (ALPHA)");

            while (true)
            {
                try
                {
                    // Lit la commande de l'utilisateur
                    string input = Console.ReadLine()?.ToUpperInvariant();

                    if (input == "ALPHA")
                    {
                        conversionType = "ALPHA";
                        Console.WriteLine("Conversion de Note vers Alphabétique sélectionnée.");
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide. Veuillez entrer ALPHA pour la conversion de Note vers Alphabétique.");
                        continue;
                    }

                    Console.WriteLine("Veuillez entrer la note syllabe à convertir (DO, RE, MI, FA, SOL, LA, SI).");

                    // Boucle de conversion en continu jusqu'à ce que l'utilisateur quitte la console
                    while (true)
                    {
                        string note = Console.ReadLine()?.ToUpperInvariant();

                        if (note == null)
                            break;

                        if (conversionType == "ALPHA")
                        {
                            string alphaNote = conversion.NoteToAlpha(note);
                            Console.WriteLine("Note alphabétique correspondante : " + alphaNote);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une erreur s'est produite : " + ex.Message);
                }
            }
        }
    }
}
