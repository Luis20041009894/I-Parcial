namespace IParcial
{
    partial class Ejercicio6
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
            this.ArregloListBox = new System.Windows.Forms.ListBox();
            this.ArreglosButton = new System.Windows.Forms.Button();
            this.ArregloComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ArregloListBox
            // 
            this.ArregloListBox.FormattingEnabled = true;
            this.ArregloListBox.ItemHeight = 16;
            this.ArregloListBox.Location = new System.Drawing.Point(51, 77);
            this.ArregloListBox.Name = "ArregloListBox";
            this.ArregloListBox.Size = new System.Drawing.Size(176, 212);
            this.ArregloListBox.TabIndex = 0;
            // 
            // ArreglosButton
            // 
            this.ArreglosButton.Location = new System.Drawing.Point(289, 77);
            this.ArreglosButton.Name = "ArreglosButton";
            this.ArreglosButton.Size = new System.Drawing.Size(130, 78);
            this.ArreglosButton.TabIndex = 1;
            this.ArreglosButton.Text = "Arreglos";
            this.ArreglosButton.UseVisualStyleBackColor = true;
            this.ArreglosButton.Click += new System.EventHandler(this.ArreglosButton_Click);
            // 
            // ArregloComboBox
            // 
            this.ArregloComboBox.FormattingEnabled = true;
            this.ArregloComboBox.Location = new System.Drawing.Point(51, 313);
            this.ArregloComboBox.Name = "ArregloComboBox";
            this.ArregloComboBox.Size = new System.Drawing.Size(180, 24);
            this.ArregloComboBox.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 517);
            this.Controls.Add(this.ArregloComboBox);
            this.Controls.Add(this.ArreglosButton);
            this.Controls.Add(this.ArregloListBox);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ArregloListBox;
        private System.Windows.Forms.Button ArreglosButton;
        private System.Windows.Forms.ComboBox ArregloComboBox;
    }
}