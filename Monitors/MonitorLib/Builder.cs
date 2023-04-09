using System;

namespace MonitorLib
{
    public interface Builder
    {
        public string buildKorpus();
        public string buildPlataYpr();
        public string buildBlockPyt();
        public string buildEkran();
        public Monitor result();
    }

    public class BuilderMonitorWithCam: Builder
    {
        public string buildKorpus()
        {
            return "Корпус";
        }
        public string buildPlataYpr()
        {
            return "Плата управління";
        }
        public string buildBlockPyt()
        {
            return "Блок живлення";
        }
        public string buildEkran()
        {
            return "Екран";
        }
        public Monitor result()
        {
            Monitor m = new MonitorWithCam();
            return m;
        }
    }

    public class BuilderMonitor3D : Builder
    {
        public string buildKorpus()
        {
            return "Корпус";
        }
        public string buildPlataYpr()
        {
            return "Плата управління";
        }
        public string buildBlockPyt()
        {
            return "Блок живлення";
        }
        public string buildEkran()
        {
            return "Екран";
        }
        public Monitor result()
        {
            Monitor m = new Monitor3D();
            return m;
        }
    }

    public class BuilderSensorMonitor : Builder
    {
        public string buildKorpus()
        {
            return "Корпус";
        }
        public string buildPlataYpr()
        {
            return "Плата управління";
        }
        public string buildBlockPyt()
        {
            return "Блок живлення";
        }
        public string buildEkran()
        {
            return "Екран";
        }
        public Monitor result()
        {
            Monitor m = new SensorMonitor();
            return m;
        }
    }
}
