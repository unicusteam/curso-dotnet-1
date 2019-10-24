namespace DevMaker.WF
{
    partial class Form1
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
            this.textoTextBox = new System.Windows.Forms.TextBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apagarButton = new System.Windows.Forms.Button();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEspecie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textoTextBox
            // 
            this.textoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Nome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textoTextBox.Location = new System.Drawing.Point(64, 6);
            this.textoTextBox.MaxLength = 60;
            this.textoTextBox.Name = "textoTextBox";
            this.textoTextBox.Size = new System.Drawing.Size(375, 20);
            this.textoTextBox.TabIndex = 0;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(DevMaker.WF.Entidades.Animal);
            // 
            // numeroNumericUpDown
            // 
            this.numeroNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animalBindingSource, "Idade", true));
            this.numeroNumericUpDown.Location = new System.Drawing.Point(64, 32);
            this.numeroNumericUpDown.Name = "numeroNumericUpDown";
            this.numeroNumericUpDown.Size = new System.Drawing.Size(375, 20);
            this.numeroNumericUpDown.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.animalBindingSource, "Especie", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(375, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(364, 85);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 4;
            this.button.Text = "Inserir";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Espécie";
            // 
            // apagarButton
            // 
            this.apagarButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.apagarButton.Location = new System.Drawing.Point(97, 314);
            this.apagarButton.Name = "apagarButton";
            this.apagarButton.Size = new System.Drawing.Size(75, 23);
            this.apagarButton.TabIndex = 9;
            this.apagarButton.Text = "Apagar";
            this.apagarButton.UseVisualStyleBackColor = true;
            this.apagarButton.Click += new System.EventHandler(this.ApagarButton_Click);
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataSource = typeof(DevMaker.WF.Entidades.Animal);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.animaisBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(16, 114);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(423, 194);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNome,
            this.colIdade,
            this.colEspecie});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNome
            // 
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 0;
            // 
            // colIdade
            // 
            this.colIdade.FieldName = "Idade";
            this.colIdade.Name = "colIdade";
            this.colIdade.Visible = true;
            this.colIdade.VisibleIndex = 1;
            // 
            // colEspecie
            // 
            this.colEspecie.FieldName = "Especie";
            this.colEspecie.Name = "colEspecie";
            this.colEspecie.Visible = true;
            this.colEspecie.VisibleIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.apagarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numeroNumericUpDown);
            this.Controls.Add(this.textoTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTextBox;
        private System.Windows.Forms.NumericUpDown numeroNumericUpDown;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.Button apagarButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colIdade;
        private DevExpress.XtraGrid.Columns.GridColumn colEspecie;
        private System.Windows.Forms.Button button1;
    }
}

