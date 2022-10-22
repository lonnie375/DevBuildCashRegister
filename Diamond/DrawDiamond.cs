using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class DrawDiamond
    {
        public static int LetterPos(char letter)
        {
            return (int)letter - 64; 
        }
        public static int CalcPadding(char dletter, char rletter)
        {
            return LetterPos(dletter) - LetterPos(rletter);

        }

        //Practice: Calculating number of spaces in between letters
        public static int CalcSpacing(char rletter)
        {
            if (rletter == 'a')
            {
                return 0;
            }

            return LetterPos(rletter) * 2 - 3;  
        }
        //Practice: A function thta takes number of spaces and builds the space string
        //2 -> " " 
        // 5 -> "     " 
        //0 -> ""
        //Function name is MakeSpace 
        public static string MakeSpace(int num)
        {
            if ( num == 0)
            {
                return ""; 
            }
            string result = ""; 
            for(int i = 1; i <= num; i++)
            {
                result = result + " ";
            }
            return result; 
        }
        public static string OneLine(char dLetter, char rLetter)
        {
            //Create a string variable called result 
            string result = ""; 

            //Call "CalcPadding"

            //Call "MakeSpace" using the padding and add that to result plus 
            //Hint" Save the result here in a variable, maybe called padding
            //Because we need it here and at the very end of this method dd

            //Add on the letter 

            //Call "CalcSpacing" for the inner spacing 

            // Call MakeSpaces using the inner spacing and add to result 

            // Add on the letter again 

            // Use MakeSpace string to add it at the end spacing
            
            //Return it 
            return " ";
        }
    }
}
