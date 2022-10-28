namespace Grupo2_FrondEnd
{
    partial class FormFacturas
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
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btmNuevoCli = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNumFactura = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarPro = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIva = new System.Windows.Forms.Label();
            this.txtTotal1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDess = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpearR = new System.Windows.Forms.PictureBox();
            this.lbUbi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpearR)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHora.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(503, 59);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(21, 18);
            this.lbHora.TabIndex = 4;
            this.lbHora.Text = "   ";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFecha.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(503, 33);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(25, 18);
            this.lbFecha.TabIndex = 5;
            this.lbFecha.Text = "    ";
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btmNuevoCli);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(578, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btmNuevoCli
            // 
            this.btmNuevoCli.BackColor = System.Drawing.Color.Orange;
            this.btmNuevoCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmNuevoCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmNuevoCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmNuevoCli.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNuevoCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmNuevoCli.Location = new System.Drawing.Point(206, 14);
            this.btmNuevoCli.Name = "btmNuevoCli";
            this.btmNuevoCli.Size = new System.Drawing.Size(65, 22);
            this.btmNuevoCli.TabIndex = 15;
            this.btmNuevoCli.Text = "Nuevo";
            this.btmNuevoCli.UseVisualStyleBackColor = false;
            this.btmNuevoCli.Click += new System.EventHandler(this.btmNuevoCli_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(342, 42);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(136, 22);
            this.txtDireccion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(256, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dirrección:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(85, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(108, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Grupo2_FrondEnd.Properties.Resources.lupa__1_;
            this.btnBuscar.Location = new System.Drawing.Point(165, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 22);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(65, 14);
            this.txtNit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(73, 22);
            this.txtNit.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "NIT:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Orange;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Location = new System.Drawing.Point(524, 514);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 26);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "No.";
            // 
            // lbNumFactura
            // 
            this.lbNumFactura.AutoSize = true;
            this.lbNumFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNumFactura.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumFactura.Location = new System.Drawing.Point(503, 9);
            this.lbNumFactura.Name = "lbNumFactura";
            this.lbNumFactura.Size = new System.Drawing.Size(29, 18);
            this.lbNumFactura.TabIndex = 15;
            this.lbNumFactura.Text = "   1";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(111, 208);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(73, 22);
            this.txtid.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cod. producto:";
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPro.Image = global::Grupo2_FrondEnd.Properties.Resources.lupa__1_;
            this.btnBuscarPro.Location = new System.Drawing.Point(191, 208);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(28, 22);
            this.btnBuscarPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarPro.TabIndex = 17;
            this.btnBuscarPro.TabStop = false;
            this.btnBuscarPro.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = global::Grupo2_FrondEnd.Properties.Resources.limpio;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 483);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 58);
            this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(396, 432);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Iva:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(396, 457);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "SubTotal:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Orange;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(511, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 26);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Agregar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIva
            // 
            this.txtIva.AutoSize = true;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(476, 430);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(81, 18);
            this.txtIva.TabIndex = 26;
            this.txtIva.Text = "                  ";
            // 
            // txtTotal1
            // 
            this.txtTotal1.AutoSize = true;
            this.txtTotal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal1.Location = new System.Drawing.Point(476, 455);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(85, 18);
            this.txtTotal1.TabIndex = 27;
            this.txtTotal1.Text = "                   ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(422, 209);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(73, 22);
            this.txtCantidad.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(372, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cant:";
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.AllowUserToDeleteRows = false;
            this.dgvproductos.AllowUserToOrderColumns = true;
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvproductos.Enabled = false;
            this.dgvproductos.EnableHeadersVisualStyles = false;
            this.dgvproductos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvproductos.Location = new System.Drawing.Point(17, 275);
            this.dgvproductos.Name = "dgvproductos";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvproductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductos.Size = new System.Drawing.Size(578, 149);
            this.dgvproductos.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(296, 208);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(73, 22);
            this.txtPrecio.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(243, 210);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Precio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(14, 238);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Nombre:";
            // 
            // txtDess
            // 
            this.txtDess.BackColor = System.Drawing.Color.White;
            this.txtDess.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDess.Location = new System.Drawing.Point(111, 238);
            this.txtDess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDess.Name = "txtDess";
            this.txtDess.Size = new System.Drawing.Size(73, 22);
            this.txtDess.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo2_FrondEnd.Properties.Resources.logoEmpresa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(191, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "FACTURA ELECTRONICA";
            // 
            // btnLimpearR
            // 
            this.btnLimpearR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpearR.Image = global::Grupo2_FrondEnd.Properties.Resources.Limpiarxd;
            this.btnLimpearR.Location = new System.Drawing.Point(553, 239);
            this.btnLimpearR.Name = "btnLimpearR";
            this.btnLimpearR.Size = new System.Drawing.Size(34, 30);
            this.btnLimpearR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimpearR.TabIndex = 35;
            this.btnLimpearR.TabStop = false;
            this.btnLimpearR.Click += new System.EventHandler(this.txtLimpiarRR_Click);
            // 
            // lbUbi
            // 
            this.lbUbi.AutoSize = true;
            this.lbUbi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbi.ForeColor = System.Drawing.Color.Black;
            this.lbUbi.Location = new System.Drawing.Point(207, 27);
            this.lbUbi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUbi.Name = "lbUbi";
            this.lbUbi.Size = new System.Drawing.Size(183, 16);
            this.lbUbi.TabIndex = 36;
            this.lbUbi.Text = " El Progreso Guastatoya";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(238, 44);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "+502 1234 5678";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(194, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 41);
            this.button2.TabIndex = 39;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTTotal
            // 
            this.txtTTotal.AutoSize = true;
            this.txtTTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTTotal.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTotal.Location = new System.Drawing.Point(476, 483);
            this.txtTTotal.Name = "txtTTotal";
            this.txtTTotal.Size = new System.Drawing.Size(85, 18);
            this.txtTTotal.TabIndex = 41;
            this.txtTTotal.Text = "                   ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(396, 483);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Total:";
            // 
            // FormFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 552);
            this.Controls.Add(this.txtTTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbUbi);
            this.Controls.Add(this.btnLimpearR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDess);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscarPro);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbNumFactura);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacturas";
            this.Text = "FormFacturas";
            this.Load += new System.EventHandler(this.FormFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpearR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btmNuevoCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNumFactura;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnBuscarPro;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label txtIva;
        private System.Windows.Forms.Label txtTotal1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnLimpearR;
        private System.Windows.Forms.Label lbUbi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtTTotal;
        private System.Windows.Forms.Label label16;
    }
}