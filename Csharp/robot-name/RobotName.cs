using System;

public class Robot

   
{
  
    public string Name
    {
        

          

        get
        {
              
           var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "0123456789";
            
            var random = new Random();
           var stringChars = new char[5];
         

          

            for (int i = 0; i < 2; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            for (int i = 2; i < 5; i++)
            {
                stringChars[i] = numbers[random.Next(numbers.Length)];
            }
            

          var myproperty = new String(stringChars);
              
            return myproperty;

}

   


 }

  
    public void Reset()
    {
              
        new Robot();
    }
}