using System;

namespace Next
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetIntInput("Please input a number to solve");
            int[] valueList = ValueAsList(value);
            string strValue = FormatList(valueList);
            if (strValue == value.ToString())
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(strValue);
            }
        }
        static int GetIntInput(string inputMessage)
        {
            int userInput = 0;
            while (true)
            {
                Console.WriteLine($"{inputMessage}\n");
                string rawInput = Console.ReadLine();
                try
                {
                    userInput = int.Parse(rawInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid input\n");
                }
            }
            return userInput;
        }
        static int[] ValueAsList(int value)
        {
            string newValue = Convert.ToString(value);
            int[] valueList = new int[newValue.Length];
            int x = 0;
            foreach (char character in newValue)
            {
                string newCharacter = character.ToString();
                int newCharacter2 = Convert.ToInt32(newCharacter);
                valueList[x] = newCharacter2;
                x++;
            }
            return valueList;
        }
        static string FormatList(int[] valueList)
        {
            Array.Sort(valueList);
            Array.Reverse(valueList);
            string newValue = String.Join("", valueList);
            return newValue;
        }
    }
}
