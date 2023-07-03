//Notre librairie
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
        public string NoteToAlpha(string str)
        {
            //variable de retour
            string strReturnValue = string.Empty;
            //On mets toutes les valeurs passées en majuscules
            switch (str.ToUpperInvariant())
            {
                case "LA":
                    strReturnValue = "A";
                    break;
                case "SI":
                    strReturnValue = "B";
                    break;
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
                default: //Valeur n'est pas dans la liste du haut
                    strReturnValue = "Cette note n'est pas inclu";
                    break;
            }
            //Retourne la valeur
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
            return strReturnValue;
        }
    }
}