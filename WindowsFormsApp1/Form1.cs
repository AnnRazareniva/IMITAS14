using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int busyOps = 0;



        private void RUN_Click(object sender, EventArgs e)
        {
            Model.operators = (int)operatrr.Value;

            chart1.Series[0].Points.Clear();
            Model.people = 0;
            Model.GO();

            busyOps = Model.getBusyOperatorsCount();
            chart1.Series[0].Points.AddXY(0, 0);
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Model.Run();
            if (busyOps < Model.getBusyOperatorsCount())
            {
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
                busyOps++;
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
            }
            else
            {
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
                busyOps--;
                chart1.Series[0].Points.AddXY(Model.Time, busyOps);
            }
            queueCount.Text = Model.queueCount().ToString();
            peopleCount.Text = Model.people.ToString();
        }


    }
}
