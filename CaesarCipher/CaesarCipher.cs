using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {

           // throw new NotImplementedException("You need to implement this function.");

           string cypher = "";

           //shifting the capital character in the string by value given in shiftkey

            for(int i=0; i<text.Length;i++)
            {

                int val = System.Convert.ToInt32(text[i]);

                if((val>=65)&&(val<=90))
                {

                    int k = val-65;
                    k= k+shiftKey;
                    k=k%26;
                    k=k+65;
                    cypher+= (char)k; 


                }

                //shifting the small character in the string by value given in shiftkey

                 else if((val>=97)&&(val<=122))
                {
                    int k = val-97;
                    k= k+shiftKey;
                    k=k%26;
                    k=k+97;
                    cypher+= (char)k; 

                }

                  //adding all other characters to the string cypher other than english alphabets as it is.

                else
                {
                    cypher+= text[i];
                }

                
            }

            return cypher;

        }
    }
}
