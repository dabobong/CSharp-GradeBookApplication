using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBookBaseGradeBook : BaseGradeBook
    {
        public StandardGradeBookBaseGradeBook(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Standard;
        }
    }
}
