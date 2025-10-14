using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal interface ITargetLockControl
    {
        int TargetX { get; set; }
        int TargetY { get; set; }
        int CurrentX { get; }
        int CurrentY { get; }
        void SetTarget(int x, int y);
        int GetXCoordinate();
        int GetYCoordinate();
    }
}
