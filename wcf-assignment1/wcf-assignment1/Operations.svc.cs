using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    public class Operations : IOperations
    {
        /// <summary>
        /// Check if number is prime
        /// </summary>
        /// <param name="number">Integer to check for</param>
        /// <returns>true if number i prime, false otherwise</returns>
        public bool CheckPrime(int number)
        {
            int count = 0;
            for (int i = 1; i <=number; i++)
            {
                if (number%i==0)
                {
                    ++count;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Do sum of digits
        /// </summary>
        /// <param name="number">Number to find sum</param>
        /// <returns>Sum of digits</returns>
        public int DoSum(int number)
        {
            int sum = 0;
            int rem = 0;
            int num = number;

            while (num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            return sum;
        }
        /// <summary>
        /// Reverse a string
        /// </summary>
        /// <param name="value">String to reverse</param>
        /// <returns>Reversed string</returns>
        public string ReverseString(string value)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = value.Length - 1; i >= 0; i--)
            {
                sb.Append(value[i]);
            }

            return sb.ToString();
        }
        /// <summary>
        /// Wrap text provided with provided HTML tag
        /// </summary>
        /// <param name="tag">HTML tag</param>
        /// <param name="value">Text to wrap</param>
        /// <returns></returns>
        public string CreateHtml(string tag, string value)
        {
            string startTag="<"+tag+">";
            string endTag="</"+tag+">";

            return $"{startTag}{value}{endTag}";
        }

        /// <summary>
        /// Sort numbers
        /// </summary>
        /// <param name="type">Ascending or Descending</param>
        /// <param name="arrNumbers">Array of Numbers</param>
        /// <returns>Sorted array based on type provided</returns>
        public int[] SortNumbers(string type, int[] arrNumbers)
        {
           
            if (type.Equals("Ascending"))
            {
                for (int i = 0; i <5; i++)
                {
                    for (int j = i+1; j <5; j++)
                    {
                        if (arrNumbers[j] < arrNumbers[i])
                        {
                            int temp = arrNumbers[i];
                            arrNumbers[i] = arrNumbers[j];
                            arrNumbers[j] = temp;
                        }
                    }
                }
                return arrNumbers;

            }
            if (type.Equals("Descending"))
            {
                return arrNumbers.OrderByDescending(c => c).ToArray();
            }
            else
            {
                return arrNumbers;
            }

        }
    }
}
