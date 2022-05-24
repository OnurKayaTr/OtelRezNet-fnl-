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
    public partial class OteleGelenMusteri : Form
    {
        public OteleGelenMusteri()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OtelRezervasyonDataSet4.BugunOteleGelenMusteriler' table. You can move, or remove it, as needed.
            this.BugunOteleGelenMusterilerTableAdapter.Fill(this.OtelRezervasyonDataSet4.BugunOteleGelenMusteriler);

            this.reportViewer1.RefreshReport();
        }
    }
}
