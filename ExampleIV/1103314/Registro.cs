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
    public partial class Registro : Form
    {
        nov_jan_2021Entities db = new nov_jan_2021Entities();
        public Registro()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            var vehiculo = new C1103314_Dealer();
            vehiculo.Cedula = txtCedula.Text;
            vehiculo.OwnersName = txtNombres.Text;
            vehiculo.OwnersSurName = txtApellidos.Text;
            vehiculo.Email = txtCorreo.Text;
            vehiculo.Phone = txtTel.Text;
            vehiculo.VBrand = txtMarca.Text;
            vehiculo.VModel = txtModelo.Text;
            vehiculo.VYear = txtYear.Text;
            vehiculo.VColor = txtColor.Text;
            vehiculo.VVIN = txtVIN.Text;
            vehiculo.VLicensePlate = txtMat.Text;
            vehiculo.SeaboardDate = dtpSeaboard.Value;
            vehiculo.CreationDate = DateTime.Now;

            db.C1103314_Dealer.Add(vehiculo);
            var added = db.SaveChanges() > 0;

            if (added)
            {
                MessageBox.Show($"Su vehículo marca {txtMarca.Text} modelo {txtModelo.Text} fue agregado correctamente.");

                ClearForm();
            }

        }

        private void ClearForm()
        {
            txtCedula.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtVIN.Text = string.Empty;
            txtMat.Text = string.Empty;
            dtpSeaboard.Value = DateTime.Now.AddYears(-4);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
