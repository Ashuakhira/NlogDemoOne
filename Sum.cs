using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    public class Sum
    {
        Nlog nlog = new Nlog();
        public void AddTheNumbers(int a,int b)
        {
            if(a==0||b==0)
            {
                nlog.LogDebugTheMessage("started the if condition");
                nlog.LogErrorThemessage("The Value Are Zero");
            }
            else
            {
                int c = a + b;
                nlog.LogDebugTheMessage("started the else condition");
                nlog.LogInfoTheMessage("The Value Are added succesfully");
                // Console.WriteLine("added the numbers");
            }


        }
    }
}
