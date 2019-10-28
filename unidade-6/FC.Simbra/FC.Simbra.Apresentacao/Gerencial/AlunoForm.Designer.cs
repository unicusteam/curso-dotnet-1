using FC.Simbra.Apresentacao.Gerencial;

namespace FC.Simbra.Apresentacao.Gerencial
{
    partial class AlunoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExluir = new System.Windows.Forms.Button();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelIdentificador = new System.Windows.Forms.Panel();
            this.gridAlunos = new System.Windows.Forms.DataGridView();
            this.txPesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFormulario = new System.Windows.Forms.BindingSource(this.components);
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naturalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGrid = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inserirDisciplinaButton = new System.Windows.Forms.Button();
            this.disciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelIdentificador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matrícula";
            // 
            // tbDataNascimento
            // 
            this.tbDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFormulario, "DataNascimento", true));
            this.tbDataNascimento.Location = new System.Drawing.Point(122, 68);
            this.tbDataNascimento.Mask = "00/00/0000";
            this.tbDataNascimento.Name = "tbDataNascimento";
            this.tbDataNascimento.Size = new System.Drawing.Size(106, 20);
            this.tbDataNascimento.TabIndex = 3;
            this.tbDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tbMatricula
            // 
            this.tbMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMatricula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFormulario, "Matricula", true));
            this.tbMatricula.Location = new System.Drawing.Point(477, 10);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(198, 20);
            this.tbMatricula.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFormulario, "Nome", true));
            this.tbNome.Location = new System.Drawing.Point(53, 42);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(622, 20);
            this.tbNome.TabIndex = 5;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.Location = new System.Drawing.Point(357, 254);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtCadastrar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditar.Location = new System.Drawing.Point(438, 254);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // btExluir
            // 
            this.btExluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExluir.Location = new System.Drawing.Point(600, 254);
            this.btExluir.Name = "btExluir";
            this.btExluir.Size = new System.Drawing.Size(75, 23);
            this.btExluir.TabIndex = 8;
            this.btExluir.Text = "Excluir";
            this.btExluir.UseVisualStyleBackColor = true;
            this.btExluir.Click += new System.EventHandler(this.BtExluir_Click);
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFormulario, "Id", true));
            this.tbIdentificador.Location = new System.Drawing.Point(51, 6);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.ReadOnly = true;
            this.tbIdentificador.Size = new System.Drawing.Size(86, 20);
            this.tbIdentificador.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // panelIdentificador
            // 
            this.panelIdentificador.Controls.Add(this.label4);
            this.panelIdentificador.Controls.Add(this.tbIdentificador);
            this.panelIdentificador.Location = new System.Drawing.Point(2, 4);
            this.panelIdentificador.Name = "panelIdentificador";
            this.panelIdentificador.Size = new System.Drawing.Size(246, 32);
            this.panelIdentificador.TabIndex = 11;
            this.panelIdentificador.Visible = false;
            // 
            // gridAlunos
            // 
            this.gridAlunos.AllowUserToAddRows = false;
            this.gridAlunos.AllowUserToDeleteRows = false;
            this.gridAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAlunos.AutoGenerateColumns = false;
            this.gridAlunos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.Naturalidade});
            this.gridAlunos.DataSource = this.bsGrid;
            this.gridAlunos.Location = new System.Drawing.Point(2, 364);
            this.gridAlunos.Name = "gridAlunos";
            this.gridAlunos.ReadOnly = true;
            this.gridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlunos.Size = new System.Drawing.Size(673, 191);
            this.gridAlunos.TabIndex = 12;
            // 
            // txPesquisar
            // 
            this.txPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPesquisar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txPesquisar.Location = new System.Drawing.Point(67, 338);
            this.txPesquisar.Name = "txPesquisar";
            this.txPesquisar.Size = new System.Drawing.Size(608, 20);
            this.txPesquisar.TabIndex = 13;
            this.txPesquisar.TextChanged += new System.EventHandler(this.TxPesquisar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pesquisar:";
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(519, 254);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cidade";
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsFormulario, "Naturalidade", true));
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsFormulario, "Naturalidade", true));
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFormulario, "Naturalidade", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Location = new System.Drawing.Point(307, 66);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(368, 21);
            this.cidadeComboBox.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Naturalidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Naturalidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsFormulario
            // 
            this.bsFormulario.DataSource = typeof(FC.Simbra.Dominio.Gerencial.Aluno);
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Naturalidade
            // 
            this.Naturalidade.DataPropertyName = "Naturalidade";
            this.Naturalidade.HeaderText = "Naturalidade";
            this.Naturalidade.Name = "Naturalidade";
            this.Naturalidade.ReadOnly = true;
            // 
            // bsGrid
            // 
            this.bsGrid.DataSource = typeof(FC.Simbra.Dominio.Gerencial.Aluno);
            // 
            // disciplinaComboBox
            // 
            this.disciplinaComboBox.FormattingEnabled = true;
            this.disciplinaComboBox.Location = new System.Drawing.Point(6, 19);
            this.disciplinaComboBox.Name = "disciplinaComboBox";
            this.disciplinaComboBox.Size = new System.Drawing.Size(243, 21);
            this.disciplinaComboBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inserirDisciplinaButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.disciplinaComboBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 142);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disciplinas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplinaDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.disciplinasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 89);
            this.dataGridView1.TabIndex = 19;
            // 
            // inserirDisciplinaButton
            // 
            this.inserirDisciplinaButton.Location = new System.Drawing.Point(579, 17);
            this.inserirDisciplinaButton.Name = "inserirDisciplinaButton";
            this.inserirDisciplinaButton.Size = new System.Drawing.Size(75, 23);
            this.inserirDisciplinaButton.TabIndex = 20;
            this.inserirDisciplinaButton.Text = "add";
            this.inserirDisciplinaButton.UseVisualStyleBackColor = true;
            this.inserirDisciplinaButton.Click += new System.EventHandler(this.InserirDisciplinaButton_Click);
            // 
            // disciplinasBindingSource
            // 
            this.disciplinasBindingSource.DataMember = "Disciplinas";
            this.disciplinasBindingSource.DataSource = this.bsFormulario;
            // 
            // disciplinaDataGridViewTextBoxColumn
            // 
            this.disciplinaDataGridViewTextBoxColumn.DataPropertyName = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.Name = "disciplinaDataGridViewTextBoxColumn";
            this.disciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPesquisar);
            this.Controls.Add(this.gridAlunos);
            this.Controls.Add(this.panelIdentificador);
            this.Controls.Add(this.btExluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.tbDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Simbra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelIdentificador.ResumeLayout(false);
            this.panelIdentificador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbDataNascimento;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExluir;
        private System.Windows.Forms.BindingSource bsFormulario;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelIdentificador;
        private System.Windows.Forms.DataGridView gridAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsGrid;
        private System.Windows.Forms.TextBox txPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naturalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox disciplinaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inserirDisciplinaButton;
        private System.Windows.Forms.BindingSource disciplinasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
    }
}