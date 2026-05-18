using Automobile_Production.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile_Production
{
    public partial class CoolRides : Form
    {
        private HQ hq;
        public CoolRides()
        {
            InitializeComponent();

            hq = new HQ();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rbBlackCar.Checked)
            {
                hq.OrderCar("Black");
            }

            else if (rbWhiteCar.Checked)
            {
                hq.OrderCar("White");
            }

            else if (rbBlackMinibus.Checked)
            {
                hq.OrderMinibus("Black");
            }

            else if (rbWhiteMinibus.Checked)
            {
                hq.OrderMinibus("White");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCarQueue.Text =
                hq.CarQueueCount.ToString();

            lblMinibusQueue.Text =
                hq.MinibusQueueCount.ToString();

            lblCarAssemblyLine.Text =
                hq.CarAssemblyLine.Status;

            lblMinibusAssemblyLine.Text =
                hq.MinibusAssemblyLine.Status;

            lblSprayboothStatus.Text =
                Spraybooth.Instance.Status;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
