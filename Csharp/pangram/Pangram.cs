using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {

        bool result = false;
        if (input.Length ==0){
    
        result = false;
        }
         if(input.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26){
            result = true;                
}
    
 return result;

    }
}
