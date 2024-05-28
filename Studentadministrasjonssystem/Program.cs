namespace Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            List<Student> students = new List<Student>
            {
                new Student("Alice", 22, "Computer Science", 12345),
                new Student("Bob", 25, "Psychology", 54321)
            };

            List<Subject> subjects;
            subjects = new List<Subject>
            {
                new Subject("INFO101", "Programming Fundamentals", 5),
                new Subject("PSYCH202", "Cognitive Psychology", 7),
                new Subject("MATH301", "Advanced Mathematics", 6),
                new Subject("HIST201", "World History", 4),
                new Subject("ECON101", "Microeconomics", 5),
                new Subject("CHEM202", "Organic Chemistry", 6),
                new Subject("ENG301", "Shakespeare Literature", 4)
            };

            students[0].Subjects.AddRange(subjects);
            students[1].Subjects.AddRange(subjects);

            Grade grade1 = new Grade(students[0], subjects[1], "A");
            Grade grade2 = new Grade(students[0], subjects[3], "B");
            Grade grade3 = new Grade(students[1], subjects[2], "B");
            Grade grade4 = new Grade(students[1], subjects[4], "A");

            students[0].AddGrade(grade1);
            students[0].AddGrade(grade3);
            students[1].AddGrade(grade2);
            students[1].AddGrade(grade4);

            while (isRunning)
            {
                Console.WriteLine($"Select Student \n 1. {students[0].Name} \n 2. {students[1].Name}");
                var UserReply = Console.ReadLine();
                if (UserReply == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Student Information:");
                    students[0].PrintInfo();
                    
                }

                if (UserReply == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Student Information:");
                    students[1].PrintInfo();
                    
                }
                else
                {
                    Console.WriteLine("Not a valid option");
                }
            }

            

            
        }
    }
}
