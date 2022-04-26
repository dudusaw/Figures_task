using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_task.src
{
    /**
     * Вычисление площади фигуры без знания типа фигуры в compile-time
     * Возможно здесь речь про run-time
     * Если есть например только строка "22 33 44" и нужно найти сначала тип фигуры
     * Предполагается, что такие данные отличаются количеством чисел для разных типов фигур, и сами числа разделяются пробелом
     */
    public class FigureDecider
    {

        public static IFigure Decide(string data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("Wrong data");
            }
            string[] numbers = data.Split(' ');
            if (numbers.Length == 1)
            {
                return new Circle(Double.Parse(numbers[0]));
            } else if (numbers.Length == 3)
            {
                return new Triangle(Double.Parse(numbers[0]), Double.Parse(numbers[1]), Double.Parse(numbers[2]));
            } else
            {
                throw new ArgumentException("Can not determine figure");
            }
        }
    }
}
