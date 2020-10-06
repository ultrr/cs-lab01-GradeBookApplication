namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool second) : base(name, second)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
