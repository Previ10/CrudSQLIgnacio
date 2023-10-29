namespace crudSQL.Presentacion
{
    partial class FrmDepartamentos
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
            this.txIDdepartamento = new System.Windows.Forms.TextBox();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txIDdep = new System.Windows.Forms.Label();
            this.btnCancelarDepartamento = new System.Windows.Forms.Button();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnBorrarDepartamento = new System.Windows.Forms.Button();
            this.btnModificarDepartamento = new System.Windows.Forms.Button();
            this.btnAgregarDepartamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txIDdepartamento
            // 
            this.txIDdepartamento.Location = new System.Drawing.Point(20, 74);
            this.txIDdepartamento.Name = "txIDdepartamento";
            this.txIDdepartamento.Size = new System.Drawing.Size(179, 26);
            this.txIDdepartamento.TabIndex = 2;
            this.txIDdepartamento.TextChanged += new System.EventHandler(this.txIDdepartamento_TextChanged);
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(230, 74);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(484, 26);
            this.txtNombreDepartamento.TabIndex = 3;
            this.txtNombreDepartamento.TextChanged += new System.EventHandler(this.txtNombreDepartamento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "NombreDepartamento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txIDdep
            // 
            this.txIDdep.AutoSize = true;
            this.txIDdep.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIDdep.Location = new System.Drawing.Point(27, 32);
            this.txIDdep.Name = "txIDdep";
            this.txIDdep.Size = new System.Drawing.Size(41, 27);
            this.txIDdep.TabIndex = 4;
            this.txIDdep.Text = "ID:";
            this.txIDdep.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCancelarDepartamento
            // 
            this.btnCancelarDepartamento.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarDepartamento.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDepartamento.Image = global::crudSQL.Properties.Resources._8725805_exit_icon;
            this.btnCancelarDepartamento.Location = new System.Drawing.Point(547, 663);
            this.btnCancelarDepartamento.Name = "btnCancelarDepartamento";
            this.btnCancelarDepartamento.Size = new System.Drawing.Size(202, 108);
            this.btnCancelarDepartamento.TabIndex = 18;
            this.btnCancelarDepartamento.Text = "Cancelar";
            this.btnCancelarDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarDepartamento.UseVisualStyleBackColor = false;
            this.btnCancelarDepartamento.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamentos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(20, 125);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.RowHeadersWidth = 62;
            this.dgvDepartamentos.RowTemplate.Height = 28;
            this.dgvDepartamentos.Size = new System.Drawing.Size(502, 646);
            this.dgvDepartamentos.TabIndex = 21;
            this.dgvDepartamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellContentClick);
            this.dgvDepartamentos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // btnBorrarDepartamento
            // 
            this.btnBorrarDepartamento.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBorrarDepartamento.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarDepartamento.Image = global::crudSQL.Properties.Resources._8726512_trash_icon;
            this.btnBorrarDepartamento.Location = new System.Drawing.Point(547, 353);
            this.btnBorrarDepartamento.Name = "btnBorrarDepartamento";
            this.btnBorrarDepartamento.Size = new System.Drawing.Size(202, 106);
            this.btnBorrarDepartamento.TabIndex = 17;
            this.btnBorrarDepartamento.Text = "Borrar";
            this.btnBorrarDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarDepartamento.UseVisualStyleBackColor = false;
            this.btnBorrarDepartamento.Click += new System.EventHandler(this.btnBorrarDepartamento_Click);
            // 
            // btnModificarDepartamento
            // 
            this.btnModificarDepartamento.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarDepartamento.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDepartamento.Image = global::crudSQL.Properties.Resources._8725936_edit_alt_icon;
            this.btnModificarDepartamento.Location = new System.Drawing.Point(547, 244);
            this.btnModificarDepartamento.Name = "btnModificarDepartamento";
            this.btnModificarDepartamento.Size = new System.Drawing.Size(202, 103);
            this.btnModificarDepartamento.TabIndex = 16;
            this.btnModificarDepartamento.Text = " Modificar";
            this.btnModificarDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarDepartamento.UseVisualStyleBackColor = false;
            this.btnModificarDepartamento.Click += new System.EventHandler(this.btnModificarDepartamento_Click);
            // 
            // btnAgregarDepartamento
            // 
            this.btnAgregarDepartamento.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarDepartamento.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDepartamento.Image = global::crudSQL.Properties.Resources._8726195_save_floppy_icon;
            this.btnAgregarDepartamento.Location = new System.Drawing.Point(547, 125);
            this.btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            this.btnAgregarDepartamento.Size = new System.Drawing.Size(202, 113);
            this.btnAgregarDepartamento.TabIndex = 15;
            this.btnAgregarDepartamento.Text = "Agregar";
            this.btnAgregarDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarDepartamento.UseVisualStyleBackColor = false;
            this.btnAgregarDepartamento.Click += new System.EventHandler(this.btnAgregarDepartamento_Click);
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(785, 783);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.btnCancelarDepartamento);
            this.Controls.Add(this.btnBorrarDepartamento);
            this.Controls.Add(this.btnModificarDepartamento);
            this.Controls.Add(this.btnAgregarDepartamento);
            this.Controls.Add(this.txIDdep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.txIDdepartamento);
            this.Name = "FrmDepartamentos";
            this.Text = "FrmDepartamentos";
            this.Load += new System.EventHandler(this.FrmDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txIDdepartamento;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txIDdep;
        private System.Windows.Forms.Button btnAgregarDepartamento;
        private System.Windows.Forms.Button btnModificarDepartamento;
        private System.Windows.Forms.Button btnBorrarDepartamento;
        private System.Windows.Forms.Button btnCancelarDepartamento;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
    }
}