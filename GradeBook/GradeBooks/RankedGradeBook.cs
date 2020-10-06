namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool second) : base(name, second)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        override public char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5) throw new System.InvalidOperationException();

            int TwentyPercent = Students.Count / 5;

            int Higher = 0;
            foreach (var student in Students)
            {
                if (student.AverageGrade > averageGrade) Higher++;
            }

            //int Result = Higher / TwentyPercent;

            switch(Higher / TwentyPercent)
            {
                case 0:
                    return 'A';
                case 1:
                    return 'B';
                case 2:
                    return 'C';
                case 3:
                    return 'D';
                default:
                    return 'F';
            }


        }

        override public void CalculateStatistics()
        {
            if (Students.Count < 5) System.Console.WriteLine("Ranked grading requires at least 5 students.");
            else base.CalculateStatistics();
        }

        override public void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5) System.Console.WriteLine("Ranked grading requires at least 5 students.");
            else base.CalculateStudentStatistics(name);
        }


    }
}
