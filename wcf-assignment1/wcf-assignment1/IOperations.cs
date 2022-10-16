using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    [ServiceContract]
    public interface IOperations
    {
        [OperationContract]
        bool CheckPrime(int number);

        [OperationContract]
        int DoSum(int number);

        [OperationContract]
        string ReverseString(string value);

        [OperationContract]
        string CreateHtml(string tag, string value);
        [OperationContract]
        int[] SortNumbers(string type, int[] arrNumbers);

    }

}
