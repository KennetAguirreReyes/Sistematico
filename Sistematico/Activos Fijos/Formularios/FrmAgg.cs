using Domain.Entities;
using Domain.Enums;
using Infraestructura.Activos;
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
    public partial class FrmAgg : Form
    {
        private ActivoModel activomodel;
        public FrmAgg(ActivoModel activomodel)
        {
            this.activomodel = activomodel;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Activo p = new Activo()
            {
                Id = activomodel.GetLastActivoFijoId() + 1,
                Nombre = txtName.Text,
                Descripcion = txtDescription.Text,
                ValorActivo = (decimal)nudValor.Value,
                FechaAdquisicion = dtoFechaAdquisicion.Value,
                MetodoDepreciacion = (MetodoDepreciacion)cmbMetodo.SelectedValue,
                TipoActivoFijo = (TipoActivoFijo)cmbTipoActivo.SelectedValue,
            };
            activomodel.Create(p);
        }
    }
}
