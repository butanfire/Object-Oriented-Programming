namespace SULS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Models.Students;
    using Models.Trainders;

    public class SULSTest
    {
        static void Main(string[] args)
        {
            List<Person> classTests = new List<Person>();
            classTests.Add(new Person("Ivan", "Ivanov", 20));
            classTests.Add(new Person("Stefan", "Stefanov", 25));
            classTests.Add(new Student("Pesho", "Peshev", 25, "223456", 4.55));
            classTests.Add(new Student("Tisho", "Tishev", 35, "113456", 5.55));
            classTests.Add(new Trainer("Shop", "Shopov", 22));
            classTests.Add(new Trainer("Ship", "Shipov", 23));
            classTests.Add(new JuniorTrainer("Han", "Omurtag", 15));
            classTests.Add(new SeniorTrainer("Han", "Tervel", 35));
            classTests.Add(new CurrentStudent("Ivan", "Ivanov", 23, "110234", 4.50, "Programirane"));
            classTests.Add(new CurrentStudent("Ivan2", "Ivanov2", 22, "110334", 5.50, "Programirane"));
            classTests.Add(new DropoutStudent("Soft", "Universal", 22, "112334", 4.50, "no time"));
            classTests.Add(new GraduateStudent("Otlichen", "Portokalov", 31, "110110", 5.55));
            classTests.Add(new OnlineStudent("Wifi", "Kvartal", 23, "01101", 4.55, "OOP"));
            classTests.Add(new OnsiteStudent("Gabriel", "Iskrev", 17, "313211", 3.67, "Quality Code", 15));

            classTests.Add(new CurrentStudent("Ivan3", "Ivanov3", 23, "115334", 2.50, "Programirane"));
            classTests.Add(new CurrentStudent("Ivan3", "Ivanov3", 24, "116334", 3.33, "Programirane"));

            SeniorTrainer test = new SeniorTrainer("ivan", "strats", 10);
            test.CreateCourse("Test");
            test.DeleteCourse("Test");

            classTests.OfType<CurrentStudent>().
                Where(o => o.GetType() == typeof(CurrentStudent)).
                OrderByDescending(student => student.AverageGrade).
                ToList().ForEach(Console.WriteLine);
        }
    }
}
