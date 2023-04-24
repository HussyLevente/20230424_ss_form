namespace _20230424_ss_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kelvin_kiir = new System.Windows.Forms.TextBox();
            this.celsius_bevitel = new System.Windows.Forms.TextBox();
            this.fahrenheit_kiir = new System.Windows.Forms.TextBox();
            this.kelvin_valto = new System.Windows.Forms.Button();
            this.fahrenheit_valto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hőmérséklet váltó program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kérem adja meg a hőmérsékletet °C fokban: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin fokban a hőmérséklet: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fahrenheit fokban a hőmérséklet: ";
            // 
            // kelvin_kiir
            // 
            this.kelvin_kiir.Location = new System.Drawing.Point(180, 70);
            this.kelvin_kiir.Name = "kelvin_kiir";
            this.kelvin_kiir.Size = new System.Drawing.Size(100, 23);
            this.kelvin_kiir.TabIndex = 4;
            // 
            // celsius_bevitel
            // 
            this.celsius_bevitel.Location = new System.Drawing.Point(301, 40);
            this.celsius_bevitel.Name = "celsius_bevitel";
            this.celsius_bevitel.Size = new System.Drawing.Size(100, 23);
            this.celsius_bevitel.TabIndex = 5;
            // 
            // fahrenheit_kiir
            // 
            this.fahrenheit_kiir.Location = new System.Drawing.Point(204, 103);
            this.fahrenheit_kiir.Name = "fahrenheit_kiir";
            this.fahrenheit_kiir.Size = new System.Drawing.Size(100, 23);
            this.fahrenheit_kiir.TabIndex = 6;
            // 
            // kelvin_valto
            // 
            this.kelvin_valto.Location = new System.Drawing.Point(286, 70);
            this.kelvin_valto.Name = "kelvin_valto";
            this.kelvin_valto.Size = new System.Drawing.Size(115, 23);
            this.kelvin_valto.TabIndex = 7;
            this.kelvin_valto.Text = "Kelvin fokba váltó";
            this.kelvin_valto.UseVisualStyleBackColor = true;
            this.kelvin_valto.Click += new System.EventHandler(this.kelvin_valto_Click);
            // 
            // fahrenheit_valto
            // 
            this.fahrenheit_valto.Location = new System.Drawing.Point(310, 103);
            this.fahrenheit_valto.Name = "fahrenheit_valto";
            this.fahrenheit_valto.Size = new System.Drawing.Size(135, 23);
            this.fahrenheit_valto.TabIndex = 8;
            this.fahrenheit_valto.Text = "Fahrenheit fokba váltó";
            this.fahrenheit_valto.UseVisualStyleBackColor = true;
            this.fahrenheit_valto.Click += new System.EventHandler(this.fahrenheit_valto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 362);
            this.Controls.Add(this.fahrenheit_valto);
            this.Controls.Add(this.kelvin_valto);
            this.Controls.Add(this.fahrenheit_kiir);
            this.Controls.Add(this.celsius_bevitel);
            this.Controls.Add(this.kelvin_kiir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hőmérséklet váltó program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox kelvin_kiir;
        private TextBox celsius_bevitel;
        private TextBox fahrenheit_kiir;
        private Button kelvin_valto;
        private Button fahrenheit_valto;
    }
}