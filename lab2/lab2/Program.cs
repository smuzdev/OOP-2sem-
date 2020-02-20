using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Adapter \n" + (new String('-',30)));
            Person person = new Person();
            CoordinateMovement coordinateMovement = new CoordinateMovement();
            person.Move(coordinateMovement);

            CellMovement cellMovement = new CellMovement();
            ICoordinateMovement cell = new CellToCoordinateMovement(cellMovement);
            person.Move(cell);
            Console.WriteLine();
            #endregion

            #region Task 2
            Console.WriteLine("Decorator \n" + (new String('-', 30)));
            Human human1 = new Englishmen();
            human1 = new UmbrellaHuman(human1);
            Console.WriteLine(human1.GetWeather() + human1.Name);

            Human human2 = new Chinese();
            human2 = new JaketHuman(human2);
            Console.WriteLine(human2.GetWeather() + human2.Name);
            Console.WriteLine();
            #endregion

            #region Task 3
            Console.WriteLine("Composite \n" + (new String('-', 30)));
            Map worldMap = new Map { Title = "Карта мира" };
            worldMap.AddComponent(new MapComponent { Title = "Карта континента" });
            worldMap.AddComponent(new MapComponent { Title = "Карта государства" });
            worldMap.AddComponent(new MapComponent { Title = "Карта города" });
            Map map = new Map { Title = "Новая карта" };
            map.AddComponent(worldMap);
            map.Draw();
            var find = map.Find("Карта государства");
            find.Draw();
            #endregion
        }
    }
}
