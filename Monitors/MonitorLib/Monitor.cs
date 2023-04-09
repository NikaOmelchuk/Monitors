using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorLib
{
    public class Director
    {
        string str = "";
        public string build(Builder b)
        {
            Monitor m = b.result();
            str = " - " + b.buildKorpus() + " \n - "
                + b.buildPlataYpr() + " \n - "
                + b.buildBlockPyt() + " \n - "
                + b.buildEkran() + " \n - "
                + m.dopelem();
            return str;
        }
    }

    public abstract class Monitor
    {
        public string Nazva;
        public int cod;
        public abstract string dopelem();
    }

    public class MonitorWithCam : Monitor
    {
        public string Nazva = "Монітор з камерою";
        public int cod = 1;
        public override string dopelem()
        {
            return "Камера";
        }
    }

    public class Monitor3D : Monitor
    {
        public string Nazva = "3D монітор";
        public int cod = 2;
        public override string dopelem()
        {
            return "3D плівка";
        }
    }

    public class SensorMonitor : Monitor
    {
        public string Nazva = "Сенсорний монітор";
        public int cod = 3;
        public override string dopelem()
        {
            return "Панель тачскріна";
        }
    }
}
