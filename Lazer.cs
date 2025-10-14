using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class Lazer : ITempControl, ISwitchControl, ITargetLockControl

    {
        public bool IsOn;

        private int _TargetTemp;
        private int _CurrentTemp;
        private const int _MaxTemp = 100;
        private const int _MinTemp = 70;
        private int _TargetX;
        private int _TargetY; 
        private int _CurrentX;
        private int _CurrentY;
        public int TargetTemp { get => _TargetTemp; set => _TargetTemp = value; }

        public int CurrentTemp => _CurrentTemp;

        public int MaxTemp => _MaxTemp;

        public int MinTemp => _MinTemp;

        bool ISwitchControl.IsOn { get => IsOn; set => IsOn = value; }
        public int TargetX { get => _TargetX; set => _TargetX = value; }
        public int TargetY { get => _TargetY; set => _TargetY = value; }

        public int CurrentX => _CurrentX;

        public int CurrentY => _CurrentY;

        public int GetX()
        {
            if (!IsOn)
            {
                Console.WriteLine("Cannot get to X coordinate.");
            }
            else
            {
                while (_CurrentX != _TargetX)
                {
                    if (_CurrentX < _TargetX)
                    {
                        _CurrentX++;
                    }
                    else if (_CurrentX > _TargetX)
                    {
                        _CurrentX--;
                    }
                    Console.WriteLine("Current X target's coordinate is " + _CurrentX);
                    ;
                }
            }

            return _CurrentX;
        }

        public int GetY()
        {
            if (!IsOn)
            {
                Console.WriteLine("Cannot get to Y coordinate.");
            }
            else
            {
                while (_CurrentY != _TargetY)
                {
                    if (_CurrentY < _TargetY)
                    {
                        _CurrentY++;
                    }
                    else if (_CurrentY > _TargetY)
                    {
                        _CurrentY--;
                    }
                    Console.WriteLine("Current Y target's coordinate is " + _CurrentX);
                    ;
                }
            }

            return _CurrentY;
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
        public void ToggleSwitch()
        {
            IsOn = !IsOn;
            string result = (IsOn) ? "Freezer have been turn on. " : "Freezer off.";
            Console.WriteLine(result);
        }

        public void TurnOff()
        {
            ToggleSwitch();
        }

        public void TurnOn()
        {
            ToggleSwitch();
        }

        public void SetTarget(int x, int y)
        {
            if (!IsOn)
            {
                Console.WriteLine("Cannot set coordinate.");
            }
            else
            {
                _TargetX = x;
                Console.WriteLine("Target's X coordinate set to " + _TargetX);
                GetXCoordinate();

                _TargetY = y;
                Console.WriteLine("Target's Y coordinate set to " + _TargetY);
                GetYCoordinate();
            }
        }


        public int GetXCoordinate()
        {
            if (!IsOn)
            {
                Console.WriteLine("Cannot get to current coordinate.");
            }
            else
            {
                while (_CurrentX != _TargetX)
                {
                    if (_CurrentX < _TargetX)
                    {
                        _CurrentX++;
                    }
                    else if (_CurrentX > _TargetX)
                    {
                        _CurrentX--;
                    }
                    Console.WriteLine("Current target's X coordinate is " + _CurrentX);
                    ;
                } 
            }

            return _CurrentX;
        }

        public int GetYCoordinate()
        {
            if (!IsOn)
            {
                Console.WriteLine("Cannot get to current coordinate.");
            }
            else
            {

                while (_CurrentY != _TargetY)
                {
                    if (_CurrentY < _TargetY)
                    {
                        _CurrentY++;
                    }
                    else if (_CurrentY > _TargetY)
                    {
                        _CurrentY--;
                    }
                    Console.WriteLine("Current target's Y coordinate is " + _CurrentY);
                    ;
                }
            }
            return _CurrentY;
        }

        public int GetCurrentTemp()
        {
            if (!IsOn)
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
    }
}
