﻿using System;

namespace prototipo01.forms.estudiante
{
    partial class Estudiante_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudiante_Update));
            this.CRUD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Txt_Correo = new System.Windows.Forms.TextBox();
            this.Lbl_Correo = new System.Windows.Forms.Label();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Txt_Apellidos = new System.Windows.Forms.TextBox();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.Txt_Nombres = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Pnl_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CRUD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Pnl_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.tabPage1);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(26, 91);
            this.CRUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(1168, 613);
            this.CRUD.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_actualizar);
            this.tabPage1.Controls.Add(this.Txt_Direccion);
            this.tabPage1.Controls.Add(this.Lbl_direccion);
            this.tabPage1.Controls.Add(this.Txt_Telefono);
            this.tabPage1.Controls.Add(this.Lbl_telefono);
            this.tabPage1.Controls.Add(this.Txt_Correo);
            this.tabPage1.Controls.Add(this.Lbl_Correo);
            this.tabPage1.Controls.Add(this.Txt_Contraseña);
            this.tabPage1.Controls.Add(this.Lbl_contraseña);
            this.tabPage1.Controls.Add(this.Txt_Apellidos);
            this.tabPage1.Controls.Add(this.Lbl_apellido);
            this.tabPage1.Controls.Add(this.Txt_Nombres);
            this.tabPage1.Controls.Add(this.Lbl_nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1160, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_actualizar.Location = new System.Drawing.Point(565, 437);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(135, 59);
            this.Btn_actualizar.TabIndex = 17;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Direccion.Location = new System.Drawing.Point(717, 329);
            this.Txt_Direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Direccion.Multiline = true;
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(421, 34);
            this.Txt_Direccion.TabIndex = 11;
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_direccion.Location = new System.Drawing.Point(599, 330);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(104, 23);
            this.Lbl_direccion.TabIndex = 10;
            this.Lbl_direccion.Text = "Dirección";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Telefono.Location = new System.Drawing.Point(151, 329);
            this.Txt_Telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Telefono.Multiline = true;
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(421, 34);
            this.Txt_Telefono.TabIndex = 9;
            this.Txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Telefono_KeyPress);
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_telefono.Location = new System.Drawing.Point(21, 329);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(93, 23);
            this.Lbl_telefono.TabIndex = 8;
            this.Lbl_telefono.Text = "Telefono";
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Correo.Location = new System.Drawing.Point(717, 224);
            this.Txt_Correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Correo.Multiline = true;
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.Size = new System.Drawing.Size(421, 34);
            this.Txt_Correo.TabIndex = 7;
            // 
            // Lbl_Correo
            // 
            this.Lbl_Correo.AutoSize = true;
            this.Lbl_Correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_Correo.Location = new System.Drawing.Point(599, 225);
            this.Lbl_Correo.Name = "Lbl_Correo";
            this.Lbl_Correo.Size = new System.Drawing.Size(77, 23);
            this.Lbl_Correo.TabIndex = 6;
            this.Lbl_Correo.Text = "Correo";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Contraseña.Location = new System.Drawing.Point(151, 224);
            this.Txt_Contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Contraseña.Multiline = true;
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(421, 34);
            this.Txt_Contraseña.TabIndex = 5;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_contraseña.Location = new System.Drawing.Point(21, 224);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(123, 23);
            this.Lbl_contraseña.TabIndex = 4;
            this.Lbl_contraseña.Text = "Contraseña";
            // 
            // Txt_Apellidos
            // 
            this.Txt_Apellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Apellidos.Location = new System.Drawing.Point(717, 107);
            this.Txt_Apellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Apellidos.Multiline = true;
            this.Txt_Apellidos.Name = "Txt_Apellidos";
            this.Txt_Apellidos.Size = new System.Drawing.Size(421, 34);
            this.Txt_Apellidos.TabIndex = 3;
            this.Txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellidos_KeyPress);
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_apellido.Location = new System.Drawing.Point(599, 108);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(101, 23);
            this.Lbl_apellido.TabIndex = 2;
            this.Lbl_apellido.Text = "Apellidos";
            // 
            // Txt_Nombres
            // 
            this.Txt_Nombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombres.Location = new System.Drawing.Point(151, 107);
            this.Txt_Nombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombres.Multiline = true;
            this.Txt_Nombres.Name = "Txt_Nombres";
            this.Txt_Nombres.Size = new System.Drawing.Size(421, 34);
            this.Txt_Nombres.TabIndex = 1;
            this.Txt_Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombres_KeyPress);
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_nombre.Location = new System.Drawing.Point(21, 107);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(98, 23);
            this.Lbl_nombre.TabIndex = 0;
            this.Lbl_nombre.Text = "Nombres";
            // 
            // Pnl_panel
            // 
            this.Pnl_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_panel.Controls.Add(this.pictureBox1);
            this.Pnl_panel.Controls.Add(this.label1);
            this.Pnl_panel.Location = new System.Drawing.Point(26, 11);
            this.Pnl_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_panel.Name = "Pnl_panel";
            this.Pnl_panel.Size = new System.Drawing.Size(1168, 59);
            this.Pnl_panel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1093, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Estudiante";
            // 
            // Estudiante_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 711);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.Pnl_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Estudiante_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante_Update";
            this.CRUD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Pnl_panel.ResumeLayout(false);
            this.Pnl_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Txt_Nombres;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Panel Pnl_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Apellidos;
        private System.Windows.Forms.Label Lbl_apellido;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.TextBox Txt_Correo;
        private System.Windows.Forms.Label Lbl_Correo;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Button Btn_actualizar;
    }
}