namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dataGridRegistros = new System.Windows.Forms.DataGridView();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSet = new CRUD.CRUDDataSet();
            this.cadastroTableAdapter = new CRUD.CRUDDataSetTableAdapters.CadastroTableAdapter();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: *";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(8, 44);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(65, 18);
            this.lblCelular.TabIndex = 1;
            this.lblCelular.Text = "Celular: *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 16);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 10;
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(75, 44);
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(133, 20);
            this.mskCel.TabIndex = 11;
            this.mskCel.Enter += new System.EventHandler(this.MskCel_Enter);
            this.mskCel.Leave += new System.EventHandler(this.MskCel_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(42, 180);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(130, 180);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // dataGridRegistros
            // 
            this.dataGridRegistros.AllowUserToAddRows = false;
            this.dataGridRegistros.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridRegistros.DataSource = this.cadastroBindingSource;
            this.dataGridRegistros.Location = new System.Drawing.Point(244, 18);
            this.dataGridRegistros.Name = "dataGridRegistros";
            this.dataGridRegistros.ReadOnly = true;
            this.dataGridRegistros.RowHeadersVisible = false;
            this.dataGridRegistros.Size = new System.Drawing.Size(271, 150);
            this.dataGridRegistros.TabIndex = 15;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "Id_Pessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "Id_Pessoa";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPessoaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 152;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 152;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 115;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 115;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "Cadastro";
            this.cadastroBindingSource.DataSource = this.cRUDDataSet;
            // 
            // cRUDDataSet
            // 
            this.cRUDDataSet.DataSetName = "CRUDDataSet";
            this.cRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(222, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 235);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataGridRegistros);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dataGridRegistros;
        private CRUDDataSet cRUDDataSet;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private CRUDDataSetTableAdapters.CadastroTableAdapter cadastroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpar;
    }
}

