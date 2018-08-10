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

namespace prototipo01.forms.estudiante
{
    public partial class Estudiante_Create : Form
    {
        ControladorEstudiante controladorEstudiantes = new ControladorEstudiante();
        public Estudiante_Create()
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
        private void Estudiante_Create_Load(object sender, EventArgs e)
        {
            cbo_carrera.DataSource = controladorEstudiantes.getCarreras();
            cbo_carrera.DisplayMember = "name";
            cbo_carrera.ValueMember = "nombre_carrera";
           

            cbo_facultad.DataSource = controladorEstudiantes.getFacultades();
            cbo_facultad.DisplayMember = "name";
            cbo_facultad.ValueMember = "nombre_facultad";
        }
        void createAlumno()
        {

            string nombre, apellido,correo, direccion, telefono, estado, carnet;
            int edad, dpi, carrera, facultad;

            
            dpi = Convert.ToInt32(Txt_dpi.Text.ToString());
            nombre = Txt_Nombre.Text.ToString();
            apellido = Txt_apellido.Text.ToString();
            telefono = Txt_telef.Text.ToString();
            correo = Txt_correo.Text.ToString();
            facultad = controladorEstudiantes.getIdFacultad(cbo_facultad.Text.ToString());
            carrera = controladorEstudiantes.getIdCarrera(cbo_carrera.Text.ToString());
            direccion = Txt_dire.Text.ToString();
            carnet = Txt_carnet.Text.ToString();
            edad = Convert.ToInt32(Txt_edad.Text.ToString());
            estado = Txt_estado.Text.ToString();
            



            //




            controladorEstudiantes.guardarEstudiante(dpi, nombre, apellido, telefono,correo,facultad,carrera,edad,direccion,estado,carnet);
        }





        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            openForm(new Listado_estudiante());

        }

     
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (Validacion.ValidarCorreo(Txt_correo.Text) == true)
            {
                if (string.IsNullOrEmpty(Txt_Nombre.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_apellido.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_edad.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_telef.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_correo.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_estado.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_dpi.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                /*codigo kevin*/
                else
                {
                    try
                    {
                        createAlumno();
                        MessageBox.Show("Se ha agregado exitosamente un nuevo Estudiante", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ControladorBitacora controladorBitacora = new ControladorBitacora();
                        controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Creacion Estudiante.");

                        Txt_Nombre.Text = "";
                        Txt_apellido.Text = "";
                        Txt_edad.Text = "";
                        Txt_telef.Text = "";
                        Txt_correo.Text = "";
                        Txt_estado.Text = "";
                        Txt_dpi.Text = "";
                        Txt_dire.Text = "";
                        Txt_carnet.Text = "";
                        cbo_carrera.Text = "";
                        cbo_facultad.Text = "";




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ingreso de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa correctamente el correo", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text.Trim() == "")
            {
                epError_Nombres.SetError(Txt_Nombre, "Introduce Nombre para el estudiante");
                Txt_Nombre.Focus();
            }
            else
            {
                epError_Nombres.Clear();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (Txt_apellido.Text.Trim() == "")
            {
                epError_Apellidos.SetError(Txt_apellido, "Introduce apellidos del estudiante");
                Txt_apellido.Focus();
            }
            else
            {
                epError_Apellidos.Clear();
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if (Txt_edad.Text.Trim() == "")
            {
                epError_Pass.SetError(Txt_edad, "Introduce la edad del estudiante");
                Txt_edad.Focus();
            }
            else
            {
                epError_Pass.Clear();
            }
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            if (Txt_telef.Text.Trim() == "")
            {
                epError_Correo.SetError(Txt_telef, "Introduce un correo del estudiante");
                Txt_telef.Focus();
            }
            else
            {
                epError_Correo.Clear();
            }
        }

        private void textBox5_Validated(object sender, EventArgs e)
        {
            if (Txt_correo.Text.Trim() == "")
            {
                epError_Tel.SetError(Txt_correo, "Introduce direccion del estudiante");
                Txt_correo.Focus();
            }
            else
            {
                epError_Direccion.Clear();
            }
        }

        private void textBox6_Validated(object sender, EventArgs e)
        {
            if (Txt_estado.Text.Trim() == "")
            {
                epError_Direccion.SetError(Txt_estado, "Introduce telefono del estudiante");
                Txt_estado.Focus();
            }
            else
            {
                epError_Tel.Clear();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_estudiante());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        

        private void Txt_dpi_Validated(object sender, EventArgs e)
        {
           /* if (Txt_dpi.Text.Trim() == "")
            {
                epError_Dpi.SetError(Txt_dpi, "Introduce DPI del estudiante");
                textBox6.Focus();
            }
            else
            {
               epError_Dpi.Clear();
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Estado_Click(object sender, EventArgs e)
        {

        }

        private void Txt_edad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
