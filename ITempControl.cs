using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    interface ITempControl
    {
        int TargetTemp {  get; set; }
        int CurrentTemp { get; }
        int MaxTemp { get;}
        int MinTemp { get;}

        void SetTemp(int temp);
        int GetCurrentTemp();
    } 
}
