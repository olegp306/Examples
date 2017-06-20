using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateToEventExample
{
    class Student
    {

        //обобщенный делигат типа Ation. Возращает void  принимает string 
        public Action<string> student_Moving;
        //событие, по сути делегат с сигнатурой 
        public event EventHandler<MovingEventArgs> Moving;

        public void Move(string message)
        {
            Console.WriteLine(message);
            if (student_Moving != null)
                Console.WriteLine("Вы Подписаны на событие");
            else
                Console.WriteLine("Нет Подписки на событие");


            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                if (student_Moving != null)
                {
                    student_Moving("Вы подписаны на событие движения студента");
                }
            }

            Console.WriteLine("Процесс хождения завершился");
        }

    }
}
