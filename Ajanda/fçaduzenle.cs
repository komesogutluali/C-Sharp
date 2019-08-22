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
    public partial class fçaduzenle : Form
    {
        TextBox gun;
        double mesai;
        public fçaduzenle(TextBox _gun,double _mes)
        {
            InitializeComponent();
            mesai = _mes;
            gun= _gun;
            tgun.Text = gun.Text;
            tmesai.Text =mesai.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tgun.Text.Length > 0 && tmesai.Text.Length > 0)
            {
                double mes;
                bool k = double.TryParse(tmesai.Text.Replace('.', ','), out mes);
                gun.Text = tgun.Text;
                calısma.mes = mes;
                this.Close();
             
             }
        }
    }
}
