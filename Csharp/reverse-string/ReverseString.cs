using System;

public static class ReverseString
{
	public static string Reverse(string input)
	{
		char[] newstring = input.ToCharArray();
		char[] result = new char[newstring.Length];
			int inputLength =newstring.Length-1;
		for (int i=0; i<=inputLength; i++){
			
			result[i]=newstring[inputLength-i];
			//inputLength--;
}
	
 
return new string(result);


	}
}