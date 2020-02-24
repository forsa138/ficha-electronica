using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha_electronica
{
    public partial class Inicio_Filect : Form
    {
        public Inicio_Filect()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 4000;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
