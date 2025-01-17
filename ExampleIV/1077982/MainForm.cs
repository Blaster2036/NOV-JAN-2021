﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleIV._1077982
{
    public partial class MainForm : Form
    {
        nov_jan_2021Entities db = new nov_jan_2021Entities();

        public MainForm()
        {
            InitializeComponent();

            GetRecords();
        }

        private void GetRecords()
        {
            var ciudadanos = db.C1077982_Ciudadano.ToList();
            dgvRegistros.DataSource = ciudadanos;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var oForm = new AddForm();
            oForm.ShowDialog();
        }
    }
}
