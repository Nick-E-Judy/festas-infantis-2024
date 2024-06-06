namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class ListagemAluguelControl
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
            listAlugueis = new ListBox();
            SuspendLayout();
            // 
            // listAlugueis
            // 
            listAlugueis.Dock = DockStyle.Fill;
            listAlugueis.FormattingEnabled = true;
            listAlugueis.Location = new Point(0, 0);
            listAlugueis.Name = "listAlugueis";
            listAlugueis.Size = new Size(776, 439);
            listAlugueis.TabIndex = 0;
            // 
            // ListagemAluguelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listAlugueis);
            Name = "ListagemAluguelControl";
            Size = new Size(776, 439);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listAlugueis;
    }
}
