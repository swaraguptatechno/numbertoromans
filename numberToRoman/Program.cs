using System;
using System.Collections.Generic;

namespace numberToRoman
{
    class Program
    {
        /* static void Main(string[] args)
         {
             string userInput;
             int num;
             Console.Write("Enter a number to convert it into a roman number");
             userInput = Console.ReadLine();
             while (userInput != ".")
             {
                 string ans = "";
                 num = Convert.ToInt32(userInput);
                 Int32[] value = { 1, 5, 10, 50, 100, 500, 1000 };
                 string[] roman = { "I", "V", "X", "L", "C", "D", "M" };
                 int flag = 1;
                 int i = 6;
                 while (num > 0)
                 {
                     if (num >= value[i])
                     {
                         num = num - value[i];
                         ans += roman[i];
                     }
                     else if (num >= value[i] - value[i - flag - 1])
                     {
                         num = num - (value[i] - value[i - flag - 1]);
                         ans += roman[i - 1 - flag] + roman[i];
                     }
                     else
                     {
                         i--;
                         flag = (flag == 1) ? 0 : 1;

                     }
                 }
                 Console.WriteLine(ans);
                 Console.Write("Enter a number to convert it into a roman number");
                 userInput = Console.ReadLine();
             }
         }*/
        static void Main(string[] args)
        {
            programget pg = new programget();
            var result = pg.getNumberToRoman(1231);
            Console.Write(result);
            Console.Read();


        }
    }

    public class programget { 
        public string getNumberToRoman(int num)
        {
            string[] roman = { "I", "V", "X", "L", "C", "D", "M" };
            string ans = "";
            int flag = 0;
            while (num > 0)
            {
                string tempans = "";
                if (flag == 3)
                {
                    while (num > 0)
                    {
                        tempans += roman[flag * 2];
                        num--;
                    }
                }
                else
                {
                    int temp = num % 10;
                    num = num / 10;
                    if (temp == 4)
                    {
                        tempans = roman[flag * 2] + roman[(flag * 2) + 1];
                    }
                    else if (temp == 9)
                    {
                        tempans = roman[flag * 2] + roman[(flag * 2) + 2];
                    }
                    else if (temp >= 5)
                    {
                        tempans += roman[(flag * 2) + 1];
                        temp -= 5;
                        while (temp > 0)
                        {
                            tempans += roman[(flag * 2)];
                            temp--;
                        }
                    }
                    else
                    {
                        while (temp > 0)
                        {
                            tempans += roman[flag * 2];
                            temp--;
                        }
                    }
                }
                ans = tempans + ans;
                flag++;
            }
        
            return ans;
            }
        
    }
}
