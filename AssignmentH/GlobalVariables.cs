using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentH
{
    public static class GV
    {
        public delegate void _EmployeeInfo(EmployeesInfo emp);

        private static EmployeesInfo[] employees;
        private static decimal mean;
        public static double Dmean { get; set; }
        public static EmployeesInfo[] Employees { get => employees; set => employees = value; }
        public static decimal Mean { get => mean; set => mean = value; }
        public static string JsonFile { get => jsonFile; set => jsonFile = value; }

        private static string jsonFile = "answers.json";

        public static double SatisfiedMin = 1.0;
        public static double SatisfiedMax = 1.9;
        public static double LessSatisfiedMin = 2.0;
        public static double LessSatisfiedMax = 2.9;
        public static double LessLessSatisfiedMin = 3.0;
        public static double LessLessSatisfiedMax = 3.9;
        public static double NotSatisfiedMin = 4.0;
        public static double NotSatisfiedMax = 4.9;

    }
}
