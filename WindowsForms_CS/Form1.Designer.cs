namespace WindowsForms_CS
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviarDatos = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlFormularioOrganizado = new System.Windows.Forms.Panel();
            this.dgvDatosFormulario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pnlFormularioOrganizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEnviarDatos);
            this.panel1.Controls.Add(this.dtpFechaNacimiento);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtNumeroTelefono);
            this.panel1.Controls.Add(this.txtApMaterno);
            this.panel1.Controls.Add(this.txtApPaterno);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(993, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 623);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero de telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // btnEnviarDatos
            // 
            this.btnEnviarDatos.Location = new System.Drawing.Point(355, 361);
            this.btnEnviarDatos.Name = "btnEnviarDatos";
            this.btnEnviarDatos.Size = new System.Drawing.Size(156, 61);
            this.btnEnviarDatos.TabIndex = 6;
            this.btnEnviarDatos.Text = "Enviar";
            this.btnEnviarDatos.UseVisualStyleBackColor = true;
            this.btnEnviarDatos.Click += new System.EventHandler(this.btnEnviarDatos_Click_1);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(248, 305);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(262, 32);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(248, 258);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(263, 32);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(248, 208);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(263, 32);
            this.txtNumeroTelefono.TabIndex = 3;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(248, 159);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(263, 32);
            this.txtApMaterno.TabIndex = 2;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(248, 108);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(263, 32);
            this.txtApPaterno.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(248, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 32);
            this.txtNombre.TabIndex = 0;
            // 
            // pnlFormularioOrganizado
            // 
            this.pnlFormularioOrganizado.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormularioOrganizado.Controls.Add(this.dgvDatosFormulario);
            this.pnlFormularioOrganizado.Controls.Add(this.btnEliminar);
            this.pnlFormularioOrganizado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFormularioOrganizado.Location = new System.Drawing.Point(-9, -10);
            this.pnlFormularioOrganizado.Name = "pnlFormularioOrganizado";
            this.pnlFormularioOrganizado.Size = new System.Drawing.Size(976, 611);
            this.pnlFormularioOrganizado.TabIndex = 1;
            // 
            // dgvDatosFormulario
            // 
            this.dgvDatosFormulario.AllowUserToAddRows = false;
            this.dgvDatosFormulario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosFormulario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosFormulario.BackgroundColor = System.Drawing.Color.Violet;
            this.dgvDatosFormulario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatosFormulario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosFormulario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosFormulario.ColumnHeadersHeight = 60;
            this.dgvDatosFormulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosFormulario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDatosFormulario.EnableHeadersVisualStyles = false;
            this.dgvDatosFormulario.GridColor = System.Drawing.Color.Violet;
            this.dgvDatosFormulario.Location = new System.Drawing.Point(21, 89);
            this.dgvDatosFormulario.Name = "dgvDatosFormulario";
            this.dgvDatosFormulario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDatosFormulario.RowHeadersVisible = false;
            this.dgvDatosFormulario.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatosFormulario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosFormulario.RowTemplate.Height = 24;
            this.dgvDatosFormulario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosFormulario.Size = new System.Drawing.Size(936, 390);
            this.dgvDatosFormulario.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 57;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Apellido paterno";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 186;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Apellido materno";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 190;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 117;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numero de telefono";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 215;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Correo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 104;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de nacimiento";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 225;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Edad";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 90;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(21, 485);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 61);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // ErrorProvider2
            // 
            this.ErrorProvider2.ContainerControl = this;
            // 
            // ErrorProvider3
            // 
            this.ErrorProvider3.ContainerControl = this;
            // 
            // ErrorProvider4
            // 
            this.ErrorProvider4.ContainerControl = this;
            // 
            // ErrorProvider5
            // 
            this.ErrorProvider5.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 601);
            this.Controls.Add(this.pnlFormularioOrganizado);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFormularioOrganizado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviarDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlFormularioOrganizado;
        private System.Windows.Forms.DataGridView dgvDatosFormulario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.ErrorProvider ErrorProvider2;
        private System.Windows.Forms.ErrorProvider ErrorProvider3;
        private System.Windows.Forms.ErrorProvider ErrorProvider4;
        private System.Windows.Forms.ErrorProvider ErrorProvider5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

