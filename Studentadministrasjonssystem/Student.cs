namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudyProgram { get; set; }
        public int StudentId { get; set; }
        public List<Subject> Subjects { get; }
        public List<Grade> Grades { get; }

        public Student(string name, int age, string studyProgram, int studentId)
        {
            Name = name;
            Age = age;
            StudyProgram = studyProgram;
            StudentId = studentId;
            Subjects = new List<Subject>();
            Grades = new List<Grade>();
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student: {Name} (Age: {Age}) - {StudyProgram} (ID: {StudentId})");
            Console.WriteLine("Subjects:");
            foreach (Subject subject in Subjects)
            {
                Console.WriteLine($"- {subject.CourseCode}: {subject.CourseName} ({subject.CreditPoints} credits)");
            }

            Console.WriteLine("Grades:");
            foreach (Grade grade in Grades)
            {
                grade.PrintInfo();
            }
            Console.WriteLine("Average Grade: " + CalculateAverageGrade());
            Console.WriteLine("Total Credit Points: " + CalculateTotalCreditPoints());
            Console.WriteLine("____________________________________________________________");
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }

            double totalGradePoints = 0;
            foreach (Grade grade in Grades)
            {
                totalGradePoints += GetGradePoints(grade.GradeValue);
            }

            return totalGradePoints / Grades.Count;
        }

        private int GetGradePoints(string gradeValue)
        {
            return gradeValue switch
            {
                "A" => 6,
                "B" => 5,
                "C" => 4,
                "D" => 3,
                "E" => 2,
                "F" => 1,
                _ => 0 // Return 0 for unknown grades
            };
        }

        public int CalculateTotalCreditPoints()
        {
            int totalCreditPoints = 0;
            foreach (Grade grade in Grades)
            {
                totalCreditPoints += grade.Subject.CreditPoints;
            }

            return totalCreditPoints;
        }
    }
}
