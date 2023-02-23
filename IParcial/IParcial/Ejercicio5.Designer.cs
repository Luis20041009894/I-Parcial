using System;

namespace IParcial
{
    partial class Ejercicio5
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
            this.Hornearbutton1 = new System.Windows.Forms.Button();
            this.HornearAzincronabutton2 = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hornearbutton1
            // 
            this.Hornearbutton1.Location = new System.Drawing.Point(52, 27);
            this.Hornearbutton1.Name = "Hornearbutton1";
            this.Hornearbutton1.Size = new System.Drawing.Size(201, 100);
            this.Hornearbutton1.TabIndex = 1;
            this.Hornearbutton1.Text = "Hornear Pizza";
            this.Hornearbutton1.UseVisualStyleBackColor = true;
            this.Hornearbutton1.Click += new System.EventHandler(this.Hornearbutton1_Click);
            // 
            // HornearAzincronabutton2
            // 
            this.HornearAzincronabutton2.Location = new System.Drawing.Point(370, 27);
            this.HornearAzincronabutton2.Name = "HornearAzincronabutton2";
            this.HornearAzincronabutton2.Size = new System.Drawing.Size(201, 100);
            this.HornearAzincronabutton2.TabIndex = 2;
            this.HornearAzincronabutton2.Text = "Hornear Pizza Azincrona";
            this.HornearAzincronabutton2.UseVisualStyleBackColor = true;
            this.HornearAzincronabutton2.Click += new System.EventHandler(this.HornearAzincronabutton2_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(342, 208);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(214, 77);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2: ";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(180, 208);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(116, 30);
            this.Numero1TextBox.TabIndex = 5;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(180, 253);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(116, 30);
            this.Numero2TextBox.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 423);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.HornearAzincronabutton2);
            this.Controls.Add(this.Hornearbutton1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Hornearbutton1;
        private System.Windows.Forms.Button HornearAzincronabutton2;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
    }
}