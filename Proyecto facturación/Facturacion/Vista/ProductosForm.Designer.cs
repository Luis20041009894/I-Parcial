namespace Vista
{
    partial class ProductosForm
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
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EstadoActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdjuntarImagenButton = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(122, 6);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(352, 27);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Location = new System.Drawing.Point(122, 51);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(352, 27);
            this.DescripcionTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Enabled = false;
            this.ExistenciaTextBox.Location = new System.Drawing.Point(122, 96);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(198, 27);
            this.ExistenciaTextBox.TabIndex = 5;
            this.ExistenciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciaTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(122, 141);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(198, 27);
            this.PrecioTextBox.TabIndex = 7;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(761, 186);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(93, 49);
            this.EliminarButton.TabIndex = 23;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(653, 186);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 49);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(545, 186);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(93, 49);
            this.ModificarButton.TabIndex = 21;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(869, 186);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(93, 49);
            this.CancelarButton.TabIndex = 20;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(437, 186);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(93, 49);
            this.NuevoButton.TabIndex = 19;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Location = new System.Drawing.Point(1, 270);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.RowHeadersWidth = 51;
            this.ProductosDataGridView.RowTemplate.Height = 24;
            this.ProductosDataGridView.Size = new System.Drawing.Size(974, 278);
            this.ProductosDataGridView.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstadoActivoCheckBox
            // 
            this.EstadoActivoCheckBox.AutoSize = true;
            this.EstadoActivoCheckBox.Location = new System.Drawing.Point(135, 203);
            this.EstadoActivoCheckBox.Name = "EstadoActivoCheckBox";
            this.EstadoActivoCheckBox.Size = new System.Drawing.Size(18, 17);
            this.EstadoActivoCheckBox.TabIndex = 25;
            this.EstadoActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estado Activo:";
            // 
            // AdjuntarImagenButton
            // 
            this.AdjuntarImagenButton.Image = global::Vista.Properties.Resources.imagen;
            this.AdjuntarImagenButton.Location = new System.Drawing.Point(920, 123);
            this.AdjuntarImagenButton.Name = "AdjuntarImagenButton";
            this.AdjuntarImagenButton.Size = new System.Drawing.Size(49, 40);
            this.AdjuntarImagenButton.TabIndex = 9;
            this.AdjuntarImagenButton.UseVisualStyleBackColor = true;
            this.AdjuntarImagenButton.Click += new System.EventHandler(this.AdjuntarImagenButton_Click);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BackColor = System.Drawing.Color.White;
            this.ImagenPictureBox.Location = new System.Drawing.Point(708, 5);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(206, 159);
            this.ImagenPictureBox.TabIndex = 8;
            this.ImagenPictureBox.TabStop = false;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(973, 546);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EstadoActivoCheckBox);
            this.Controls.Add(this.ProductosDataGridView);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AdjuntarImagenButton);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductosForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.Button AdjuntarImagenButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox EstadoActivoCheckBox;
    }
}