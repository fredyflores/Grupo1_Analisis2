﻿
using prototipo01.controladores;
using prototipo01.Clases;
using prototipo01.models;
using prototipo01.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace prototipo01
{
    public partial class listaEdificios : Form
    {

        ControladorEdificios controladorEdificios = new ControladorEdificios(); //LOGICA CRUD EDIFICIOS
        BindingList<edificioDto> edificiosDataSource = new BindingList<edificioDto>(); //LISTA EDIFICIOS
        private int ID_reference;



        public listaEdificios()
        {
            InitializeComponent();
           
            
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




        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            edificiosDataSource = controladorEdificios.listaEdificios();
            dataGridView1.DataSource = edificiosDataSource;

        }


        //BUSCAR POR INICIALES
        void search()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            edificiosDataSource = controladorEdificios.listaEdificiosLike(textBox1.Text.ToString());
            dataGridView1.DataSource = edificiosDataSource;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Edificio_Create());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (ID_reference != 0)
            {

                openForm(new Edificion_Update(ID_reference));

            }
            else
            {
                MessageBox.Show("Por favor seleccione un edificio");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void dataGridView1_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void listaEdificios_Load_1(object sender, EventArgs e)
        {
            button1.Enabled = privilegios.bandera;
            button2.Enabled = privilegios.bandera;
            button3.Enabled = privilegios.bandera;
            refreshDataSource();

         
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

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)

        {

            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el edificio?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorEdificios.eliminarEdificio(ID_reference);
                //CONTROL BICORA
                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Eliminar Edificio.");
                refreshDataSource();

                //CONTROL BICORA
                
            }


           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            refreshDataSource();
        }

        private void button4_Click(object sender, EventArgs e)
        {



            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

          


        }
    }
}
