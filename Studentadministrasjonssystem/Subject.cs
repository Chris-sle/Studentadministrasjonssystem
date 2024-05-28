namespace Studentadministrasjonssystem
{
    internal class Subject
    {
        public string CourseCode { get; }
        public string CourseName { get; }
        public int CreditPoints { get; }

        public Subject(string courseCode, string courseName, int creditPoints)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            CreditPoints = creditPoints;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Subject: {CourseCode} - {CourseName} ({CreditPoints} credits)");
        }
    }
}
