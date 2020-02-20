using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Type
    {
        public string Name { get; set; }
    }

    class Material
    {
        public string Name { get; set; }
    }

    class Color
    {
        public string Name { get; set; }
    }

    class Detector
    {
        public Type Type { get; set; }
        public Material Material { get; set; }
        public Color Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Type != null)
                sb.Append("Тип извещателя: " + Type.Name + "\n");
            else
            {
                sb.Append("Тип извещателя: неизвестен \n");
            }
            if (Material != null)
                sb.Append("Материал: " + Material.Name + "\n");
            else
            {
                sb.Append("Материал: неизвестен \n");
            }
            if (Color  != null)
                sb.Append("Цвет: " + Color.Name + " \n");
            else
            {
                sb.Append("Цвет: неокрашен \n");
            }
            return sb.ToString();
        }
    }

    // абстрактный класс строителя
    abstract class DetectorBuilder
    {
        public Detector Detector { get; private set; }
        public void CreateDetector()
        {
            Detector = new Detector(); 
        }
        public abstract void SetType();
        public abstract void SetMaterial();
        public abstract void SetColor();
        
    }
    
    // производитель
    class Fabricator
    {
        public Detector Make(DetectorBuilder detectorBuilder)
        {
            detectorBuilder.CreateDetector();
            detectorBuilder.SetType();
            detectorBuilder.SetMaterial();
            detectorBuilder.SetColor();
            return detectorBuilder.Detector;
        }
    }
    
    //производитель дымового извещателя
    class SmokeDetectorBuilder : DetectorBuilder
    {
        public override void SetType()
        {
            this.Detector.Type = new Type { Name = "Дымовой" };
        }
        public override void SetMaterial()
        {
            this.Detector.Material = new Material { Name = "Пластик"};
        }
        public override void SetColor()
        {
            this.Detector.Color = new Color { Name = "Белый" };
        }
    }

    //производитель теплового извещателя
    class ThermalDetectorBuilder : DetectorBuilder
    {
        public override void SetType()
        {
            this.Detector.Type = new Type { Name = "Тепловой" };
        }
        public override void SetMaterial()
        {
            this.Detector.Material = new Material { Name = "Пластик" };
        }
        public override void SetColor()
        {
            this.Detector.Color = new Color { Name = "Бежевый" };
        }
    }
    
    // производитель извещателя пламени
    class FlameDetectorBuilder : DetectorBuilder
    {
        public override void SetType()
        {
            this.Detector.Type = new Type { Name = "Пламени" };
        }
        public override void SetMaterial()
        {
            this.Detector.Material = new Material { Name = "Металл" };
        }
        public override void SetColor()
        {
            this.Detector.Color = new Color { Name = "Красный" };
        }
    }

}
