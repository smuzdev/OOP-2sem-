using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Human
    {
        public string Name { get; protected set; }
        public Human(string name)
        {
            this.Name = name;
        }
        public abstract string GetWeather();
    }

    class Englishmen: Human
    {
        public Englishmen() : base("англичанин")
        {
        }
        public override string GetWeather()
        {
            return "Пасмурно";
        }
    }

    class Chinese : Human
    {
        public Chinese() : base("китаец")
        {
        }
        public override string GetWeather()
        {
            return "Ясно";
        }   
    }

    abstract class HumanDecorator : Human
    {
        protected Human human;
        public HumanDecorator(string name, Human human) : base(name)
        {
            this.human = human;
        }
    }

    class UmbrellaHuman : HumanDecorator
    {
        public UmbrellaHuman(Human human) : base(human.Name + " с зонтиком", human)
        { }
        public override string GetWeather()
        {
            return "Идёт дождь, поэтому ";
        }
    }

    class JaketHuman : HumanDecorator
    {
        public JaketHuman(Human human) : base(human.Name + " в куртке", human)
        { }
        public override string GetWeather()
        {
            return "Сильный ветер, поэтому ";
        }
    }
}
