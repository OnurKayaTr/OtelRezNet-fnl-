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
    public partial class BosOda : Form
    {
        public BosOda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OtelRezervasyonDataSet.BosOda' table. You can move, or remove it, as needed.
            this.BosOdaTableAdapter.Fill(this.OtelRezervasyonDataSet.BosOda);

            this.reportViewer1.RefreshReport();
        }
    }
}
