using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Command
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver - получатель
    class Phone
    {
        public void Call()
        {
            Console.WriteLine("Вызов абонента");
        }
        public void EndCall()
        {
            Console.WriteLine("Завершние вызова");
        }

        public void SendMessege()
        {
            Console.WriteLine("Отпрака сообщения");
        }

        public void CancelMessege()
        {
            Console.WriteLine("Отмена отправки");
        }
    }

    // ConcreteComand - конретная реализация команды
    class PhoneCallCommand: ICommand
    {
        Phone phone;
        
        public PhoneCallCommand(Phone mPhone)
        {
            phone = mPhone;
        }

        public void Execute()
        {
            phone.Call();
        }

        public void Undo()
        {
            phone.EndCall();
        }
    }

    class SendMessegeCommand: ICommand
    {
        Phone messege;
        
        public SendMessegeCommand(Phone mes)
        {
            messege = mes;
        }

        public void Execute()
        {
            messege.SendMessege();
        }

        public void Undo()
        {
            messege.CancelMessege();
        }
    }

    // Invoker - инициатор
    class Finger
    {
        ICommand touch;
        
        public Finger()
        {

        }

        public void SetCommand(ICommand command)
        {
            touch = command;
        }

        public void PressButton()
        {
            touch.Execute();
        }

        public void PressUndo()
        {
            touch.Undo();
        }
    }
}
