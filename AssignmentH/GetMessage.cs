namespace AssignmentH
{
    public class Message
    {
        public static void GetMessage()
        {
            double mean = (double)GV.Mean;

            if (mean >= GV.SatisfiedMin && mean <= GV.SatisfiedMax)
            {
                Console.WriteLine("Employee is satisfied");
            }
            else if (mean >= GV.LessSatisfiedMin && mean <= GV.LessSatisfiedMax)
            {
                Console.WriteLine("Employee is less satisfied");
            }
            else if (mean >= GV.LessLessSatisfiedMin && mean <= GV.LessLessSatisfiedMax)
            {
                Console.WriteLine("Employee is less less satisfied");
            }
            else if (mean >= GV.NotSatisfiedMin && mean <= GV.NotSatisfiedMax)
            {
                Console.WriteLine("Employee is not satisfied");
            }
            else
            {
                Console.WriteLine("Employee is sad");
            }
        }
    }
}
