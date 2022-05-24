using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezNet
{
    public partial class RezGoster : Form
    {
        public RezGoster()
        {
            InitializeComponent();
        }

        private void RezGöster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OtelRezervasyonDataSet5.ViewRezlerGoster' table. You can move, or remove it, as needed.
            this.ViewRezlerGosterTableAdapter.Fill(this.OtelRezervasyonDataSet5.ViewRezlerGoster);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
