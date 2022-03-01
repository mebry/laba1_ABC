using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_ABC
{
    internal class Function
    {
        public static int InputIntValue(string line) =>
            ConsoleInput.ConsoleInputData.InputDataFromConsole<int>(line, 1, 2, 2, 16);

        public static string InputStringValue(string line) =>
            ConsoleInput.ConsoleInputData.InputDataFromConsole<string>(line, 1, 6, 1, 10000);

        public static (int OldNumberSystem, int ConvertNumberSystem, string Value) GetData(int? oldNumberSystem = null,
            int? convertNumberSystem = null, string? value = null)
        {
            int currentNumberSystem = oldNumberSystem ?? InputIntValue("The number system of the value:");
            string line = value ?? InputStringValue("Input value: ");
            int newNumberSystem = convertNumberSystem ?? InputIntValue("The number system to convert the value to:");

            return (currentNumberSystem, newNumberSystem, line);
        }

        public static void PrintResult(int oldNumberSystem, int convertNumberSystem,
            string value, string convertedValue)
        {
            Console.WriteLine($"Value: {value}, number system:{oldNumberSystem}");
            Console.WriteLine($"Converted value: {convertedValue}, number system:{convertNumberSystem} ");
        }

        public static void TheFirstTask()
        {
            Console.WriteLine("1 task");

            var firstTuple = GetData(null, 10, null);

            string convertedValue = Converter.UniversalConver(firstTuple.Value,
                firstTuple.OldNumberSystem, firstTuple.ConvertNumberSystem);

            PrintResult(firstTuple.OldNumberSystem, firstTuple.ConvertNumberSystem,
                firstTuple.Value, convertedValue);
        }

        public static void TheSecondTask()
        {
            Console.WriteLine("2 task");

            var secontTuple = GetData(10);

            string convertedValue = Converter.UniversalConver(secontTuple.Value,
                secontTuple.OldNumberSystem, secontTuple.ConvertNumberSystem);

            PrintResult(secontTuple.OldNumberSystem, secontTuple.ConvertNumberSystem,
                secontTuple.Value, convertedValue);
        }

        public static void TheThirdTask()
        {
            Console.WriteLine("3.1 task");

            string convertedValue = Converter.UniversalConver("1110000100001", 2, 16);

            PrintResult(2, 16, "1110000100001", convertedValue);
        }

        public static void TheFourthTask()
        {
            Console.WriteLine("3.2 task");

            string convertedValue = Converter.UniversalConver("16041", 8, 2);

            PrintResult(8, 2, "16041", convertedValue);
        }

        public static void TheFifthTask()
        {
            string valuePlus = "";
            string valueMinus = "";

            string firstValue = InputStringValue("Input value(number system: 6): ");
            string secondValue = InputStringValue("Input value(number system: 6): ");

            var values = GetValue(firstValue, secondValue);

            try
            {
                valuePlus = Converter.UniversalConver(
                    (values.firstValue + values.secondValue).ToString(), 10, 6);

                valueMinus = Converter.UniversalConver(
                    (values.firstValue - values.secondValue).ToString(), 10, 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"{firstValue} * {secondValue} = {valuePlus}");
            Console.WriteLine($"{firstValue} / {secondValue} = {valueMinus}");
        }

        public static void TheSixthTask()
        {
            string valueMultiplication = "";
            string valueDevide = "";

            string firstValue = InputStringValue("Input value(number system: 6): ");
            string secondValue = InputStringValue("Input value(number system: 6): ");

            var values = GetValue(firstValue, secondValue);

            try
            {
                valueMultiplication = Converter.UniversalConver(
                    (values.firstValue * values.secondValue).ToString(), 10, 6);

                valueDevide = Converter.UniversalConver(
                    (values.firstValue / values.secondValue).ToString(), 10, 6);
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"{firstValue} * {secondValue} = {valueMultiplication}");
            Console.WriteLine($"{firstValue} / {secondValue} = {valueDevide}");
        }

        private static (int firstValue, int secondValue) GetValue(string firstStr, string secondStr)
        {
            string firstConvertedValue = "";
            string secondConvertedValue = "";
            
            try
            {
                Converter.UniversalConver(firstStr, 6, 6);
                Converter.UniversalConver(secondStr, 6, 6);

                firstConvertedValue = Converter.UniversalConver(firstStr, 6, 10);
                secondConvertedValue = Converter.UniversalConver(secondStr, 6, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return (int.Parse(firstConvertedValue), int.Parse(secondConvertedValue));
            
        }
    }
}
