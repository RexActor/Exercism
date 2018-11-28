using System;

public static class Gigasecond
{

	private static TimeSpan GIGASECOND= new TimeSpan(0,0,1000000000);
    public static DateTime Add(DateTime birthDate)
    {
       return birthDate.Add(GIGASECOND);
    }
}