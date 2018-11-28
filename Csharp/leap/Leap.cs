using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {

        /*
          on every year that is evenly divisible by 4
        except every year that is evenly divisible by 100
           unless the year is also evenly divisible by 400
              
         */
         bool result = false;
        if (year%4 ==0)
            {
            if(year%100!=0){ 
                if(year%400!=0){
                   

                    result = true;
}


                }

            }
        else result = false;

        return result;




        //throw new NotImplementedException("You need to implement this function.");
    }
}