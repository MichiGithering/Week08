using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class Freezer : ITempControl, ISwitchControl

    {
        public bool IsOn;

        private int _TargetTemp = -25;
        private int _CurrentTemp = 0;
        private const int _MaxTemp = 0;
        private const int _MinTemp = -35;

        public int TargetTemp { get => _TargetTemp; set => _TargetTemp = value; }

        public int CurrentTemp => _CurrentTemp;

        public int MaxTemp => _MaxTemp;

        public int MinTemp => _MinTemp;

        bool ISwitchControl.IsOn { get => IsOn; set => IsOn = value; }

        public int GetCurrentTemp()
        {
            if(!IsOn)
            {
                Console.WriteLine("Cannot get current temperature.");
            }
            else
            {
                while (_CurrentTemp != _TargetTemp)
                {
                    if (_CurrentTemp < _TargetTemp)
                    {
                        _CurrentTemp++;
                    }
                    else if (_CurrentTemp > _TargetTemp)
                    {
                        _CurrentTemp--;
                    }
                    Console.WriteLine("Current temperature is " + _CurrentTemp + "C");
                    ;
                }
            }

            return _CurrentTemp;
        }

        public void SetTemp(int Temp)
        {
            if (!IsOn)
            {
                Console.WriteLine("Cannot set temperature.");
            }
            else
            {
                _TargetTemp = Math.Max(MinTemp, Math.Min(Temp, MaxTemp));
            Console.WriteLine("Target temperature set to " + _TargetTemp + "C");
                GetCurrentTemp();
            }
        }

        public void TurnOn()
        {
            ToggleSwitch();
        }
        public void TurnOff()
        {
            ToggleSwitch();
        }

        public void ToggleSwitch()
        {
            IsOn =!IsOn;
            string result = (IsOn) ? "Freezer have been turn on. " : "Freezer off.";
            Console.WriteLine(result);
        }
    }
}