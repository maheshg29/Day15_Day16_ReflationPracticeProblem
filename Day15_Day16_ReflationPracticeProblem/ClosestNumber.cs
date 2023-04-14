using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Day16_ReflationPracticeProblem
{
    public class ClosestNumber
    {
        public static int FindClosestEvenNumber(int givenNumber)
        {
            if (givenNumber > 0)
            {
                int i = 0;
                if (givenNumber == 0)
                {
                    return 2;
                }

                for (i = givenNumber + 1; i < givenNumber + 100; i++)
                {
                    int[] digitArray = ClosestNumber.getDigit(i);
                    if (i % 2 == 0)
                    {
                        bool allOk = true;
                        for (int j = 0; j < digitArray.Length; j++)
                        {
                            if (digitArray[j] % 2 != 0)
                            {
                                allOk = false;
                                break;
                            }
                        }
                        if (allOk)
                        {
                            return i;
                        }
                    }
                }
                return 0;
            }
            else 
            {
                for (int i = givenNumber + 1; i < givenNumber + 100; i++)
                {
                    i = Math.Abs(i); // for remove -ve sing
                    int[] digitArray = ClosestNumber.getDigit(i);
                    if (i % 2 == 0)
                    {
                        bool allOk = true;
                        for (int j = 0; j < digitArray.Length; j++)
                        {
                            if (digitArray[j] % 2 != 0)
                            {
                                allOk = false;
                                break;
                            }
                        }
                        
                        if (allOk)
                        {
                            i *= -1;
                            return i;
                        }
                    }
                    i *= -1; // add -ve sing
                }
                return 0;
            }
        }
        public static int[] getDigit(int number)
        {
            int[] arry = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            return arry;            
        }
    }
}
