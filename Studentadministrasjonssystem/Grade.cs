namespace Studentadministrasjonssystem
{
    internal class Grade
    {
        public Student Student { get; }
        public Subject Subject { get; }
        public string GradeValue { get; }

        public Grade(Student student, Subject subject, string gradeValue)
        {
            Student = student;
            Subject = subject;
            GradeValue = gradeValue;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Subject.CourseCode}: {GradeValue}");
        }
    }
}
