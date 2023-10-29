namespace crudSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTabEmpleado = new System.Windows.Forms.Button();
            this.btnTabProductos = new System.Windows.Forms.Button();
            this.btnTabDepartamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTabEmpleado
            // 
            this.btnTabEmpleado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTabEmpleado.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabEmpleado.Image = global::crudSQL.Properties.Resources._2620528_choose_employee_job_seeker_unemployee_icon;
            this.btnTabEmpleado.Location = new System.Drawing.Point(468, 119);
            this.btnTabEmpleado.Name = "btnTabEmpleado";
            this.btnTabEmpleado.Size = new System.Drawing.Size(192, 179);
            this.btnTabEmpleado.TabIndex = 1;
            this.btnTabEmpleado.Text = "Empleados";
            this.btnTabEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabEmpleado.UseVisualStyleBackColor = false;
            this.btnTabEmpleado.Click += new System.EventHandler(this.btnTabEmpleado_Click);
            // 
            // btnTabProductos
            // 
            this.btnTabProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTabProductos.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabProductos.Image = global::crudSQL.Properties.Resources._196741_box_open_products_package_icon;
            this.btnTabProductos.Location = new System.Drawing.Point(254, 119);
            this.btnTabProductos.Name = "btnTabProductos";
            this.btnTabProductos.Size = new System.Drawing.Size(192, 179);
            this.btnTabProductos.TabIndex = 2;
            this.btnTabProductos.Text = "Productos";
            this.btnTabProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabProductos.UseVisualStyleBackColor = false;
            this.btnTabProductos.Click += new System.EventHandler(this.btnTabProductos_Click);
            // 
            // btnTabDepartamentos
            // 
            this.btnTabDepartamentos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTabDepartamentos.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabDepartamentos.Image = global::crudSQL.Properties.Resources._49580_binary_department_organization_chart_tree_icon;
            this.btnTabDepartamentos.Location = new System.Drawing.Point(53, 119);
            this.btnTabDepartamentos.Name = "btnTabDepartamentos";
            this.btnTabDepartamentos.Size = new System.Drawing.Size(178, 179);
            this.btnTabDepartamentos.TabIndex = 0;
            this.btnTabDepartamentos.Text = "Departamentos\r\n";
            this.btnTabDepartamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabDepartamentos.UseVisualStyleBackColor = false;
            this.btnTabDepartamentos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(731, 390);
            this.Controls.Add(this.btnTabProductos);
            this.Controls.Add(this.btnTabEmpleado);
            this.Controls.Add(this.btnTabDepartamentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTabDepartamentos;
        private System.Windows.Forms.Button btnTabEmpleado;
        private System.Windows.Forms.Button btnTabProductos;
    }
}

