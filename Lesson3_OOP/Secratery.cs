using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_OOP
{
    internal class Secratery : Employee
    {
        private int wordsPerMinute;

        /*
         * זה הבנאי שמתקבל במתנה
         * ולכן יש שגיאה גם אם אנו לא יוצרות אותו במפורש
        public Secratery()
            : base() // שליחה לבנאי של האבא
        {

        }
        */

        public Secratery(string name, int wordsPerMinute)
            : base(name, 5000)
        {
            this.wordsPerMinute = wordsPerMinute;
        }

        // override - דורס את הפעולה שבאבא
        public override double CalcSalary()
        {
            return baseSalary + wordsPerMinute / 10.0;
        }

        public override string ToString()
        {
            return base.ToString() + $", wordsPerMinute: {wordsPerMinute}";
        }
    }
}
