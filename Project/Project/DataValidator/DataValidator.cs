using System;

namespace Project.DataValidator
{
 public   static  class DataValidator
    {
  public static  void CheckString(string stringForChecking)
     {
         if (string.IsNullOrWhiteSpace(stringForChecking))
         {
            throw new NullReferenceException(string.Format("Must be valid string!{0}", stringForChecking));
         }
     }

  public static void CheckValidInt(int forCheck, int minRange, int maxRange)
     {
         if (forCheck<minRange||forCheck>maxRange)
         {
             throw new ArgumentOutOfRangeException("forCheck");
         }
     }

  public static void CheckValidInt(int forCheck)
     {
         if (forCheck<0)
         {
             throw new ArgumentNullException(string.Format("Must be zero plus!!!!{0}", forCheck));
         }
     }
    }
}
