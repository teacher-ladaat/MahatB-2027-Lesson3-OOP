using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_OOP
{
    // קודם הורשה, אח"כ כל הממשקים
    // IComparable - ממשק שמור שיודע להשוות בין 2 אוביקטים
    // רק אם מממשים אותו ניתן למיין/לחפש בחיפוש בינארי
    internal class Teacher : Employee, IComparable<Teacher>
    {
        private string[] subjects;
        private int subjectIndex;

        public Teacher(string name, double salaryPerHour, int hours, int maxSubjects = 10)
            :base(name, salaryPerHour * hours)
        {
            subjects = new string[maxSubjects];
            subjectIndex = 0;
        }

        public void AddSubject(string subject)
        {
            if (subjectIndex == subjects.Length)
                return;

            subjects[subjectIndex++] = subject;
        }

        public override double CalcSalary()
        {
            return baseSalary + subjectIndex * 100;
        }

        public int CompareTo(Teacher other)
        {
            // this - other
            // חיובי - הראשון גדול יותר
            // שלילי - הראשון קטן יותר
            // אפס - שווים

            //return this.subjectIndex - other.subjectIndex;
            return this.GetName().CompareTo(other.GetName());
        }
    }
}
