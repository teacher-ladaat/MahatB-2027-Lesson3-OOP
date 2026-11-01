using System;

namespace Lesson3_OOP
{
    internal class Program
    {
        public static void PrintSalaries(Employee[] employees)
        {
            foreach (Employee e in employees)
            {
               Console.WriteLine(e.GetName() + " - " + e.CalcSalary());
            }
        }

        static void Main(string[] args)
        {
            // פולימורפיזם - רב צורתיות
            // ניתן להסתכל על אוביקט אחד בכמה צורות, לפי המחלקות מהם יורש
            // על מנהל ניתן להסתכל כמו על עובד

            // 1. יצירת מערך שמאחד בתוכו כמה סוגים של אוביקטים
            // 2. יצירת פעולה שמקבלת מצביע לאב שמכיל בתוכו מסוג הבנים

            Employee[] empList = new Employee[] {
                new Manager("michal", 100),
                new Teacher("sara", 120, 40),
                new Secratery("noa", 200),
                //new Employee("aaa", 8989), 
            };

            // שגיאת קומפילציה - ניתן לגשת רק לפעולות של עובד
            // empList[1].AddSubject("C#");

            // is - האם מסוג המחלקה או יורש ממנה
            if (empList[1] is Teacher)
            {
                // מותר לבצע המרה
                // מסתכלים על האוביקט כמורה
                // אם לא מצליח - זורק שגיאת ריצה
                Teacher t = (Teacher)empList[1];
                t.AddSubject("C#");
                t.AddSubject("C++");
                t.AddSubject("C");
            }

            // אם לא מצליח - מחזיר נאל
            Teacher t1 = empList[1] as Teacher;
            
            // אם לא ניתן להמיר - שגיאת ריצה גישה לאוביקט שהוא נאל
            //t1.AddSubject("C#"); 

            if (t1 != null)
            {
                t1.AddSubject("C#");
                t1.AddSubject("C++");
                t1.AddSubject("C");
            }


            PrintSalaries(empList);

            // פולימורפיזם בממשקים
            IStack<int> stk = new MyStackArray<int>(100); // ????????
            while (!stk.IsEmpty())
            {
                int x = stk.Pop();
                Console.WriteLine(x);
            }

            Teacher[] arr = new Teacher[] {
                new Teacher("sara", 120, 40),
                new Teacher("aaa", 120, 40),
                new Teacher("bbb", 120, 40),
                new Teacher("ba", 120, 40),
            };
            Array.Sort(arr); // ממיין לפי הפעולה CompareTo


            foreach (Employee e in empList)
            { 
                // ברירת מחדל טו-סטרינג מדפיסה את סוג המופע

                //Console.WriteLine(e.ToString());
                Console.WriteLine(e); // זהה לשורה שלעיל
            }
        }
    }
}
