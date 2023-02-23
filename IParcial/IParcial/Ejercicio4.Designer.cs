namespace IParcial
{
    partial class Ejercicio4
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
            this.FechaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SemanaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CitaTextBox = new System.Windows.Forms.TextBox();
            this.NuevaFechaTextBox = new System.Windows.Forms.TextBox();
            this.DiasRestaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día:";
            // 
            // FechaDateTimePicker1
            // 
            this.FechaDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker1.Location = new System.Drawing.Point(209, 22);
            this.FechaDateTimePicker1.Name = "FechaDateTimePicker1";
            this.FechaDateTimePicker1.Size = new System.Drawing.Size(135, 27);
            this.FechaDateTimePicker1.TabIndex = 1;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(376, 22);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(121, 63);
            this.EjecutarButton.TabIndex = 2;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Location = new System.Drawing.Point(209, 85);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.Size = new System.Drawing.Size(141, 22);
            this.DiaTextBox.TabIndex = 3;
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(209, 113);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.Size = new System.Drawing.Size(141, 22);
            this.MesTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes:";
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Location = new System.Drawing.Point(209, 144);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.Size = new System.Drawing.Size(141, 22);
            this.AnioTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año:";
            // 
            // SemanaTextBox
            // 
            this.SemanaTextBox.Location = new System.Drawing.Point(209, 179);
            this.SemanaTextBox.Name = "SemanaTextBox";
            this.SemanaTextBox.Size = new System.Drawing.Size(141, 22);
            this.SemanaTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semana:";
            // 
            // DiasTextBox
            // 
            this.DiasTextBox.Location = new System.Drawing.Point(209, 221);
            this.DiasTextBox.Name = "DiasTextBox";
            this.DiasTextBox.Size = new System.Drawing.Size(141, 22);
            this.DiasTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cita:";
            // 
            // CitaTextBox
            // 
            this.CitaTextBox.Location = new System.Drawing.Point(376, 221);
            this.CitaTextBox.Name = "CitaTextBox";
            this.CitaTextBox.ReadOnly = true;
            this.CitaTextBox.Size = new System.Drawing.Size(141, 22);
            this.CitaTextBox.TabIndex = 12;
            // 
            // NuevaFechaTextBox
            // 
            this.NuevaFechaTextBox.Location = new System.Drawing.Point(376, 270);
            this.NuevaFechaTextBox.Name = "NuevaFechaTextBox";
            this.NuevaFechaTextBox.ReadOnly = true;
            this.NuevaFechaTextBox.Size = new System.Drawing.Size(275, 22);
            this.NuevaFechaTextBox.TabIndex = 15;
            // 
            // DiasRestaTextBox
            // 
            this.DiasRestaTextBox.Location = new System.Drawing.Point(209, 270);
            this.DiasRestaTextBox.Name = "DiasRestaTextBox";
            this.DiasRestaTextBox.Size = new System.Drawing.Size(141, 22);
            this.DiasRestaTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Restar:";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 542);
            this.Controls.Add(this.NuevaFechaTextBox);
            this.Controls.Add(this.DiasRestaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CitaTextBox);
            this.Controls.Add(this.DiasTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SemanaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.FechaDateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker1;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.TextBox DiaTextBox;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemanaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiasTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CitaTextBox;
        private System.Windows.Forms.TextBox NuevaFechaTextBox;
        private System.Windows.Forms.TextBox DiasRestaTextBox;
        private System.Windows.Forms.Label label6;
    }
}