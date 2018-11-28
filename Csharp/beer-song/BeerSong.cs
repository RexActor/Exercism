using System;

public static class BeerSong
{

	//"99 bottles of beer on the wall, 99 bottles of beer.\n" +
    //"Take one down and pass it around, 98 bottles of beer on the wall.";
    public static string Recite(int startBottles, int takeDown)
    {
		int b = startBottles;
		string message = "";
        for (int i=0;i<takeDown;i++)
		{
			message = message + $"{b} bottles of beer on the wall, {b} bottles of beer.\n" +
            $"Take one down and pass it around, {b-1} bottles of beer on the wall.";
			b=b-takeDown;

		}
		return message;
		
    }
}