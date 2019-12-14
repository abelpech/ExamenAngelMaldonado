namespace Examen
{
    partial class Ejercicio2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtVariable1 = new System.Windows.Forms.TextBox();
            this.txtVariable2 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variable Arreglo 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variable Arreglo 2:";
            // 
            // txtVariable1
            // 
            this.txtVariable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariable1.Location = new System.Drawing.Point(355, 95);
            this.txtVariable1.Name = "txtVariable1";
            this.txtVariable1.Size = new System.Drawing.Size(369, 41);
            this.txtVariable1.TabIndex = 2;
            this.txtVariable1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVariable1_KeyPress);
            // 
            // txtVariable2
            // 
            this.txtVariable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariable2.Location = new System.Drawing.Point(355, 153);
            this.txtVariable2.Name = "txtVariable2";
            this.txtVariable2.Size = new System.Drawing.Size(369, 41);
            this.txtVariable2.TabIndex = 3;
            this.txtVariable2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVariable2_KeyPress);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedio.Location = new System.Drawing.Point(271, 271);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(236, 88);
            this.btnPromedio.TabIndex = 4;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtVariable2);
            this.Controls.Add(this.txtVariable1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVariable1;
        private System.Windows.Forms.TextBox txtVariable2;
        private System.Windows.Forms.Button btnPromedio;
    }
}