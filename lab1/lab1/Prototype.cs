using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class Feature
    {
        public abstract Feature Clone();
        public abstract void GetInfo();
        protected static int count;
        protected int ID;

    }

    class Asian : Feature
    {
        double eyeWidth;
        protected new static int count;

        public Asian(double w)
        {
            eyeWidth = w;
            ID = ++count;
        }
        public override Feature Clone()
        {
            return new Asian(this.eyeWidth);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Глаз {ID}-го азиата с шириной: {eyeWidth}см");
        }
    }
    class European : Feature
    {
        string skinColor;
        protected new static int count;

        public European(string sc)
        {
            skinColor = sc;
            ID = ++count;
        }
        public override Feature Clone()
        {
            return new European(this.skinColor);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"{skinColor} цвет кожи у {ID}-го европейца");
        }
    }
}
