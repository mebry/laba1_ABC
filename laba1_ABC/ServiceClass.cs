using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_ABC
{
    public class ServiceClass
    {
        

        public static void StartProcess()
        {
            bool isWork=true;
            while(isWork)
            {
                Console.Clear();
                Console.WriteLine("1)На выходе должно выводиться десятичное число, соответствующее введенному, из указанной СС.\n\n" +
                    "2)Из 10 системы в указанную\n" +
                    "На выходе должно выводиться число в новой системе счисления\n\n" +
                    "3)на входе строка состоящая из 0 и 1,\n" +
                    "На выходе должно выводиться 2 строки\n" +
                    "соответствующие шестнадцатеричному и двоичному представлению введенного числа\n\n" +
                    "4)на входе получает число в заданной системе счисления\n" +
                    "(для нечетных вариантов – восьмеричная, для четных – шестнадцатеричная).\n" +
                    "На выходе должна выводиться строка ASCII-символов, состоящую из 0 и 1,\n" +
                    "соответствующая записи эквивалентного двоичного числа.\n\n"  +
                    "5)Сложение и вычитание чисел в\n" +
                    "заданной системе счисления. В программе предусмотреть проверку ввода некорректных данных.\n\n" +
                    "6)Написать программу, осуществляющую умножение и деление чисел в заданной системе счисления.\n" +
                    "В программе предусмотреть проверку ввода некорректных данных.\n\n" +
                    "7)Выход");
                int number = ConsoleInput.ConsoleInputData.
                    InputDataFromConsole<int>("Input the task number: ", 1, 2, 0, 6);

                switch (number)
                {
                    case 1:
                        Function.TheFirstTask();
                        break;
                    case 2:
                        Function.TheSecondTask();
                        break;
                    case 3:
                        Function.TheThirdTask();
                        break;
                    case 4:
                        Function.TheFourthTask();
                        break;
                    case 5:
                        Function.TheFifthTask();
                        break;
                    case 6:
                        Function.TheSixthTask();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
                Console.ReadKey();
                
            }
        }
    }
}
