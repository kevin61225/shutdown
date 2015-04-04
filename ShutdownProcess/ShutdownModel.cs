using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownProcess
{
    class ShutdownModel
    {

        int _day;
        int _hour;
        int _min;
        int _sec;

        public ShutdownModel()
        {
            this.CleanTimer();
        }

        public int EvaluateCountdownTime()
        {
            return (_day * 86400) + (_hour * 3600) + (_min * 60) + _sec;
        }

        public string CountdownInfo()
        {
            string returnInfo = "系統將於 ";
            if (_day > 0)
            {
                returnInfo += _day + " 天 ";
            }
            if (_hour > 0)
            {
                returnInfo += _hour + " 小時 ";
            }
            if (_min > 0)
            {
                returnInfo += _min + " 分 ";
            }
            returnInfo += _sec + " 秒 後自動關機";
            return returnInfo;
        }

        public void CleanTimer()
        {
            _day = 0;
            _hour = 0;
            _min = 0;
            _sec = 0;
        }

        public void InitiateShutdown()
        {
            int countdownTime = this.EvaluateCountdownTime();
            ProcessStartInfo startinfo = new ProcessStartInfo("shutdown.exe", "-s -t " + countdownTime);
            Process.Start(startinfo);
        }

        public void AbordShutdown()
        {
            ProcessStartInfo startinfo = new ProcessStartInfo("shutdown.exe", "-a");
            Process.Start(startinfo);
        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        public int Sec
        {
            get { return _sec; }
            set { _sec = value; }
        }
    }
}
