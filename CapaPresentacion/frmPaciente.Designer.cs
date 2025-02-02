﻿namespace CapaPresentacion
{
    partial class frmPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.cblBusqueda = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cblEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdpaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtNombre_Paciente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cblTipo_Cedula = new System.Windows.Forms.ComboBox();
            this.dtpFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cblSexo = new System.Windows.Forms.ComboBox();
            this.cblEstado_Civil = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSangre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.txtTalla = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1605, 76);
            this.panel3.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(477, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pacientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(71, 466);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 43);
            this.btnNuevo.TabIndex = 196;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnAnular.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(73, 864);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(121, 43);
            this.btnAnular.TabIndex = 195;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // cblBusqueda
            // 
            this.cblBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cblBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblBusqueda.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cblBusqueda.ForeColor = System.Drawing.Color.DarkCyan;
            this.cblBusqueda.FormattingEnabled = true;
            this.cblBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Cedula"});
            this.cblBusqueda.Location = new System.Drawing.Point(1158, 476);
            this.cblBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cblBusqueda.Name = "cblBusqueda";
            this.cblBusqueda.Size = new System.Drawing.Size(160, 40);
            this.cblBusqueda.TabIndex = 194;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.ColumnHeadersHeight = 50;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataListado.GridColor = System.Drawing.Color.DarkCyan;
            this.dataListado.Location = new System.Drawing.Point(73, 522);
            this.dataListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListado.RowHeadersWidth = 80;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(1469, 296);
            this.dataListado.TabIndex = 193;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.MinimumWidth = 6;
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Width = 125;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTotal.Location = new System.Drawing.Point(1216, 820);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 32);
            this.lblTotal.TabIndex = 192;
            this.lblTotal.Text = "label3";
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.chkAnular.ForeColor = System.Drawing.Color.DarkCyan;
            this.chkAnular.Location = new System.Drawing.Point(73, 822);
            this.chkAnular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(178, 36);
            this.chkAnular.TabIndex = 191;
            this.chkAnular.Text = "Seleccionados";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.chkAnular_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtBuscar.Location = new System.Drawing.Point(1325, 475);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 39);
            this.txtBuscar.TabIndex = 190;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(458, 466);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 43);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(329, 466);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 43);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(200, 466);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 43);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.Location = new System.Drawing.Point(242, 296);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Mask = "(####).###.####";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(241, 22);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNumero_Cedula
            // 
            this.txtNumero_Cedula.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumero_Cedula.Location = new System.Drawing.Point(316, 181);
            this.txtNumero_Cedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero_Cedula.Mask = "##,###,###";
            this.txtNumero_Cedula.Name = "txtNumero_Cedula";
            this.txtNumero_Cedula.Size = new System.Drawing.Size(167, 22);
            this.txtNumero_Cedula.TabIndex = 1;
            this.txtNumero_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_Cedula_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(723, 282);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(241, 96);
            this.txtDireccion.TabIndex = 7;
            // 
            // cblEstado
            // 
            this.cblEstado.BackColor = System.Drawing.SystemColors.Control;
            this.cblEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblEstado.Enabled = false;
            this.cblEstado.FormattingEnabled = true;
            this.cblEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cblEstado.Location = new System.Drawing.Point(1214, 381);
            this.cblEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblEstado.Name = "cblEstado";
            this.cblEstado.Size = new System.Drawing.Size(143, 24);
            this.cblEstado.TabIndex = 184;
            this.cblEstado.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(113, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Código:";
            this.label3.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(1066, 373);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 32);
            this.label17.TabIndex = 183;
            this.label17.Text = "Estado";
            this.label17.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(144, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 157;
            this.label4.Text = "Cedula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(1065, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 32);
            this.label8.TabIndex = 181;
            this.label8.Text = "Talla";
            // 
            // txtIdpaciente
            // 
            this.txtIdpaciente.BackColor = System.Drawing.Color.White;
            this.txtIdpaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdpaciente.Enabled = false;
            this.txtIdpaciente.Location = new System.Drawing.Point(231, 106);
            this.txtIdpaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdpaciente.Name = "txtIdpaciente";
            this.txtIdpaciente.Size = new System.Drawing.Size(67, 15);
            this.txtIdpaciente.TabIndex = 159;
            this.txtIdpaciente.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(1066, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 32);
            this.label7.TabIndex = 179;
            this.label7.Text = "Peso";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Location = new System.Drawing.Point(723, 227);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 22);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(619, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 32);
            this.label16.TabIndex = 177;
            this.label16.Text = "Correo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(131, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 32);
            this.label15.TabIndex = 176;
            this.label15.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(131, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 160;
            this.label6.Text = "Nombre";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.BackColor = System.Drawing.SystemColors.Control;
            this.txtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOcupacion.Location = new System.Drawing.Point(1214, 319);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(143, 22);
            this.txtOcupacion.TabIndex = 11;
            // 
            // txtNombre_Paciente
            // 
            this.txtNombre_Paciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre_Paciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre_Paciente.Location = new System.Drawing.Point(242, 245);
            this.txtNombre_Paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre_Paciente.Name = "txtNombre_Paciente";
            this.txtNombre_Paciente.Size = new System.Drawing.Size(241, 22);
            this.txtNombre_Paciente.TabIndex = 2;
            this.txtNombre_Paciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_Paciente_KeyPress);
            this.txtNombre_Paciente.Leave += new System.EventHandler(this.txtNombre_Paciente_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(1066, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 32);
            this.label14.TabIndex = 174;
            this.label14.Text = "Ocupacion";
            // 
            // cblTipo_Cedula
            // 
            this.cblTipo_Cedula.BackColor = System.Drawing.SystemColors.Control;
            this.cblTipo_Cedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblTipo_Cedula.FormattingEnabled = true;
            this.cblTipo_Cedula.Items.AddRange(new object[] {
            "V",
            "E"});
            this.cblTipo_Cedula.Location = new System.Drawing.Point(242, 179);
            this.cblTipo_Cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblTipo_Cedula.Name = "cblTipo_Cedula";
            this.cblTipo_Cedula.Size = new System.Drawing.Size(67, 24);
            this.cblTipo_Cedula.TabIndex = 0;
            this.cblTipo_Cedula.Leave += new System.EventHandler(this.cblTipo_Cedula_Leave);
            // 
            // dtpFecha_Nacimiento
            // 
            this.dtpFecha_Nacimiento.CustomFormat = "";
            this.dtpFecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Nacimiento.Location = new System.Drawing.Point(723, 175);
            this.dtpFecha_Nacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha_Nacimiento.Name = "dtpFecha_Nacimiento";
            this.dtpFecha_Nacimiento.Size = new System.Drawing.Size(241, 22);
            this.dtpFecha_Nacimiento.TabIndex = 5;
            this.dtpFecha_Nacimiento.Value = new System.DateTime(2009, 7, 11, 0, 0, 0, 0);
            this.dtpFecha_Nacimiento.CloseUp += new System.EventHandler(this.dtpFecha_Nacimiento_CloseUp);
            this.dtpFecha_Nacimiento.ValueChanged += new System.EventHandler(this.dtpFecha_Nacimiento_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(594, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 32);
            this.label13.TabIndex = 172;
            this.label13.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(594, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 32);
            this.label9.TabIndex = 165;
            this.label9.Text = "Fecha nac.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(1060, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 32);
            this.label10.TabIndex = 166;
            this.label10.Text = "Sexo";
            // 
            // cblSexo
            // 
            this.cblSexo.BackColor = System.Drawing.SystemColors.Control;
            this.cblSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblSexo.FormattingEnabled = true;
            this.cblSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cblSexo.Location = new System.Drawing.Point(1214, 162);
            this.cblSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblSexo.Name = "cblSexo";
            this.cblSexo.Size = new System.Drawing.Size(143, 24);
            this.cblSexo.TabIndex = 8;
            // 
            // cblEstado_Civil
            // 
            this.cblEstado_Civil.BackColor = System.Drawing.SystemColors.Control;
            this.cblEstado_Civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblEstado_Civil.FormattingEnabled = true;
            this.cblEstado_Civil.Items.AddRange(new object[] {
            "SOLTERO/A",
            "CASADO/A",
            "DIVORCIADO/A",
            "VIUDO/A"});
            this.cblEstado_Civil.Location = new System.Drawing.Point(242, 354);
            this.cblEstado_Civil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblEstado_Civil.Name = "cblEstado_Civil";
            this.cblEstado_Civil.Size = new System.Drawing.Size(241, 24);
            this.cblEstado_Civil.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(84, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 32);
            this.label11.TabIndex = 168;
            this.label11.Text = "Estado Civil";
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGrafica.FlatAppearance.BorderSize = 0;
            this.btnGrafica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafica.Location = new System.Drawing.Point(1315, 882);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(227, 43);
            this.btnGrafica.TabIndex = 199;
            this.btnGrafica.Text = "Generar Reporte";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label12.Location = new System.Drawing.Point(112, 179);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 32);
            this.label12.TabIndex = 201;
            this.label12.Text = "*";
            this.label12.MouseHover += new System.EventHandler(this.label12_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(99, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 32);
            this.label2.TabIndex = 202;
            this.label2.Text = "*";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // btnSangre
            // 
            this.btnSangre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSangre.BackColor = System.Drawing.Color.Azure;
            this.btnSangre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSangre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSangre.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.btnSangre.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSangre.Image = global::CapaPresentacion.Properties.Resources.blood_drop;
            this.btnSangre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSangre.Location = new System.Drawing.Point(506, 864);
            this.btnSangre.Name = "btnSangre";
            this.btnSangre.Size = new System.Drawing.Size(632, 55);
            this.btnSangre.TabIndex = 203;
            this.btnSangre.Text = "Encontrar donantes de sangre compatible";
            this.btnSangre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSangre.UseVisualStyleBackColor = false;
            this.btnSangre.Visible = false;
            this.btnSangre.Click += new System.EventHandler(this.btnSangre_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(1316, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 32);
            this.label5.TabIndex = 204;
            this.label5.Text = "Kg";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(1316, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 32);
            this.label19.TabIndex = 205;
            this.label19.Text = "Mt";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.CadetBlue;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MintCream;
            this.label18.Location = new System.Drawing.Point(1491, 481);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 29);
            this.label18.TabIndex = 282;
            this.label18.Text = "🔎";
            this.label18.Click += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label20.ForeColor = System.Drawing.Color.DarkCyan;
            this.label20.Location = new System.Drawing.Point(998, 478);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 32);
            this.label20.TabIndex = 283;
            this.label20.Text = "Buscar según:";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.Control;
            this.txtPeso.Location = new System.Drawing.Point(1214, 217);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Mask = "##,##";
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(95, 22);
            this.txtPeso.TabIndex = 9;
            // 
            // txtTalla
            // 
            this.txtTalla.BackColor = System.Drawing.SystemColors.Control;
            this.txtTalla.Location = new System.Drawing.Point(1214, 260);
            this.txtTalla.Margin = new System.Windows.Forms.Padding(4);
            this.txtTalla.Mask = "#,##";
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(95, 22);
            this.txtTalla.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label21.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label21.Location = new System.Drawing.Point(562, 167);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 32);
            this.label21.TabIndex = 289;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label22.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label22.Location = new System.Drawing.Point(99, 286);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 32);
            this.label22.TabIndex = 290;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label23.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label23.Location = new System.Drawing.Point(1028, 165);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 32);
            this.label23.TabIndex = 291;
            this.label23.Text = "*";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(587, 466);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 43);
            this.btnLimpiar.TabIndex = 292;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1605, 938);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSangre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.cblBusqueda);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkAnular);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNumero_Cedula);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cblEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdpaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.txtNombre_Paciente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cblTipo_Cedula);
            this.Controls.Add(this.dtpFecha_Nacimiento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cblSexo);
            this.Controls.Add(this.cblEstado_Civil);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPaciente";
            this.Text = "frmPaciente";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.ComboBox cblBusqueda;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtNumero_Cedula;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cblEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdpaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtNombre_Paciente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cblTipo_Cedula;
        private System.Windows.Forms.DateTimePicker dtpFecha_Nacimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cblSexo;
        private System.Windows.Forms.ComboBox cblEstado_Civil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSangre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtTalla;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLimpiar;
    }
}