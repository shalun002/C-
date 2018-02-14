using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*  1. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними. */
            //
            //int a = 1, b = 2, c = 3;
            //Console.Write(a);
            //Console.Write(" ");
            //Console.Write(b);
            //Console.Write(" ");
            //Console.Write(c);
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  2. Вывести на экран числа 5, 10 и 21 одно под другим. */
            //
            //int a = 5, b = 10, c = 21;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  3. Дано расстояние в сантиметрах.Найти число полных метров в нем. */
            //
            //int a = 200;
            //Console.WriteLine(a/100);
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  4. С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период ? */
            //
            //int a = 234;
            //Console.WriteLine(a / 7 + " Недели " + "и " +  a / 7 % 10 + " дня");
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  5. Дано двузначное число. Найти:
            //     a.число десятков в нем;
            //     b.число единиц в нем;
            //     c.сумму его цифр;
            //     d.произведение его цифр */
            //
            //Console.WriteLine("Дано трехзначное число: - 234 \n");
            //int a = 234;
            //Console.WriteLine(a / 100 % 10 + " - число сотен" + ", " + a / 10 % 10 + " - число десятков" + ", " + a % 10 + " - число единиц");
            //Console.WriteLine((a / 100 % 10) + (a / 10 % 10) + (a % 10) + " - сумма его цифр");
            //Console.WriteLine((a / 100 % 10) * (a / 10 % 10) * (a % 10) + " - произведение его цифр");
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  6. Вычислить значение логического выражения при следующих значениях логических величин А, В и С: 
            //                   А = Истина, В = Ложь, С = Ложь: 
            //                   a. А или В; 
            //                   b. А и В;
            //                   c. В или С. */
            //
            //bool A = true;
            //bool B = false;
            //bool C = false;
            //bool sum;
            //
            //sum = (A || B);
            //Console.WriteLine(sum);
            //sum = (A && B);
            //Console.WriteLine(sum);
            //sum = (B || C);
            //Console.WriteLine(sum);
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  7. Даны радиус круга и сторона квадрата. У какой фигуры площадь больше? */

            //float r = 4;
            //float lenght = 4;
            //double resultR = 3.14 * (r * r); ;
            //double resultL = lenght * lenght; ;
            //
            //Console.WriteLine("Радиус круга равен: " + r);
            //Console.WriteLine("Сторона квадрата равна: " + lenght + "\n");
            //
            //Console.WriteLine("Площадь круга равна: " + resultR);
            //Console.WriteLine("Площадь квадрата равна: " + resultL);
            //
            //Console.WriteLine();
            //
            //if (resultR > resultL)
            //{
            //    Console.WriteLine("Площадь круга больше площади квадрата.");
            //}
            //else
            //{
            //    Console.WriteLine("Площадь квадрата больше площади круга.");
            //}
            //
            //Console.ReadLine();

            // ===========================================================================================================

            /*  8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность ?  */

            //float AmountCopper = 15;                                   // объем меди
            //float MassCopper = 8;                                      // масса меди
            //float ResultDensityCopper = MassCopper / AmountCopper;     // формула плотности материала p=m/V где m – масса (MassCopper), V – величина объема (AmountCopper)
            //
            //float AmountIron = 24;                                    // объем железо
            //float MassIron = 13;                                      // масса железа
            //float ResultDensityIron = MassIron / AmountIron;          // формула плотности материала p=m/V где m – масса (MassIron), V – величина объема (AmountIron) 
            //
            //Console.WriteLine("Железо имеет плотность: " + ResultDensityIron + " г/см3");
            //Console.WriteLine("Железо имеет плотность: " + ResultDensityCopper + " г/см3");
            //Console.WriteLine();
            //
            //if (ResultDensityIron > ResultDensityCopper)
            //{
            //    Console.WriteLine("Железо имеет большую плотность.");
            //}
            //else
            //{
            //    Console.WriteLine("Медь имеет большую плотность.");
            //}
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток? */
            //
            //float ResistanceOne = 75;                                  // сопротивление один
            //float VoltageOne = 15;                                      // напряжение один
            //float CurrentOne = VoltageOne / ResistanceOne;              // I = U/R (ток = напряжение / сопративление).
            //
            //float ResistanceTwo = 22;                                  // сопротивление один
            //float VoltageTwo = 12;                                      // напряжение один
            //float CurrentTwo = VoltageTwo / ResistanceTwo;              // I = U/R (ток = напряжение / сопративление). 
            //
            //Console.WriteLine("Сила тока на первом участке цепи: " + CurrentOne);
            //Console.WriteLine("Сила тока на втором участке цепи: " + CurrentTwo);
            //Console.WriteLine();
            //
            //if (CurrentOne > CurrentTwo)
            //{
            //    Console.WriteLine("Сила тока на первом участке цепи больше, чем на втором.");
            //}
            //if (CurrentOne < CurrentTwo)
            //{
            //    Console.WriteLine("Сила тока на втором участке цепи больше, чем на первом.");
            //}
            //else
            //{
            //    Console.WriteLine("Они равны");
            //}
            //
            //Console.WriteLine();
            //Console.WriteLine("По первому участку протекает меньший ток");
            //
            //Console.ReadLine();

            // ===========================================================================================================

            ///*  10. Напечатать "столбиком": 
            //            a.	все целые числа от 20 до 35;
            //            b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            //            c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
            //            d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a). */

            //for (int i = 20; i <= 35; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("Введите конечное значение: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num <= 10)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    for (int i = 10; i < num; i++)
            //    {
            //        Console.Write((i * i) + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("Введите начальное значение: ");
            //int numFirst = int.Parse(Console.ReadLine());

            //if (num >= 50)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    for (int i = numFirst; i < 50; i++)
            //    {
            //        Console.Write((i * i * i) + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("Введите начальное значение: ");
            //int numFirstTwo = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.WriteLine("Введите конечное значение: ");
            //int numSecond = int.Parse(Console.ReadLine());

            //for (int i = numFirstTwo; i < numSecond; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
}