using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Command  \n" + (new String('-', 30)));
            Phone phone = new Phone();
            Finger finger = new Finger();
            finger.SetCommand(new PhoneCallCommand(phone));
            finger.PressButton();
            finger.PressUndo();
            finger.SetCommand(new SendMessegeCommand(phone));
            finger.PressButton();
            finger.PressUndo();
            Console.WriteLine((new String('-', 30)));
            #endregion

            #region Task 2
            Console.WriteLine("State  \n" + (new String('-', 30)));
            Battery battery = new Battery(new FullyChargedBatteryState());
            battery.Charge();
            battery.Discharge();
            battery.Discharge();
            Console.WriteLine((new String('-', 30)));
            #endregion

            #region Task 3
            Console.WriteLine("Memento  \n" + (new String('-', 30)));
            MobileGame mobileGame = new MobileGame();
            mobileGame.Play();
            GameHistory game = new GameHistory();

            game.History.Push(mobileGame.SaveState());

            mobileGame.Play();

            mobileGame.RestoreState(game.History.Pop());

            mobileGame.Play();
            Console.WriteLine((new String('-', 30)));
            #endregion

            #region Task 4
            Console.WriteLine("Observer  \n" + (new String('-', 30)));
            Updates update = new Updates();
            Apple apple = new Apple("Apple", update);
            Samsung samsung = new Samsung("Samsung", update);
            // имитация торгов
            update.Version();
            samsung.StopUpdate();
            update.Version();
            Console.WriteLine((new String('-', 30)));
            #endregion
        }
    }
}
 