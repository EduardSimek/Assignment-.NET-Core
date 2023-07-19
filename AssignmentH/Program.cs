using AssignmentH;
using System.Text.Json;
using static AssignmentH.GV;

namespace Assignment
{

    public class Program
    {
        public static async Task Main(string[] args)
        {      
            await MyTask();
        }

        public static void RetrieveAllEmp()
        {
            GV._EmployeeInfo printWholeJSONFile = emp => {
                Console.WriteLine($"EmployeeID: {emp.employeeId}, GroupID: {emp.groupId}, Answer1: {emp.answer1}, Answer2: {emp.answer2}, Answer3: {emp.answer3}, Answer4: {emp.answer4}, Answer5: {emp.answer5}, VoteTime: {emp.answeredOn}");
            };
            foreach (EmployeesInfo emp in GV.Employees)
            {
                printWholeJSONFile(emp);
            }                  
        }
        public static void CalculatingMean()
        {
            _EmployeeInfo calculateMean = (emp) => {
                int[] allAnswers = { emp.answer1, emp.answer2, emp.answer3, emp.answer4, emp.answer5 };
                GV.Mean = CalculateMean._CalculateMean(allAnswers);
                GV.Dmean = (double)GV.Mean;
                Console.WriteLine($"Employee ID: {emp.employeeId}, GroupID: {emp.groupId}, Arithmetic mean: {GV.Mean}");
                Message.GetMessage();
                Console.WriteLine();
            };

            foreach (EmployeesInfo emp in GV.Employees)
            {
                calculateMean(emp);
            }
        }

        public static async Task MyTask()
        {
            try
            {
                using (FileStream file = File.OpenRead(GV.JsonFile))
                {
                    GV.Employees = await JsonSerializer.DeserializeAsync<EmployeesInfo[]>(file);
                    //RetrieveAllEmp();
                    CalculatingMean();

                    //SortEmp._sortEmp();

                }
            }
            catch (Exception exception)
            {
                ErrorHandling._Err(exception);
            }
        }

    }
    
}