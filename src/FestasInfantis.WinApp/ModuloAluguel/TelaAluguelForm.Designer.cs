namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            txtId = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            txtNumero = new TextBox();
            txtEstado = new TextBox();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            txtCidade = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            gbFesta = new GroupBox();
            dtpHoraFim = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpDataFesta = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            gbPagamento = new GroupBox();
            toolStripCalcular = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txtValorPendente = new TextBox();
            txtValorTemaDesc = new TextBox();
            txtValorSinal = new TextBox();
            txtValorTema = new TextBox();
            txtDesc = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            cbTema = new ComboBox();
            cbSinal = new ComboBox();
            cbCliente = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbFesta.SuspendLayout();
            tabPage2.SuspendLayout();
            gbPagamento.SuspendLayout();
            toolStripCalcular.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(88, 45);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 32);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(53, 49);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 11;
            label1.Text = "Id:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(53, 104);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(571, 407);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(gbFesta);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(563, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados da Festa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(txtEstado);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(27, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(469, 152);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(389, 105);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(58, 27);
            txtNumero.TabIndex = 9;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(382, 29);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(65, 27);
            txtEstado.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(80, 105);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(233, 27);
            txtBairro.TabIndex = 7;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(80, 69);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(367, 27);
            txtRua.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(80, 29);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(233, 27);
            txtCidade.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 108);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 4;
            label9.Text = "Número:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 108);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 3;
            label8.Text = "Bairro: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 69);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 2;
            label7.Text = "Rua:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 33);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 1;
            label6.Text = "Estado: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 33);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 0;
            label5.Text = "Cidade: ";
            // 
            // gbFesta
            // 
            gbFesta.Controls.Add(dtpHoraFim);
            gbFesta.Controls.Add(dtpHoraInicio);
            gbFesta.Controls.Add(dtpDataFesta);
            gbFesta.Controls.Add(label4);
            gbFesta.Controls.Add(label3);
            gbFesta.Controls.Add(label2);
            gbFesta.Location = new Point(27, 31);
            gbFesta.Name = "gbFesta";
            gbFesta.Size = new Size(469, 147);
            gbFesta.TabIndex = 0;
            gbFesta.TabStop = false;
            gbFesta.Text = "Data e Hora";
            // 
            // dtpHoraFim
            // 
            dtpHoraFim.CustomFormat = "HH:mm";
            dtpHoraFim.Format = DateTimePickerFormat.Custom;
            dtpHoraFim.Location = new Point(165, 100);
            dtpHoraFim.Name = "dtpHoraFim";
            dtpHoraFim.ShowUpDown = true;
            dtpHoraFim.Size = new Size(83, 27);
            dtpHoraFim.TabIndex = 5;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(155, 61);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(92, 27);
            dtpHoraInicio.TabIndex = 4;
            // 
            // dtpDataFesta
            // 
            dtpDataFesta.Format = DateTimePickerFormat.Short;
            dtpDataFesta.Location = new Point(130, 29);
            dtpDataFesta.Name = "dtpDataFesta";
            dtpDataFesta.Size = new Size(117, 27);
            dtpDataFesta.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 100);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 2;
            label4.Text = "Horario de Termino: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 65);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 1;
            label3.Text = "Horario de Inicio: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 35);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 0;
            label2.Text = "Data da Festa:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(gbPagamento);
            tabPage2.Controls.Add(cbTema);
            tabPage2.Controls.Add(cbSinal);
            tabPage2.Controls.Add(cbCliente);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(563, 374);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados do Aluguel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbPagamento
            // 
            gbPagamento.Controls.Add(toolStripCalcular);
            gbPagamento.Controls.Add(txtValorPendente);
            gbPagamento.Controls.Add(txtValorTemaDesc);
            gbPagamento.Controls.Add(txtValorSinal);
            gbPagamento.Controls.Add(txtValorTema);
            gbPagamento.Controls.Add(txtDesc);
            gbPagamento.Controls.Add(label18);
            gbPagamento.Controls.Add(label17);
            gbPagamento.Controls.Add(label16);
            gbPagamento.Controls.Add(label15);
            gbPagamento.Controls.Add(label14);
            gbPagamento.Controls.Add(label13);
            gbPagamento.Location = new Point(25, 141);
            gbPagamento.Name = "gbPagamento";
            gbPagamento.Size = new Size(510, 213);
            gbPagamento.TabIndex = 6;
            gbPagamento.TabStop = false;
            gbPagamento.Text = "Dados de Pagamento";
            // 
            // toolStripCalcular
            // 
            toolStripCalcular.ImageScalingSize = new Size(20, 20);
            toolStripCalcular.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1 });
            toolStripCalcular.Location = new Point(3, 23);
            toolStripCalcular.Name = "toolStripCalcular";
            toolStripCalcular.Size = new Size(504, 27);
            toolStripCalcular.TabIndex = 11;
            toolStripCalcular.Text = "Calcular";
            toolStripCalcular.Click += toolStripCalcular_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.btnDesconto;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "Calcular";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(62, 24);
            toolStripLabel1.Text = "Calcular";
            // 
            // txtValorPendente
            // 
            txtValorPendente.Enabled = false;
            txtValorPendente.Location = new Point(385, 165);
            txtValorPendente.Name = "txtValorPendente";
            txtValorPendente.Size = new Size(114, 27);
            txtValorPendente.TabIndex = 10;
            // 
            // txtValorTemaDesc
            // 
            txtValorTemaDesc.Enabled = false;
            txtValorTemaDesc.Location = new Point(385, 125);
            txtValorTemaDesc.Name = "txtValorTemaDesc";
            txtValorTemaDesc.Size = new Size(114, 27);
            txtValorTemaDesc.TabIndex = 9;
            // 
            // txtValorSinal
            // 
            txtValorSinal.Enabled = false;
            txtValorSinal.Location = new Point(129, 165);
            txtValorSinal.Name = "txtValorSinal";
            txtValorSinal.Size = new Size(134, 27);
            txtValorSinal.TabIndex = 8;
            // 
            // txtValorTema
            // 
            txtValorTema.Enabled = false;
            txtValorTema.Location = new Point(133, 117);
            txtValorTema.Name = "txtValorTema";
            txtValorTema.Size = new Size(130, 27);
            txtValorTema.TabIndex = 7;
            // 
            // txtDesc
            // 
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(138, 76);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(125, 27);
            txtDesc.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(274, 169);
            label18.Name = "label18";
            label18.Size = new Size(115, 20);
            label18.TabIndex = 5;
            label18.Text = "Valor Pendente: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(274, 140);
            label17.Name = "label17";
            label17.Size = new Size(106, 20);
            label17.TabIndex = 4;
            label17.Text = "com desconto:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(274, 120);
            label16.Name = "label16";
            label16.Size = new Size(103, 20);
            label16.TabIndex = 3;
            label16.Text = "Valor do tema";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 169);
            label15.Name = "label15";
            label15.Size = new Size(104, 20);
            label15.TabIndex = 2;
            label15.Text = "Valor do Sinal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 120);
            label14.Name = "label14";
            label14.Size = new Size(108, 20);
            label14.TabIndex = 1;
            label14.Text = "Valor do Tema:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 79);
            label13.Name = "label13";
            label13.Size = new Size(113, 20);
            label13.TabIndex = 0;
            label13.Text = "% de Desconto ";
            // 
            // cbTema
            // 
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(367, 31);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(169, 28);
            cbTema.TabIndex = 5;
            // 
            // cbSinal
            // 
            cbSinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSinal.FormattingEnabled = true;
            cbSinal.Items.AddRange(new object[] { "40", "50" });
            cbSinal.Location = new Point(81, 85);
            cbSinal.Name = "cbSinal";
            cbSinal.Size = new Size(191, 28);
            cbSinal.TabIndex = 4;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(81, 31);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(191, 28);
            cbCliente.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 89);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 2;
            label12.Text = "Sinal:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(299, 35);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 1;
            label11.Text = "Tema:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 35);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 0;
            label10.Text = "Cliente: ";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(339, 517);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(467, 517);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 580);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(tabControl1);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaAluguelForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaAluguelForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbFesta.ResumeLayout(false);
            gbFesta.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            gbPagamento.ResumeLayout(false);
            gbPagamento.PerformLayout();
            toolStripCalcular.ResumeLayout(false);
            toolStripCalcular.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnGravar;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox gbFesta;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtRua;
        private TextBox txtCidade;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpDataFesta;
        private TextBox txtNumero;
        private TextBox txtEstado;
        private TextBox txtBairro;
        private DateTimePicker dtpHoraFim;
        private GroupBox gbPagamento;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox cbTema;
        private ComboBox cbSinal;
        private ComboBox cbCliente;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtDesc;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox txtValorSinal;
        private TextBox txtValorTema;
        private TextBox txtValorPendente;
        private TextBox txtValorTemaDesc;
        private ToolStrip toolStripCalcular;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
    }
}