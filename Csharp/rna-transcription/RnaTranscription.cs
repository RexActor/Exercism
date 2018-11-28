using System;

public static class RnaTranscription
{


	/*
	 
    G -> C
    C -> G
    T -> A
    A -> U

		 
		 */
    public static string ToRna(string nucleotide)
    {
		string result;
        switch(nucleotide){
			case "G":
				result= "C";
				break;
				case "C":
				result= "G";
				break;
				case "T":
				result= "A";
				break;
				case "A":
				result= "U";
				break;
				default: result="";
				break;
				
}
		return result;
    }
}