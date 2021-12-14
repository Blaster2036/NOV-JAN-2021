using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleIV._1103314_Dealer
{
    public partial class Búsqueda : Form
    {
        nov_jan_2021Entities db = new nov_jan_2021Entities();
        public Búsqueda()
        {
            InitializeComponent();
            GetRecords();
        }
        private void GetRecords()
        {
            var vehiculos = db.C1103314_Dealer.ToList();
            
            if (!string.IsNullOrEmpty(txtCedula.Text))
            {
                vehiculos = vehiculos.Where(x => x.Cedula.Contains(txtCedula.Text)).ToList();
            }

            if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                vehiculos = vehiculos.Where(x => x.OwnersName.ToLower().Contains(txtNombres.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(txtApellidos.Text))
            {
                vehiculos = vehiculos.Where(x => x.OwnersSurName.ToLower().Contains(txtApellidos.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(txtMarca.Text))
            {
                vehiculos = vehiculos.Where(x => x.VBrand.ToLower().Contains(txtMarca.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(txtYear.Text))
            {
                vehiculos = vehiculos.Where(x => x.VYear.Contains(txtYear.Text)).ToList();
            }

            if (!string.IsNullOrEmpty(txtColor.Text))
            {
                vehiculos = vehiculos.Where(x => x.VColor.ToLower().Contains(txtColor.Text.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(txtVIN.Text))
            {
                vehiculos = vehiculos.Where(x => x.VVIN.ToLower().Contains(txtVIN.Text.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(txtMat.Text))
            {
                vehiculos = vehiculos.Where(x => x.VLicensePlate.Contains(txtMat.Text)).ToList();
            }
            /*if (!string.IsNullOrEmpty(dtpSeaboard))
            {
                vehiculos = vehiculos.Where(x => x.VLicensePlate.Contains(txtMat.Text)).ToList();
            }*/

            dgvDB.DataSource = vehiculos;
            lblRegistros.Text = $"{vehiculos.Count} Registros encontrados.";
            //dgvDB.Columns[0].Visible = false;
            //dgvDB.Columns["Seq"].Visible = false;

        }
        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var oForm = new Registro();
            oForm.ShowDialog();
        }

        
    }
}
