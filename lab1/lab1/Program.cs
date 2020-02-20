using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Задание №1");
            People chinese = new People(new ChinesePeopleFactory(), 5, 2);
            chinese.Health(2);
            chinese.Work(2);
            Console.WriteLine();

            People englishmen = new People(new EnglishPeopleFactory(), 3, 10);
            englishmen.Health(2);
            englishmen.Work(8);
            Console.WriteLine();
            #endregion

            #region Task 2
            Console.WriteLine("Задание №2");
            Planet planet = new Planet();
            planet.GiveName("Earth");
            Console.WriteLine("Планета - " + planet.PlanetName.Name + "\n");
            #endregion

            #region Task 3
            Console.WriteLine("Задание №3");
            Fabricator fabricator = new Fabricator();
            DetectorBuilder builder = new SmokeDetectorBuilder();
            Detector smokeDetector = fabricator.Make(builder);
            Console.WriteLine(smokeDetector.ToString());

            builder = new ThermalDetectorBuilder();
            Detector thermalDetector = fabricator.Make(builder);
            Console.WriteLine(thermalDetector.ToString());

            builder = new FlameDetectorBuilder();
            Detector flameDetector = fabricator.Make(builder);
            Console.WriteLine(flameDetector.ToString());
            #endregion

            #region Task 4
            Console.WriteLine("Задание №4");
            Feature feature = new Asian(1.30);
            Feature clonedFeature = feature.Clone();
            feature.GetInfo();
            clonedFeature.GetInfo();
            Console.WriteLine();

            feature = new European("Белый");
            clonedFeature = feature.Clone();
            feature.GetInfo();
            clonedFeature.GetInfo();
            Console.WriteLine();
            #endregion
        }
    }

    // Doctors
    abstract class Doctor
    {
        public abstract void Health();
    }

    // Types os doctors
    class ChineseDoctor : Doctor
    {
        public override void Health()
        {
            Console.WriteLine("Я болею коронавирусом");
        } 
    }

    class EnglishDoctor : Doctor
    {
        public override void Health()
        {
            Console.WriteLine("Я полностью здоров");
        }
    }

    // Teachers
    abstract class Teacher
    {
        public abstract void Work();
    }

    // Types of teachers
    class ChineseTeacher : Teacher
    {
        public override void Work()
        {
            Console.WriteLine("На больничном");
        }
    }

    class EnglishTeacher : Teacher
    {
        public override void Work()
        {
            Console.WriteLine("Я преподаю уроки в школе");
        }
    }

    // abstract PeopleFctory
    abstract class PeopleFactory
    {
        public abstract Doctor CreateDoctor();
        public abstract Teacher CreateTeacher();
    }

    // creating chinese people
    class ChinesePeopleFactory : PeopleFactory
    {
        public override Doctor CreateDoctor()
        {
            return new ChineseDoctor();
        }

        public override Teacher CreateTeacher()
        {
            return new ChineseTeacher();
        }
    }

    // creating english people
    class EnglishPeopleFactory : PeopleFactory
    {
        public override Doctor CreateDoctor()
        {
            return new EnglishDoctor();
        }

        public override Teacher CreateTeacher()
        {
            return new EnglishTeacher();
        }
    }

    class People
    {
        private List<Doctor> doctors = new List<Doctor>();
        private List<Teacher> teachers = new List<Teacher>();
        public People(PeopleFactory factory, int countDoctor, int countTeacher)
        {
            for (int i = 0; i < countDoctor; i++)
            {
                doctors.Add(factory.CreateDoctor());
            }
            for (int i = 0; i < countTeacher; i++)
            {
                teachers.Add(factory.CreateTeacher());
            }
        }

        public void Health(int n)
        {
            Console.WriteLine("Состоние здоровья: ");
            doctors[n-1].Health();
        }

        public void Work(int n)
        {
            teachers[n-1].Work();
        }
    }
}
