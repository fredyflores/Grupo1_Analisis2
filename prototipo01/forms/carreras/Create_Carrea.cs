﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.controladores;
using prototipo01.models;

namespace prototipo01.forms.carrera
{
    public partial class Create_Carrea : Form
    {
        ControladorCarrera controladorCarrera = new ControladorCarrera();
        public Create_Carrea()
        {
            InitializeComponent();
        }

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

        void crearCarrera()
        {

            string nombre;
            int id_carrera;
            string jornada;
            int id_facultad;

            nombre = Txt_nombre.Text.ToString();
            id_facultad = controladorCarrera.getIdFacultad(Cbo_facultad.Text.ToString());
            jornada = Txt_jornada.Text.ToString();
            id_carrera = Convert.ToInt32(Txt_id.Text.ToString());



            controladorCarrera.guardarCarrera(id_carrera, nombre, id_facultad, jornada);
        }




        private void Lbl_nombre_Click(object sender, EventArgs e)
        {

        }
        private void Lbl_jornada_Click(object sender, EventArgs e) { }

        private void Btn_atras_Click(object sender, EventArgs e)
        {
            openForm(new Listado_carreras());
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_id.Text) || string.IsNullOrEmpty(Cbo_facultad.Text) || string.IsNullOrEmpty(Txt_nombre.Text) || string.IsNullOrEmpty(Txt_jornada.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    crearCarrera();
                    MessageBox.Show("Se ha agregado exitosamente una nueva carrera", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Txt_id.Text = "";
                    Txt_nombre.Text = "";
                    Txt_jornada.Text= "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataFacultades()
        {
            Cbo_facultad.DataSource = controladorCarrera.getfacultades();
            Cbo_facultad.DisplayMember = "Name";
            Cbo_facultad.ValueMember = "nombre_facultad";


        }

        private void carrera_Create_Load(object sender, EventArgs e)
        {
            dataFacultades();
        }

        private void Txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_jornada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }
    }
}
