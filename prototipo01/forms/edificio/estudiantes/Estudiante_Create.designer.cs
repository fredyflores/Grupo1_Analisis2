﻿using System;

namespace prototipo01.forms.estudiante
{
    partial class Estudiante_Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CRUD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.cbo_facultad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_carrera = new System.Windows.Forms.Label();
            this.Txt_dpi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.cbo_estudiante = new System.Windows.Forms.ComboBox();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_edad = new System.Windows.Forms.TextBox();
            this.Lbl_edad = new System.Windows.Forms.Label();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.epError_Nombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError_Pass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError_Tel = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError_Apellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError_Correo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError_Direccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.CRUD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Nombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Apellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Correo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Direccion)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.tabPage1);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(40, 124);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Txt_estado);
            this.tabPage1.Controls.Add(this.cbo_facultad);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Lbl_carrera);
            this.tabPage1.Controls.Add(this.Txt_dpi);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Lbl_Estado);
            this.tabPage1.Controls.Add(this.cbo_estudiante);
            this.tabPage1.Controls.Add(this.Btn_crear);
            this.tabPage1.Controls.Add(this.Txt_direccion);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Txt_telefono);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Txt_correo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Txt_edad);
            this.tabPage1.Controls.Add(this.Lbl_edad);
            this.tabPage1.Controls.Add(this.Txt_apellido);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Txt_Nombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(868, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Txt_estado
            // 
            this.Txt_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_estado.Location = new System.Drawing.Point(113, 294);
            this.Txt_estado.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_estado.MaxLength = 15;
            this.Txt_estado.Multiline = true;
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(317, 28);
            this.Txt_estado.TabIndex = 40;
            // 
            // cbo_facultad
            // 
            this.cbo_facultad.FormattingEnabled = true;
            this.cbo_facultad.Location = new System.Drawing.Point(539, 334);
            this.cbo_facultad.Name = "cbo_facultad";
            this.cbo_facultad.Size = new System.Drawing.Size(316, 27);
            this.cbo_facultad.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(453, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Facultad";
            // 
            // Lbl_carrera
            // 
            this.Lbl_carrera.AutoSize = true;
            this.Lbl_carrera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_carrera.Location = new System.Drawing.Point(453, 296);
            this.Lbl_carrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_carrera.Name = "Lbl_carrera";
            this.Lbl_carrera.Size = new System.Drawing.Size(68, 19);
            this.Lbl_carrera.TabIndex = 37;
            this.Lbl_carrera.Text = "Carrera";
            // 
            // Txt_dpi
            // 
            this.Txt_dpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_dpi.Location = new System.Drawing.Point(113, 25);
            this.Txt_dpi.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_dpi.MaxLength = 30;
            this.Txt_dpi.Multiline = true;
            this.Txt_dpi.Name = "Txt_dpi";
            this.Txt_dpi.Size = new System.Drawing.Size(741, 28);
            this.Txt_dpi.TabIndex = 35;
            this.Txt_dpi.Validated += new System.EventHandler(this.Txt_dpi_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label8.Location = new System.Drawing.Point(67, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "DPI";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_Estado.Location = new System.Drawing.Point(41, 237);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Estado.TabIndex = 33;
            this.Lbl_Estado.Text = "Estado";
            this.Lbl_Estado.Click += new System.EventHandler(this.Lbl_Estado_Click);
            // 
            // cbo_estudiante
            // 
            this.cbo_estudiante.FormattingEnabled = true;
            this.cbo_estudiante.Location = new System.Drawing.Point(538, 290);
            this.cbo_estudiante.Name = "cbo_estudiante";
            this.cbo_estudiante.Size = new System.Drawing.Size(316, 27);
            this.cbo_estudiante.TabIndex = 32;
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.Color.White;
            this.Btn_crear.Image = global::prototipo01.Properties.Resources.iconmonstr_edit_11_24;
            this.Btn_crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_crear.Location = new System.Drawing.Point(113, 352);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(145, 41);
            this.Btn_crear.TabIndex = 31;
            this.Btn_crear.Text = "Crear";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_direccion.Location = new System.Drawing.Point(538, 235);
            this.Txt_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_direccion.MaxLength = 45;
            this.Txt_direccion.Multiline = true;
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(317, 28);
            this.Txt_direccion.TabIndex = 11;
            this.Txt_direccion.Validated += new System.EventHandler(this.textBox5_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label6.Location = new System.Drawing.Point(451, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_telefono.Location = new System.Drawing.Point(113, 235);
            this.Txt_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_telefono.MaxLength = 15;
            this.Txt_telefono.Multiline = true;
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(317, 28);
            this.Txt_telefono.TabIndex = 9;
            this.Txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.Txt_telefono.Validated += new System.EventHandler(this.textBox6_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label7.Location = new System.Drawing.Point(17, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Direccion";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Txt_correo
            // 
            this.Txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_correo.Location = new System.Drawing.Point(538, 162);
            this.Txt_correo.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_correo.MaxLength = 35;
            this.Txt_correo.Multiline = true;
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(317, 28);
            this.Txt_correo.TabIndex = 7;
            this.Txt_correo.Validated += new System.EventHandler(this.textBox4_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(453, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // Txt_edad
            // 
            this.Txt_edad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_edad.Location = new System.Drawing.Point(113, 162);
            this.Txt_edad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_edad.MaxLength = 45;
            this.Txt_edad.Multiline = true;
            this.Txt_edad.Name = "Txt_edad";
            this.Txt_edad.Size = new System.Drawing.Size(317, 28);
            this.Txt_edad.TabIndex = 5;
            this.Txt_edad.TextChanged += new System.EventHandler(this.Txt_edad_TextChanged);
            this.Txt_edad.Validated += new System.EventHandler(this.textBox3_Validated);
            // 
            // Lbl_edad
            // 
            this.Lbl_edad.AutoSize = true;
            this.Lbl_edad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_edad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_edad.Location = new System.Drawing.Point(30, 164);
            this.Lbl_edad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_edad.Name = "Lbl_edad";
            this.Lbl_edad.Size = new System.Drawing.Size(50, 19);
            this.Lbl_edad.TabIndex = 4;
            this.Lbl_edad.Text = "Edad";
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_apellido.Location = new System.Drawing.Point(538, 87);
            this.Txt_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_apellido.MaxLength = 30;
            this.Txt_apellido.Multiline = true;
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(317, 28);
            this.Txt_apellido.TabIndex = 3;
            this.Txt_apellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.Txt_apellido.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(453, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombre.Location = new System.Drawing.Point(113, 87);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.MaxLength = 30;
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(317, 28);
            this.Txt_Nombre.TabIndex = 1;
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.Txt_Nombre.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 50);
            this.panel1.TabIndex = 4;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::prototipo01.Properties.Resources.iconmonstr_angel_left_circle_thin_24;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(822, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(50, 50);
            this.btn_cerrar.TabIndex = 10;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Estudiante";
            // 
            // epError_Nombres
            // 
            this.epError_Nombres.ContainerControl = this;
            // 
            // epError_Pass
            // 
            this.epError_Pass.ContainerControl = this;
            // 
            // epError_Tel
            // 
            this.epError_Tel.ContainerControl = this;
            // 
            // epError_Apellidos
            // 
            this.epError_Apellidos.ContainerControl = this;
            // 
            // epError_Correo
            // 
            this.epError_Correo.ContainerControl = this;
            // 
            // epError_Direccion
            // 
            this.epError_Direccion.ContainerControl = this;
            // 
            // Estudiante_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 578);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Estudiante_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante_Create";
            this.Load += new System.EventHandler(this.Estudiante_Create_Load);
            this.CRUD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Nombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Apellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Correo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError_Direccion)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_edad;
        private System.Windows.Forms.Label Lbl_edad;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.ErrorProvider epError_Nombres;
        private System.Windows.Forms.ErrorProvider epError_Pass;
        private System.Windows.Forms.ErrorProvider epError_Tel;
        private System.Windows.Forms.ErrorProvider epError_Apellidos;
        private System.Windows.Forms.ErrorProvider epError_Correo;
        private System.Windows.Forms.ErrorProvider epError_Direccion;
      /*  private System.Windows.Forms.ErrorProvider epError_Dpi;*/
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ComboBox cbo_estudiante;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_dpi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl_carrera;
        private System.Windows.Forms.ComboBox cbo_facultad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_estado;
    }
}