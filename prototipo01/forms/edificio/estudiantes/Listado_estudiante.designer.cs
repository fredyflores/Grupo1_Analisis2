﻿namespace prototipo01.forms.estudiante
{
    partial class Listado_estudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Dgb_estudiantes = new System.Windows.Forms.DataGridView();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Lbl_buscar = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Pnl_estudiantes = new System.Windows.Forms.Panel();
            this.Lbl_estudiantes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_estudiantes)).BeginInit();
            this.Pnl_estudiantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_eliminar.Image = global::prototipo01.Properties.Resources.iconmonstr_x_mark_13_24;
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_eliminar.Location = new System.Drawing.Point(767, 209);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(145, 41);
            this.Btn_eliminar.TabIndex = 35;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_actualizar.Image = global::prototipo01.Properties.Resources.iconmonstr_synchronization_19_24;
            this.Btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_actualizar.Location = new System.Drawing.Point(618, 209);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(145, 41);
            this.Btn_actualizar.TabIndex = 34;
            this.Btn_actualizar.Text = "Editar";
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Dgb_estudiantes
            // 
            this.Dgb_estudiantes.AllowUserToAddRows = false;
            this.Dgb_estudiantes.AllowUserToDeleteRows = false;
            this.Dgb_estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgb_estudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgb_estudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgb_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_estudiantes.EnableHeadersVisualStyles = false;
            this.Dgb_estudiantes.Location = new System.Drawing.Point(40, 265);
            this.Dgb_estudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.Dgb_estudiantes.Name = "Dgb_estudiantes";
            this.Dgb_estudiantes.ReadOnly = true;
            this.Dgb_estudiantes.RowHeadersVisible = false;
            this.Dgb_estudiantes.RowTemplate.Height = 24;
            this.Dgb_estudiantes.Size = new System.Drawing.Size(872, 302);
            this.Dgb_estudiantes.TabIndex = 33;
            this.Dgb_estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgb_estudiantes_CellContentClick);
            this.Dgb_estudiantes.SelectionChanged += new System.EventHandler(this.Dgb_estudiantes_SelectionChanged);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(101, 142);
            this.Txt_buscar.MaxLength = 45;
            this.Txt_buscar.Multiline = true;
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(662, 39);
            this.Txt_buscar.TabIndex = 32;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // Lbl_buscar
            // 
            this.Lbl_buscar.AutoSize = true;
            this.Lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_buscar.Location = new System.Drawing.Point(34, 151);
            this.Lbl_buscar.Name = "Lbl_buscar";
            this.Lbl_buscar.Size = new System.Drawing.Size(61, 18);
            this.Lbl_buscar.TabIndex = 31;
            this.Lbl_buscar.Text = "Buscar";
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.Color.White;
            this.Btn_crear.Image = global::prototipo01.Properties.Resources.iconmonstr_edit_11_24;
            this.Btn_crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_crear.Location = new System.Drawing.Point(469, 209);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(145, 41);
            this.Btn_crear.TabIndex = 30;
            this.Btn_crear.Text = "Crear";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Pnl_estudiantes
            // 
            this.Pnl_estudiantes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_estudiantes.Controls.Add(this.Lbl_estudiantes);
            this.Pnl_estudiantes.Location = new System.Drawing.Point(40, 70);
            this.Pnl_estudiantes.Name = "Pnl_estudiantes";
            this.Pnl_estudiantes.Size = new System.Drawing.Size(870, 50);
            this.Pnl_estudiantes.TabIndex = 29;
            // 
            // Lbl_estudiantes
            // 
            this.Lbl_estudiantes.AutoSize = true;
            this.Lbl_estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_estudiantes.Location = new System.Drawing.Point(15, 15);
            this.Lbl_estudiantes.Name = "Lbl_estudiantes";
            this.Lbl_estudiantes.Size = new System.Drawing.Size(160, 18);
            this.Lbl_estudiantes.TabIndex = 0;
            this.Lbl_estudiantes.Text = "Lista de Estudiantes";
            // 
            // Listado_estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 578);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgb_estudiantes);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.Lbl_buscar);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.Pnl_estudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_estudiante";
            this.Load += new System.EventHandler(this.Listado_estudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_estudiantes)).EndInit();
            this.Pnl_estudiantes.ResumeLayout(false);
            this.Pnl_estudiantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.DataGridView Dgb_estudiantes;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Lbl_buscar;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Panel Pnl_estudiantes;
        private System.Windows.Forms.Label Lbl_estudiantes;
    }
}