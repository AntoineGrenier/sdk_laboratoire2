
namespace LibrairieConversionNote
{

    public class Conversion
    {
       
        /// Retourne la note alphanumerique
       
        /// <param name="string">La note alphanumerique</param>

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
                default: //La Valeur n'est pas dans la liste du haut
                    strReturnValue = "Ya pas de lettre rechercher, Entrer une lettre entre A et G:";
                    break;
            }
            //Retourne la valeur
            return strReturnValue;
        }

        
        /// Retourne la valeur alphanumerique de la note
        
        /// <param name="string">La note</param>
        
        public string NoteToAlpha(string str)
        {
            string strReturnValue = string.Empty;
            switch (str.ToUpperInvariant())
            {
                case "LA":
                    strReturnValue= "A";
                    break;
                case "SI":
                    strReturnValue= "B";
                    break;
                case "DO":
                    strReturnValue= "C";
                    break;
                case "RE":
                    strReturnValue= "D";
                    break;
                case "MI":
                    strReturnValue= "E";
                    break;
                case "FA":
                    strReturnValue= "F";
                    break;
                case "SOL":
                    strReturnValue= "G";
                    break;
                default:
                    strReturnValue = "Ya pas la NOTE rechercher, Entrer une NOTE entre DO, RE, MI, FA, SOL, LA ou SI : ";
                    break;
            }
            return strReturnValue;
        }
    }
}