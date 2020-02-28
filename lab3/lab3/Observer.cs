using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // IObserver: представляет наблюдателя
    interface IObserver
    {
        void Update(Object ob);
    }

    //IObservable - представляет наблюдаемый объект.
    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    // ConcreteObservable - конкретная реализация интерфейса IObservable
    class Updates : IObservable
    {
        UpdatesInfo uInfo; // информация об обновлениях

        List<IObserver> observers;
        public Updates()
        {
            observers = new List<IObserver>();
            uInfo = new UpdatesInfo();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(uInfo);
            }
        }

        public void Version()
        {
            Random rnd = new Random();
            uInfo.Android = rnd.Next(8, 10);
            uInfo.IOS = rnd.Next(11, 13);
            NotifyObservers();
        }
    }

    class UpdatesInfo
    {
        public int Android { get; set; }
        public int IOS { get; set; }
    }

    // ConcreteObserver - конкретная реализация интерфейса IObserver.
    class Samsung : IObserver
    {
        public string Name { get; set; }
        IObservable update;
        public Samsung(string name, IObservable obs)
        {
            this.Name = name;
            update = obs;
            update.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            UpdatesInfo uInfo = (UpdatesInfo)ob;

            if (uInfo.Android < 9)
                Console.WriteLine("Компания {0} выпускает обновление Android; Текущая версия: {1}", this.Name, uInfo.Android);
            else
                Console.WriteLine("Компания {0} уже обновила устройства; Версия: {1}", this.Name, uInfo.Android);
        }
        public void StopUpdate()
        {
            update.RemoveObserver(this);
            update = null;
        }
    }

    class Apple : IObserver
    {
        public string Name { get; set; }
        IObservable update;
        public Apple(string name, IObservable obs)
        {
            this.Name = name;
            update = obs;
            update.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            UpdatesInfo uInfo = (UpdatesInfo)ob;

            if (uInfo.IOS < 13)
                Console.WriteLine("Компания {0} обновяет устройства ;  Текущая версия IOS: {1}", this.Name, uInfo.IOS);
            else
                Console.WriteLine("Компания {0} уже обновила устройства;  Версия: {1}", this.Name, uInfo.IOS);
        }
    }
}
