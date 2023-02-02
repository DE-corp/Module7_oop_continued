using System;

namespace Module7_oop_continued
{
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager: Employee
    {
        public string ProjectName;
    }

    class Developer: Employee
    {
        public string ProgrammingLanguage;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Developer = new Developer();
            Developer.ProgrammingLanguage = "C#";
        }
    }
}
