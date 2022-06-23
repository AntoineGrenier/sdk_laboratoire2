//Notre librairie
namespace LibrairieConversionNote
{
    /// <summary>
    /// Classe de conversion
    /// </summary>

    public class Conversion
    {
        /// retourne la note du alphanumerique
        /// </summary>
        /// <param name = "str" > la note alphanumerique</param>
        /// <returns></returns>
        public string AlphaToNote(string str)
        {
            //variable de retour
            string strreturnvalue = string.Empty;
            //on mets toutes les valeurs passées en majuscules
            switch (str.ToUpper())
            {
                case "A":
                    strreturnvalue = "LA";
                    break;
                case "B":
                    strreturnvalue = "SI";
                    break;
                case "C":
                    strreturnvalue = "DO";
                    break;
                case "D":
                    strreturnvalue = "RE";
                    break;
                case "E":
                    strreturnvalue = "Mi";
                    break;
                case "F":
                    strreturnvalue = "FA";
                    break;
                case "G":
                    strreturnvalue = "SOL";
                    break;
                default: //valeur n'est pas dans la liste du haut
                    strreturnvalue = "la note n'existe pas";
                    break;
            }
            //retourne la valeur
            return strreturnvalue;
        }
        public string NoteToAlpha(string str)
        {
            string strreturnvalue = string.Empty;
            switch (str.ToUpper())
            {
                case "LA":
                    strreturnvalue = "A";
                    break;
                case "SI":
                    strreturnvalue = "B";
                    break;
                case "DO":
                    strreturnvalue = "C";
                    break;
                case "RE":
                    strreturnvalue = "D";
                    break;
                case "MI":
                    strreturnvalue = "E";
                    break;
                case "FA":
                    strreturnvalue = "F";
                    break;
                case "SOL":
                    strreturnvalue = "G";
                    break;
                default: //valeur n'est pas dans la liste du haut
                    strreturnvalue = "la note n'existe pas";
                    break;
            }
            //retourne la valeur
            return strreturnvalue;
        }
    }
}



//        /// <summary>
//        /// Retourne l'alphanumerique de la note
//        /// </summary>
//        /// <param name="str">La note musicale</param>
//        /// <returns></returns>

//}

//        readonly Dictionary<string, string> alphabeticalToNote = new() {
//        { "A", "LA" },
//        { "B", "SI" },
//        { "C", "DO" },
//        { "D", "RE" },
//        { "E", "MI" },
//        { "F", "FA" },
//        { "G", "SOL" }
//    };


//        public string AlphaToNote(string KEY)
//        {
//            while (!alphabeticalToNote.ContainsKey(KEY))
//            {
//                return "Entrée invalide .";
//            }
//            return alphabeticalToNote[KEY];
//        }

