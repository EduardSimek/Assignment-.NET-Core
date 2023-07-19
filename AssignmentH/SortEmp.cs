using Newtonsoft.Json;

namespace AssignmentH
{
    public class SortEmp
    {
       
        public static void _sortEmp()
        {

            using (StreamReader r = new StreamReader("answers.json"))
            {
                string json = r.ReadToEnd();

                List<EmployeesInfo> employees = JsonConvert.DeserializeObject<List<EmployeesInfo>>(json);

                var sortedEmployees = employees.GroupBy(e => e.groupId)
                                               .OrderBy(g => g.Key)
                                               .Select(g => g.OrderBy(e => e.employeeId))
                                               .SelectMany(g => g);

                //Program.CalculatingMean();

                foreach (var employee in sortedEmployees)
                {
                    Console.WriteLine($"Employee ID: {employee.employeeId}, Group ID: {employee.groupId}");
                }


            }
        }
    }
}
