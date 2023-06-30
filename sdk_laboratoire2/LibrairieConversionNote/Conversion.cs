using System;

namespace LibrairieConversionNote
{
    /// <summary>
    /// Classe de conversion des notes musicales entre leur représentation alphabétique et alphanumérique
    /// </summary>
    public class Conversion
    {
        /// <summary>
        /// Convertit une note alphabétique en note alphanumérique
        /// </summary>
        /// <param name="str">La note alphabétique</param>
        /// <returns>La note alphanumérique correspondante</returns>
        public string AlphaToNote(string str)
        {
            // Variable de retour
            string strReturnValue = string.Empty;

            // Conversion de la note alphabétique en note alphanumérique
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

            // Retourne la valeur alphanumérique correspondante
            return strReturnValue;
        }

        /// <summary>
        /// Convertit une note alphanumérique en note alphabétique
        /// </summary>
        /// <param name="str">La note alphanumérique</param>
        /// <returns>La note alphabétique correspondante</returns>
        public string NoteToAlpha(string str)
        {
            // Variable de retour
            string strReturnValue = string.Empty;

            // Conversion de la note alphanumérique en note alphabétique
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
                default: // Valeur n'est pas dans la liste du haut
                    strReturnValue = "La note n'existe pas";
                    break;
            }

            // Retourne la valeur alphabétique correspondante
            return strReturnValue;
        }

        /// <summary>
        /// Exécute le programme de conversion de notes
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Bienvenue dans le programme de conversion de notes !");
            Console.WriteLine("Choisissez le type de conversion :");
            Console.WriteLine("1. ALPHA - Note vers alphabétique");
            Console.WriteLine("2. BETA - Note alphabétique vers note");
            Console.WriteLine("Pour quitter, appuyez sur CTRL + C.");

            while (true)
            {
                Console.Write("Choix : ");
                string choix = Console.ReadLine();

                if (choix.ToUpperInvariant() == "ALPHA")
                {
                    Console.WriteLine("Conversion de note vers alphabétique choisie.");

                    while (true)
                    {
                        Console.Write("Entrez la note alphabétique (A, B, C, D, E, F, G) : ");
                        string noteAlpha = Console.ReadLine();

                        string noteAlphanumerique = AlphaToNote(noteAlpha);
                        Console.WriteLine("La note alphanumérique correspondante est : " + noteAlphanumerique);
                    }
                }
                else if (choix.ToUpperInvariant() == "BETA")
                {
                    Console.WriteLine("Conversion de la note alphabétique vers la note choisie.");

                    while (true)
                    {
                        Console.Write(" Veuillez entrez la note alphanumérique (DO, RE, MI, FA, SOL, LA, SI) : ");
                        string noteAlphanumerique = Console.ReadLine();

                        string noteAlpha = NoteToAlpha(noteAlphanumerique);
                        Console.WriteLine("La note alphabétique qui correspond est : " + noteAlpha);
                    }
                }
                else
                {
                    Console.WriteLine("Choix invalide. SVP veuillez réessayer.");
                }
            }
        }
    }
}
