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
        public string AlphaToNote(string str)
        {
            //variable de retour
            string strReturnValue = string.Empty;
            //On mets toutes les valeurs passées en majuscules
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
                default: //Valeur n'est pas dans la liste du haut
                    strReturnValue = "La note n'existe pas";
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
                    strReturnValue = "La note n'existe pas";
                    break;
            }
            //Retourne la valeur
            return strReturnValue;
        }
            
        }
    }
