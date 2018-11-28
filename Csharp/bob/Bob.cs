using System;
using System.Text.RegularExpressions;

/// <summary>
/// Defines the <see cref="Bob" />
/// </summary>
public static class Bob
{
    /// <summary>
    /// The Response
    /// </summary>
    /// <param name="statement">The statement<see cref="string"/></param>
    /// <returns>The <see cref="string"/></returns>
    public static string Response(string statement)
    {
		statement=statement.Trim();

		if (statement =="")
		{ 
			return "Fine. Be that way!";
		}
		else if (!Regex.IsMatch(statement,"^[a-z0-9]+$") && statement.Substring(statement.Length-1)=="?" )
		{ 

			return "Sure.";
		}
		else if (Regex.IsMatch(statement,"[A-Z]") && statement.Substring(statement.Length-1)=="?")
			{ 
			return "Calm down, I know what I'm doing!";
		}
		else if (Regex.IsMatch(statement,"[A-Z]") && !Regex.IsMatch(statement,"[a-z]"))
		{
				return "Whoa, chill out!";
		}
		
		else 	return "Whatever.";    
    }
}
