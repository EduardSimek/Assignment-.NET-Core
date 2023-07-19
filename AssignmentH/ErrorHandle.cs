namespace AssignmentH
{
    public class ErrorHandling
    {
        public static void _Err(Exception ex)
        {
            Console.WriteLine($"An error occured : {ex.Message}");
        }                  
    }
}
