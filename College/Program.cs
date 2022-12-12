using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllLibrary;

namespace College
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Specialty specialtyProgrammist = new Specialty(name: "09.02.07 Программист", countStudent: 25, studyPeriod: "3 года 10 месяцев");
            // specialtyProgrammist.Show();
            Specialty specialtyAgent = new Specialty(name: "Техническая поддержка", countStudent: 35, studyPeriod: "2 года 10 месяцев");
            // specialtyAgent.Show();

            Сollege college = new Сollege(name: "Первый МОК", address: "г. Москва, Староватутинский проезд, 6");
            college.AddSpec(specialtyProgrammist);
            college.AddSpec(specialtyAgent);

            college.Show();

            Console.ReadLine();
        }
    }
}
