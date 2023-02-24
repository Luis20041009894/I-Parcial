namespace IParcial
{
    partial class Ejercicio9
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.ModeloTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KilometrosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CochesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CochesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Location = new System.Drawing.Point(121, 32);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(100, 22);
            this.MarcaTextBox.TabIndex = 2;
            // 
            // ModeloTextBox
            // 
            this.ModeloTextBox.Location = new System.Drawing.Point(121, 60);
            this.ModeloTextBox.Name = "ModeloTextBox";
            this.ModeloTextBox.Size = new System.Drawing.Size(100, 22);
            this.ModeloTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(121, 88);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // KilometrosTextBox
            // 
            this.KilometrosTextBox.Location = new System.Drawing.Point(121, 116);
            this.KilometrosTextBox.Name = "KilometrosTextBox";
            this.KilometrosTextBox.Size = new System.Drawing.Size(100, 22);
            this.KilometrosTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometros:";
            // 
            // CochesDataGridView
            // 
            this.CochesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CochesDataGridView.Location = new System.Drawing.Point(2, 219);
            this.CochesDataGridView.Name = "CochesDataGridView";
            this.CochesDataGridView.RowHeadersWidth = 51;
            this.CochesDataGridView.RowTemplate.Height = 24;
            this.CochesDataGridView.Size = new System.Drawing.Size(678, 161);
            this.CochesDataGridView.TabIndex = 9;
            // 
            // Ejercicio9
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 383);
            this.Controls.Add(this.CochesDataGridView);
            this.Controls.Add(this.KilometrosTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModeloTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio9";
            this.Text = "Ejercicio9";
            this.Load += new System.EventHandler(this.Ejercicio9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CochesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.TextBox ModeloTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KilometrosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CochesDataGridView;
    }
}