using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // State - интерфейс состояния
    interface IBatteryState
    {
        void Charge(Battery battery);
        void Discharge(Battery battery);
    }

    // Context - объект, поведение которого динамически изменяется
    class Battery
    {
        public IBatteryState State { get; set; }

        public Battery(IBatteryState bs)
        {
            State = bs;
        }

        public void Charge()
        {
            State.Charge(this);
        }

        public void Discharge()
        {
            State.Discharge(this);
        }
    }

    // Конкретные реализации состояний
    class FullyChargedBatteryState : IBatteryState
    {
        public void Charge(Battery battery)
        {
            Console.WriteLine("Аккумулятор полностью заряжен");
            battery.State = new FullyChargedBatteryState();
        }

        public void Discharge(Battery battery)
        {
            Console.WriteLine("Частично разряжаем аккумулятор");
            battery.State = new PartiallyChargedBatteryState();
        }
    }
    class PartiallyChargedBatteryState : IBatteryState
    {
        public void Charge(Battery battery)
        {
            Console.WriteLine("Полностью заряжаем аккумулятор");
            battery.State = new FullyChargedBatteryState();
        }

        public void Discharge(Battery battery)
        {
            Console.WriteLine("Аккумулятор полностью разряжен");
            battery.State = new FullyDischargedBatteryState();
        }
    }
    class FullyDischargedBatteryState : IBatteryState
    {
        public void Charge(Battery battery)
        {
            Console.WriteLine("Частично заряжаем аккумулятор");
            battery.State = new PartiallyChargedBatteryState();
        }

        public void Discharge(Battery battery)
        {
            Console.WriteLine("Аккумулятор полностью разряжен");
            battery.State = new FullyDischargedBatteryState();
        }
    }
}
