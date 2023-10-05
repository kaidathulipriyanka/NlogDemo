using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    public class AddNumbers
    {
        private readonly NLog nlog = new NLog { };
        public int Sum(int firstNumber, int SecondNumber)
        {
            if (firstNumber == 0 || SecondNumber == 0)
            {
                nlog.LogDebug("Debug unsucessful : Sum()");
                nlog.LogError("Input Number can't be zero ");
                nlog.LogWarn("firstNumber or SecondNumber shoud not equal to 0");

            }
            
                int result = firstNumber + SecondNumber;
                nlog.LogDebug("Debug successful : sum()");
                nlog.LogInfo("sum Method passed , result : " + result);
                return result;
           
           
        }
    }
}
