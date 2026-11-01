namespace Lesson3_OOP
{
    // abstract - מופשט
    // מחלקה שא"א ליצור ממנה מופעים
    // נוצרה רק בשביל שיוכלו לרשת ממנה
    public abstract class Employee //: object
    {
        // private   - ניתן לגשת רק באותה מחלקה
        // public    - ניתן לגשת מכל מקום
        // protected - ניתן לגשת מאותה מחלקה ומהיורשות

        // גם במחלקת אב
        // protected-לא תמיד ניצור את התכונות כ
        // protected-ורק אם אין ברירה נשתמש ב private-אלא נשתמש ב
        private string username;
        protected double baseSalary;

        public Employee(string name, double baseSalary)
        {
            this.username = name;
            this.baseSalary = baseSalary;
        }

        public string GetName()
        {
            return username;
        }

        // virtual - ניתן לדרוס בבנים
        // וכך הפעולה שמופעלת תהיה לפי המופע ולא לפי המצביע
        public virtual double CalcSalary()
        {
            return 0;
        }
        //public abstract double CalcSalary();

        // override - דורסים את הפעולה ממחלקת אובגקט
        // שהיא מחלקת הבסיס לכל המחלקות
        // virtual ולא override ולכן נכתוב 
        public override string ToString()
        {
            return $"{nameof(username)}: {username}, base salary: {baseSalary}";
        }

        public override bool Equals(object obj)
        {
            // obj הוא מסוג מחלקת אובגקט
            // username ולכן הוא לא מכיל
            // return this.username == obj.username;

            // חובה לבצע המרה ואז לבדוק
            Employee other = obj as Employee;
            return other != null && other.username == username && other.baseSalary == baseSalary;
        }
    }
}
