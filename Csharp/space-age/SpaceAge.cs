using System;


/*
 
	Earth: orbital period 365.25 Earth days, or 31557600 seconds
	Mercury: orbital period 0.2408467 Earth years
	Venus: orbital period 0.61519726 Earth years
	Mars: orbital period 1.8808158 Earth years
	Jupiter: orbital period 11.862615 Earth years
	Saturn: orbital period 29.447498 Earth years
	Uranus: orbital period 84.016846 Earth years
	Neptune: orbital period 164.79132 Earth years
 
 
 */


public class SpaceAge

{
	public long age;
	public  SpaceAge(long seconds)
	{
		 age = seconds;
	}

	public double OnEarth()
	{
		double result;

		result = Math.Round(age/(31557600.0*1),2);

		return result;
	}

	public double OnMercury()
	{
			double result;

		result = Math.Round(age/(31557600.0*0.2408467),2);

		return result;
	}

	public double OnVenus()
	{
			double result;

		result = Math.Round(age/(31557600.0*0.61519726),2);

		return result;
	}

	public double OnMars()
	{
			double result;

		result = Math.Round(age/(31557600.0*1.8808158),2);

		return result;
	}

	public double OnJupiter()
	{
		double result;

		result = Math.Round(age/(31557600.0*11.862615),2);

		return result;
	}

	public double OnSaturn()
	{
		double result;

		result = Math.Round(age/(31557600.0*29.447498),2);

		return result;
	}

	public double OnUranus()
	{
		double result;

		result = Math.Round(age/(31557600.0*84.016846),2);

		return result;
	}

	public double OnNeptune()
	{
		double result;

		result = Math.Round(age/(31557600.0*164.79132),2);

		return result;
	}
}