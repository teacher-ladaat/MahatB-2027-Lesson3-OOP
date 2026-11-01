using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_OOP
{
    internal class Manager : Employee
    {
        private double bonus;

        public Manager(string name, double bonus)
            :base(name, 100_000)
        {
            this.bonus = bonus;
        }

        public override double CalcSalary()
        {
            return baseSalary + bonus;
        }
    }
}
