using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int result = 0;
      
        if(firstStrand.Length ==0)
            {
            result=0;
            }
        if(firstStrand.Length>secondStrand.Length)
            {
           throw new ArgumentException();
            }
        if (firstStrand.Length<secondStrand.Length){
            throw new ArgumentException();
}
        for(int i=0;i<firstStrand.Length;i++){
        
            if(firstStrand[i]!=secondStrand[i]){
                
              result++;
}

        }

        return result;

        
        //throw new NotImplementedException("You need to implement this function.");
    }
}