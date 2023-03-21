namespace Vista
{
    partial class FacturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarProductoButton = new System.Windows.Forms.Button();
            this.DescripcionProductoTextBox = new System.Windows.Forms.TextBox();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(772, 45);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(118, 45);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(239, 24);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuscarClienteButton);
            this.groupBox2.Controls.Add(this.NombreClienteTextBox);
            this.groupBox2.Controls.Add(this.IdentidadTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1021, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Clientes";
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.Location = new System.Drawing.Point(312, 43);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(70, 24);
            this.BuscarClienteButton.TabIndex = 5;
            this.BuscarClienteButton.Text = "...";
            this.BuscarClienteButton.UseVisualStyleBackColor = true;
            this.BuscarClienteButton.Click += new System.EventHandler(this.BuscarClienteButton_Click);
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(388, 43);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(584, 24);
            this.NombreClienteTextBox.TabIndex = 4;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(118, 43);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(188, 24);
            this.IdentidadTextBox.TabIndex = 3;
            this.IdentidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Identidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.CantidadTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ExistenciaTextBox);
            this.groupBox3.Controls.Add(this.BuscarProductoButton);
            this.groupBox3.Controls.Add(this.DescripcionProductoTextBox);
            this.groupBox3.Controls.Add(this.CodigoProductoTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1021, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(772, 100);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(200, 24);
            this.CantidadTextBox.TabIndex = 8;
            this.CantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Existencia:";
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Location = new System.Drawing.Point(118, 100);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(188, 24);
            this.ExistenciaTextBox.TabIndex = 6;
            // 
            // BuscarProductoButton
            // 
            this.BuscarProductoButton.Location = new System.Drawing.Point(312, 49);
            this.BuscarProductoButton.Name = "BuscarProductoButton";
            this.BuscarProductoButton.Size = new System.Drawing.Size(70, 27);
            this.BuscarProductoButton.TabIndex = 5;
            this.BuscarProductoButton.Text = "...";
            this.BuscarProductoButton.UseVisualStyleBackColor = true;
            this.BuscarProductoButton.Click += new System.EventHandler(this.BuscarProductoButton_Click);
            // 
            // DescripcionProductoTextBox
            // 
            this.DescripcionProductoTextBox.Location = new System.Drawing.Point(388, 52);
            this.DescripcionProductoTextBox.Name = "DescripcionProductoTextBox";
            this.DescripcionProductoTextBox.ReadOnly = true;
            this.DescripcionProductoTextBox.Size = new System.Drawing.Size(584, 24);
            this.DescripcionProductoTextBox.TabIndex = 4;
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(118, 52);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(188, 24);
            this.CodigoProductoTextBox.TabIndex = 3;
            this.CodigoProductoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoProductoTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codigo:";
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(12, 455);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.RowTemplate.Height = 24;
            this.DetalleDataGridView.Size = new System.Drawing.Size(1022, 227);
            this.DetalleDataGridView.TabIndex = 4;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(787, 684);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(153, 24);
            this.SubTotalTextBox.TabIndex = 9;
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Location = new System.Drawing.Point(787, 714);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(153, 24);
            this.ISVTextBox.TabIndex = 10;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(787, 744);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(153, 24);
            this.DescuentoTextBox.TabIndex = 11;
            this.DescuentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoTextBox_KeyPress);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(787, 774);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(153, 24);
            this.TotalTextBox.TabIndex = 12;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(23, 726);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(145, 60);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(174, 726);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(145, 60);
            this.CancelarButton.TabIndex = 13;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 690);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "SubTotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(703, 720);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "ISV%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 750);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Descuento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(703, 777);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total:";
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 828);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FacturaForm";
            this.Text = "FacturaForm1";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BuscarProductoButton;
        private System.Windows.Forms.TextBox DescripcionProductoTextBox;
        private System.Windows.Forms.TextBox CodigoProductoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}