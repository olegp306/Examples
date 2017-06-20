using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateToEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //подписались на движение в Student 
            student.student_Moving += TellAboutMovingMethod;

            student.Move("Я пошел....");

            Console.ReadKey();

        }

        private static void TellAboutMovingMethod(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}
