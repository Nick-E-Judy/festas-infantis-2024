﻿namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class ListagemClienteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listClientes = new ListBox();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.Dock = DockStyle.Fill;
            listClientes.FormattingEnabled = true;
            listClientes.Location = new Point(0, 0);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(700, 396);
            listClientes.TabIndex = 0;
            // 
            // ListagemClienteControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listClientes);
            Name = "ListagemClienteControl";
            Size = new Size(700, 396);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listClientes;
    }
}
