namespace IParcial
{
    partial class Ejercicio7
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FilaTextBox = new System.Windows.Forms.TextBox();
            this.ColumnaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 120);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(45, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 340);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño Matriz:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 3;
            // 
            // FilaTextBox
            // 
            this.FilaTextBox.Location = new System.Drawing.Point(505, 60);
            this.FilaTextBox.Name = "FilaTextBox";
            this.FilaTextBox.Size = new System.Drawing.Size(100, 22);
            this.FilaTextBox.TabIndex = 4;
            // 
            // ColumnaTextBox
            // 
            this.ColumnaTextBox.Location = new System.Drawing.Point(505, 102);
            this.ColumnaTextBox.Name = "ColumnaTextBox";
            this.ColumnaTextBox.Size = new System.Drawing.Size(100, 22);
            this.ColumnaTextBox.TabIndex = 5;
            // 
            // Ejercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 548);
            this.Controls.Add(this.ColumnaTextBox);
            this.Controls.Add(this.FilaTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio7";
            this.Text = "Ejercicio7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox FilaTextBox;
        private System.Windows.Forms.TextBox ColumnaTextBox;
    }
}