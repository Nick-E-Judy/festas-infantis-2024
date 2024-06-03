namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtCPF = new TextBox();
            label5 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(298, 182);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(410, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 11.25F);
            txtCPF.Location = new Point(117, 142);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(393, 27);
            txtCPF.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(53, 142);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 12;
            label5.Text = "CPF:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 11.25F);
            txtTelefone.Location = new Point(117, 105);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(393, 27);
            txtTelefone.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(41, 107);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 14;
            label4.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F);
            txtNome.Location = new Point(117, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(393, 27);
            txtNome.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(59, 72);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 16;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(117, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(87, 39);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 8;
            label1.Text = "Id:";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 234);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCPF);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtCPF;
        private Label label5;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}