using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    //создаем класс делегата
    delegate int AfirOp(int);
    class Class1
    {

        
        int Metod1(int x)
        {
            return x * 2;
        }
        int Metod2(int x)
        {
            return x * 3;
        }

        public Class1()
        {
            arifmeticOp = Metod1;
        }
    }
}
