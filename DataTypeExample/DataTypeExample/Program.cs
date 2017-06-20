using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType valueType = new ValueType();
            valueType.prop1 = 1;
            valueType.reftype = new RefType1();
            valueType.reftype.prop1 = 1;
            Console.WriteLine("Создали тип значения  и изменили значения");
            Console.WriteLine("valueType.prop1={0}  and valueType.reftype.prop1={1}", valueType.prop1, valueType.reftype.prop1);
            Method(valueType);
            Console.WriteLine("Передали тип значения в метод ");
            Console.WriteLine("valueType.prop1={0}  and valueType.reftype.prop1={1}", valueType.prop1, valueType.reftype.prop1);

            Console.WriteLine("ЕСли  структуре есть ссылочный тип то он передаеться по ссылке !!! ");

            Console.WriteLine("------------------------");
            RefType2 refType2 = new RefType2();

            refType2.prop1 = 2;
            refType2.reftype = new RefType1();
            refType2.reftype.prop1 = 2;

            Console.WriteLine("Создали тиыТп ССЫЛКА");
            Console.WriteLine("refType2.prop1={0}  and refType2.reftype.prop1={1}", refType2.prop1, refType2.reftype.prop1);
            Method(refType2);
            Console.WriteLine("Передали тип ССЫЛКА в метод и изменили значения ");
            Console.WriteLine("refType2.prop1={0}  and refType2.reftype.prop1={1}", refType2.prop1, refType2.reftype.prop1);




            Console.WriteLine("ЕСли  структуре есть ссылочный тип то он передаеться по ссылке !!! ");



            Console.ReadKey();



        }

        private static void Method(RefType2 refType2)
        {
            refType2.prop1 = 555;
            refType2.reftype.prop1 = 555;
        }

        private static void Method(ValueType valueType)
        {
            valueType.prop1 = 555;
            valueType.reftype.prop1 = 555;

        }
    }
}
