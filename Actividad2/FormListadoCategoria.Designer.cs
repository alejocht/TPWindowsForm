﻿namespace Actividad2
{
    partial class FormListadoCategoria
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
            this.lblBusquedaCategorias = new System.Windows.Forms.Label();
            this.listadoCategorias = new System.Windows.Forms.ListBox();
            this.txtBusquedaCategorias = new System.Windows.Forms.TextBox();
            this.btnAtrasListaCat = new System.Windows.Forms.Button();
            this.btnBusquedaCat = new System.Windows.Forms.Button();
            this.btnBorrarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBusquedaCategorias
            // 
            this.lblBusquedaCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBusquedaCategorias.AutoSize = true;
            this.lblBusquedaCategorias.Location = new System.Drawing.Point(50, 36);
            this.lblBusquedaCategorias.Name = "lblBusquedaCategorias";
            this.lblBusquedaCategorias.Size = new System.Drawing.Size(40, 13);
            this.lblBusquedaCategorias.TabIndex = 21;
            this.lblBusquedaCategorias.Text = "Buscar";
            // 
            // listadoCategorias
            // 
            this.listadoCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listadoCategorias.FormattingEnabled = true;
            this.listadoCategorias.Location = new System.Drawing.Point(53, 70);
            this.listadoCategorias.Name = "listadoCategorias";
            this.listadoCategorias.Size = new System.Drawing.Size(698, 303);
            this.listadoCategorias.TabIndex = 20;
            // 
            // txtBusquedaCategorias
            // 
            this.txtBusquedaCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusquedaCategorias.BackColor = System.Drawing.Color.White;
            this.txtBusquedaCategorias.Location = new System.Drawing.Point(111, 32);
            this.txtBusquedaCategorias.MaxLength = 500;
            this.txtBusquedaCategorias.Name = "txtBusquedaCategorias";
            this.txtBusquedaCategorias.Size = new System.Drawing.Size(236, 20);
            this.txtBusquedaCategorias.TabIndex = 19;
            // 
            // btnAtrasListaCat
            // 
            this.btnAtrasListaCat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasListaCat.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasListaCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasListaCat.Location = new System.Drawing.Point(53, 387);
            this.btnAtrasListaCat.Name = "btnAtrasListaCat";
            this.btnAtrasListaCat.Size = new System.Drawing.Size(59, 32);
            this.btnAtrasListaCat.TabIndex = 23;
            this.btnAtrasListaCat.Text = "Atras";
            this.btnAtrasListaCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasListaCat.UseVisualStyleBackColor = true;
            this.btnAtrasListaCat.Click += new System.EventHandler(this.btnAtrasListaCat_Click);
            // 
            // btnBusquedaCat
            // 
            this.btnBusquedaCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusquedaCat.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusquedaCat.Image = global::Actividad2.Properties.Resources.lupa;
            this.btnBusquedaCat.Location = new System.Drawing.Point(353, 32);
            this.btnBusquedaCat.Name = "btnBusquedaCat";
            this.btnBusquedaCat.Size = new System.Drawing.Size(23, 21);
            this.btnBusquedaCat.TabIndex = 22;
            this.btnBusquedaCat.UseVisualStyleBackColor = false;
            // 
            // btnBorrarCategoria
            // 
            this.btnBorrarCategoria.Image = global::Actividad2.Properties.Resources.multiply;
            this.btnBorrarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarCategoria.Location = new System.Drawing.Point(692, 26);
            this.btnBorrarCategoria.Name = "btnBorrarCategoria";
            this.btnBorrarCategoria.Size = new System.Drawing.Size(59, 32);
            this.btnBorrarCategoria.TabIndex = 25;
            this.btnBorrarCategoria.Text = "Borrar";
            this.btnBorrarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Image = global::Actividad2.Properties.Resources.icons8_modificar_16;
            this.btnModificarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCategoria.Location = new System.Drawing.Point(612, 26);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(74, 32);
            this.btnModificarCategoria.TabIndex = 24;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(2, 3);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblTituloCategoria.TabIndex = 26;
            this.lblTituloCategoria.Text = "Categorias";
            // 
            // FormListadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.btnBorrarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAtrasListaCat);
            this.Controls.Add(this.btnBusquedaCat);
            this.Controls.Add(this.lblBusquedaCategorias);
            this.Controls.Add(this.listadoCategorias);
            this.Controls.Add(this.txtBusquedaCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListadoCategoria";
            this.Text = "FormListarCategoria";
            this.Load += new System.EventHandler(this.FormListadoCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasListaCat;
        private System.Windows.Forms.Button btnBusquedaCat;
        private System.Windows.Forms.Label lblBusquedaCategorias;
        private System.Windows.Forms.ListBox listadoCategorias;
        private System.Windows.Forms.TextBox txtBusquedaCategorias;
        private System.Windows.Forms.Button btnBorrarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Label lblTituloCategoria;
    }
}