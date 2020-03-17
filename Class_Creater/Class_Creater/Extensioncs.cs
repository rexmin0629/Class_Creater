using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Class_Creater
{
    public static class DataGridViewExtensioncs
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty, null, dgv, new object[] { setting });

            //var dgvType = dgv.GetType();
            //var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            //pi.SetValue(dgv, setting, null);
        }
    }

}
