using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    // Target
    interface ICoordinateMovement
    {
        void CoordinateMove();
    }

    // класс, к которому надо адаптировать другой класс
    class CoordinateMovement : ICoordinateMovement
    {
        public void CoordinateMove()
        {
            Console.WriteLine("Введите координаты X и Y: ");
            int x, y;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Неверно введено значение \nВведите координату X еще раз: ");
            }
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out y))
                    break;
                else
                    Console.WriteLine("Неверно введено значение \nВведите координату Y еще раз: ");
            }
            Console.WriteLine($"Человек перемещается на координату ({x},{y}).");
        }
    }

    // Клиент (Client)
    class Person
    {
        public void Move(ICoordinateMovement person)
        {
            person.CoordinateMove();
        }
    }

    // Target
    interface ICellMovement
    {
        void CellMove();
    }

    // Адаптируемый класс (Adaptee)
    class CellMovement : ICellMovement
    {
        public void CellMove()
        {
            Console.WriteLine("Введите количество клеток");
            int x;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Неверно введено значение \nВведите кол-во клеток еще раз: ");
            }
            Console.WriteLine($"Человек перемещается на количество клеток: {x}");
        }
    }

    // Адаптер (Adapter)
    class CellToCoordinateMovement : ICoordinateMovement
    {
        CellMovement cellMovement;
        public CellToCoordinateMovement(CellMovement movement)
        {
            cellMovement = movement;
        }

        public void CoordinateMove()
        {
            cellMovement.CellMove();
        }
    }
}


