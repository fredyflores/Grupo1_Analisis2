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

namespace prototipo01
{
    public partial class Laboratorio_Update : Form
    {

        ControladorLaboratorio controladorLaboratorio = new ControladorLaboratorio();
        private int reference;

        public Laboratorio_Update(int ID_reference)
        {
            InitializeComponent();
            reference = ID_reference;
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openForm(new listaLaboratorios());
        }

        private void dataSalones()
        {
            Cbo_salon.DataSource = controladorLaboratorio.getSalones();
            Cbo_salon.DisplayMember = "Name";
            Cbo_salon.ValueMember = "nombre_salon";

        }


        private void dataHorarios()
        {
            cbo_horario.DataSource = controladorLaboratorio.getHorarios();
            cbo_horario.DisplayMember = "Name";
            cbo_horario.ValueMember = "horario_horario";

        }



        private void dataCatedraticos()
        {

            Cbo_catedratico.DataSource = controladorLaboratorio.getCatedraticos();
            Cbo_catedratico.DisplayMember = "Name";
            Cbo_catedratico.ValueMember = "dpi_catedratico";

        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Clases.Validacion.SoloLetras(e);
        }

        private void Cbo_edificio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);

        }

        private void Txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_nombre.Text)  || string.IsNullOrEmpty(Cbo_catedratico.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Laboratorio_Update_Load(object sender, EventArgs e)
        {
            dataSalones();
            dataHorarios();
            dataCatedraticos();

            laboratorio  Model = controladorLaboratorio.buscarLaboratorio(reference);
            Txt_nombre.Text = Model.descripcion_laboratorio.ToString();

        }

        private void Btn_actualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_nombre.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Cbo_catedratico.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Cbo_salon.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombre = Txt_nombre.Text.ToString();
            int dpi_catedratico = Convert.ToInt32(Cbo_catedratico.Text.ToString());
            int id_salon = controladorLaboratorio.getIdSalon(Cbo_salon.Text.ToString());
            int id_horario = controladorLaboratorio.getIdHorario(cbo_horario.Text.ToString());

            try { 
            controladorLaboratorio.actualizarLaboratorio(reference,nombre,dpi_catedratico,id_horario,id_salon);
                MessageBox.Show("Informacion agregada correctamente", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_nombre.Text = "";
                Cbo_catedratico.Text = "";
                Cbo_salon.Text = "";
                cbo_horario.Text = "";
                //CONTROL BICORA
                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Editar Laboratorio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new listaLaboratorios());
        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
