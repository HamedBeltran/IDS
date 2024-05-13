namespace Actividad_2
{
    partial class Operaciones_Basicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operaciones_Basicas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.num5 = new System.Windows.Forms.TextBox();
            this.num6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.Osumar = new System.Windows.Forms.Button();
            this.Oresta = new System.Windows.Forms.Button();
            this.Omultiplicar = new System.Windows.Forms.Button();
            this.Odivision = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero 2";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(98, 132);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(49, 20);
            this.num1.TabIndex = 7;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(98, 166);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(49, 20);
            this.num2.TabIndex = 8;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(98, 203);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(49, 20);
            this.num3.TabIndex = 9;
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(214, 132);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(49, 20);
            this.num4.TabIndex = 15;
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(214, 166);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(49, 20);
            this.num5.TabIndex = 14;
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(214, 206);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(49, 20);
            this.num6.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Numero 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Resultado";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(98, 257);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(165, 20);
            this.txtResultado.TabIndex = 17;
            // 
            // Osumar
            // 
            this.Osumar.Location = new System.Drawing.Point(15, 309);
            this.Osumar.Name = "Osumar";
            this.Osumar.Size = new System.Drawing.Size(75, 23);
            this.Osumar.TabIndex = 18;
            this.Osumar.Text = "Suma";
            this.Osumar.UseVisualStyleBackColor = true;
            this.Osumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Oresta
            // 
            this.Oresta.Location = new System.Drawing.Point(116, 309);
            this.Oresta.Name = "Oresta";
            this.Oresta.Size = new System.Drawing.Size(75, 23);
            this.Oresta.TabIndex = 19;
            this.Oresta.Text = "Resta";
            this.Oresta.UseVisualStyleBackColor = true;
            // 
            // Omultiplicar
            // 
            this.Omultiplicar.Location = new System.Drawing.Point(214, 309);
            this.Omultiplicar.Name = "Omultiplicar";
            this.Omultiplicar.Size = new System.Drawing.Size(85, 23);
            this.Omultiplicar.TabIndex = 20;
            this.Omultiplicar.Text = "Multiplicacion";
            this.Omultiplicar.UseVisualStyleBackColor = true;
            this.Omultiplicar.Click += new System.EventHandler(this.Omultiplicar_Click);
            // 
            // Odivision
            // 
            this.Odivision.Location = new System.Drawing.Point(317, 309);
            this.Odivision.Name = "Odivision";
            this.Odivision.Size = new System.Drawing.Size(75, 23);
            this.Odivision.TabIndex = 21;
            this.Odivision.Text = "Division";
            this.Odivision.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(272, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Regresar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(54, 366);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Operaciones_Basicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 401);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Odivision);
            this.Controls.Add(this.Omultiplicar);
            this.Controls.Add(this.Oresta);
            this.Controls.Add(this.Osumar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operaciones_Basicas";
            this.Text = "Operaciones Basicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num4;
        private System.Windows.Forms.TextBox num5;
        private System.Windows.Forms.TextBox num6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button Osumar;
        private System.Windows.Forms.Button Oresta;
        private System.Windows.Forms.Button Omultiplicar;
        private System.Windows.Forms.Button Odivision;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}