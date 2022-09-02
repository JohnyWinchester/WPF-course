using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveewDZ06
{
    /** В директории лежат файлы. По структуре они содержат три числа, разделенные пробелами.
     * Первое число — целое, обозначает действие: 1- — умножение и 2 — деление.
     * Остальные два — числа с плавающей точкой. 
     * Задача: написать многопоточное приложение, выполняющее эти действия над числами и сохраняющее результат в файл result.dat. 
     * Файлов в директории заведомо много.*/
    class Program
    {
        static void Main(string[] args)
        {
            ResultDatFile datFile = new ResultDatFile(@"E:\GeekBrains\C# 03\AndreyMatveewDZ06\Files");
            Console.ReadKey();
        }
    }
}
