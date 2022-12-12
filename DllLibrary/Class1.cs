using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
{
    // класс колледж 
    public class Сollege
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Specialty> SpecialtyList = new List<Specialty>();
        public Сollege(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void Show()
        {
            if (SpecialtyList.Count == 0) Console.WriteLine($"Колледж - {Name} - расположен по адресу: {Address}. Специальности не указаны.");
            else
            {
                Console.WriteLine($"Колледж - {Name} - расположен по адресу: {Address}.\nСписок специальностей: ");
                foreach (Specialty specialty in SpecialtyList) specialty.Show();
            }
        }

        // добавление специальнстей в колледж
        public void AddSpec(Specialty specialty)
        {
            SpecialtyList.Add(specialty);
            // Console.WriteLine("Добавлена новая специальность в колледж.");
        }
    }

    // класс специальность
    public class Specialty
    {
        public string Name {get; set; }
        public int CountStudent { get; set; }

        // период обучения
        public string StudyPeriod { get; set; }

        public Specialty(string name, int countStudent, string studyPeriod)
        {
            Name = name;
            CountStudent = countStudent;
            StudyPeriod = studyPeriod;
        }

        public void Show()
        {
            Console.WriteLine($"Специальность {Name} имеет срок обучения {StudyPeriod} и количество студентов {CountStudent}");
        }
    }
}
