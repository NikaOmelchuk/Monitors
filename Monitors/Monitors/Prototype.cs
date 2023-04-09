using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Monitors
{
    public interface Prorotype
    {
        public object Clone();
    }

    public class MonitorClone : Prorotype
    {
        public PictureBox p;
        public string str;
        public string Nazva;
        public MonitorClone(PictureBox p, string str, string Nazva)
        {
            this.p = p;
            this.str = str;
            this.Nazva = Nazva;
        }

        public object Clone()
        {
            return new MonitorClone(p,str, Nazva);
        }
    }
}
