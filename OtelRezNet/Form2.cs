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
    public partial class OteldeOlanMusteri : Form
    {
        public OteldeOlanMusteri()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OtelRezervasyonDataSet1.BugunOteledeOlanMusteriler' table. You can move, or remove it, as needed.
            this.BugunOteledeOlanMusterilerTableAdapter.Fill(this.OtelRezervasyonDataSet1.BugunOteledeOlanMusteriler);

            this.reportViewer1.RefreshReport();
        }
    }
}
