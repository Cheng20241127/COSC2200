
using System.Text.RegularExpressions;

namespace ConsoleApp.week5
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; } = string.Empty;
    }

    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }
        public InvalidStudentNameException(string name) :
            base(String.Format("Invalid Student Name: {0}", name))
        { }
    }
    internal class CustomExceptions
    {
        public static void Test(string name)
        {
            Student? newStudent = null;
            try
            {
                newStudent = new Student();
                newStudent.StudentName = name;
                ValidateStudent(newStudent);
                Console.WriteLine($"{name} is valid");
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
        }
    }
}
