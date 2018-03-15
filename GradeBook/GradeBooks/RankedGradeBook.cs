using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException();

            if (averageGrade >= 90)
                return 'A';
            else if (averageGrade < 90 && averageGrade >= 75)
                return 'B';
            else if (averageGrade < 75 && averageGrade >= 50)
                return 'C';
            else if (averageGrade < 50 && averageGrade >= 25)
                return 'D';

            return 'F';
        }
    }
}
