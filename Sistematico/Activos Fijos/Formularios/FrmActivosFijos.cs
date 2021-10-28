using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activos_Fijos.Formularios
{
    public partial class FrmActivosFijos : Form
    {
        private Form activeForm;
        public FrmActivosFijos()
        {
            InitializeComponent();
        }

        private void BtnAgg_Click(object sender, EventArgs e)
        {
            FrmAgg agg = new FrmAgg();
            agg.Show();
        }
        
    }
}
