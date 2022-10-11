using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Operations : IOperations
    {
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
        public string ReverseString(string value)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = value.Length - 1; i >= 0; i--)
            {
                sb.Append(value[i]);
            }

            return sb.ToString();
        }
        public string CreateHtml(string tag, string value)
        {
            string startTag="<"+tag+">";
            string endTag="</"+tag+">";

            return $"{startTag}{value}{endTag}";
        }

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
