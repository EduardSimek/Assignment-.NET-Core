namespace AssignmentH
{
     public class CalculateMean
     {

         public static decimal _CalculateMean(int[] values)
         {
             int sum = 0;
             foreach (int value in values)
             {
                 sum += value;
             }
             decimal mean = sum / values.Length;
             return mean;
         }
     }
    
    
}
