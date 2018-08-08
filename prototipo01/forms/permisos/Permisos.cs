﻿using prototipo01.controladores;
using prototipo01.forms.bitacoraLogin;
using prototipo01.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.permisos
{
    public partial class Permisos : Form
    {

        ControladorUsuario controladorUsuario = new ControladorUsuario();
        BindingList<UsuarioDto> usuarioDataSource = new BindingList<UsuarioDto>();

        private int ID_reference;

        public Permisos()
        {
            InitializeComponent();
            refreshGrid();
        }


        //SOBREPONER FORM EN PANEL
        private void openForm(object formHijo)
        {
            this.Controls.Clear();

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            this.Tag = fh;
            fh.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new CrearUsuario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  

        public void refreshGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            usuarioDataSource = controladorUsuario.listaUsuarios();
            dataGridView1.DataSource = usuarioDataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm(new EditarUsuario(ID_reference));
            refreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Permisos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);

            }

        }
    }
}
