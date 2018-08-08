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
using prototipo01.Clases;
namespace prototipo01.forms.salones

{
    public partial class Salones_Create : Form
    {

        ControladorSalones controladorSalones = new ControladorSalones();
        public Salones_Create()
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

        void crearSalon()
        {

            string capacidad,nombre;
            int ID_edificio;

         
            capacidad = Txt_capacidad.Text.ToString();
            ID_edificio = controladorSalones.getIdEdificio(Cbo_edificio.Text.ToString());
            nombre = Txt_nombre.Text.ToString();
            
            
            controladorSalones.guardarSalon(capacidad,ID_edificio,nombre);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new listaSalones());
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Txt_capacidad.Text) || string.IsNullOrEmpty(Cbo_edificio.Text) || string.IsNullOrEmpty(Txt_nombre.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    crearSalon();
                    MessageBox.Show("Se ha agregado exitosamente un nuevo salon", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    ControladorBitacora controladorBitacora = new ControladorBitacora();
                    controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "crear salon.");
                    Txt_nombre.Text = "";
                    Cbo_edificio.Text = "";
                    Txt_capacidad.Text = "";
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void dataEdificios()
        {
            Cbo_edificio.DataSource = controladorSalones.getEdificios();
            Cbo_edificio.DisplayMember = "Name";
            Cbo_edificio.ValueMember = "nombre_edificio";


        }
        private void Salones_Create_Load(object sender, EventArgs e)
        {
            dataEdificios();
        }

        private void Txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

  

        private void Pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }
        private void Txt_capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }
        private void Txt_capacidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void Cbo_edificio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }
    }
}
