using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajanda
{
    public partial class rapor : Form
    {
        int num;
        string tarih;
        public rapor(string _tarih,int _num)
        {
            InitializeComponent();
            tarih = _tarih;
            num = _num;
        }

        private void rapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AJANDADataSet.TBLPUANTAJ' table. You can move, or remove it, as needed.
            this.TBLPUANTAJTableAdapter.FillBy1(AJANDADataSet.TBLPUANTAJ, num, tarih);

            this.reportViewer1.RefreshReport();
        }

        
    }
}
