
namespace Proyecto_Estructur_de_Archvos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviarAsis = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.RichTextBox();
            this.btnLimpiarAsis = new System.Windows.Forms.Button();
            this.txtReportes = new System.Windows.Forms.RichTextBox();
            this.btnMostrarReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(157, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asistencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(211, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(157, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "ESTACIONAMIENTO";
            // 
            // btnEnviarAsis
            // 
            this.btnEnviarAsis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarAsis.Location = new System.Drawing.Point(12, 261);
            this.btnEnviarAsis.Name = "btnEnviarAsis";
            this.btnEnviarAsis.Size = new System.Drawing.Size(118, 62);
            this.btnEnviarAsis.TabIndex = 6;
            this.btnEnviarAsis.Text = "Guardar";
            this.btnEnviarAsis.UseVisualStyleBackColor = true;
            this.btnEnviarAsis.Click += new System.EventHandler(this.btnEnviarAsis_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(12, 144);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(315, 111);
            this.txtEnviar.TabIndex = 33;
            this.txtEnviar.Text = "";
            // 
            // btnLimpiarAsis
            // 
            this.btnLimpiarAsis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarAsis.Location = new System.Drawing.Point(145, 261);
            this.btnLimpiarAsis.Name = "btnLimpiarAsis";
            this.btnLimpiarAsis.Size = new System.Drawing.Size(118, 62);
            this.btnLimpiarAsis.TabIndex = 46;
            this.btnLimpiarAsis.Text = "Limpiar ";
            this.btnLimpiarAsis.UseVisualStyleBackColor = true;
            this.btnLimpiarAsis.Click += new System.EventHandler(this.btnLimpiarAsis_Click);
            // 
            // txtReportes
            // 
            this.txtReportes.Location = new System.Drawing.Point(518, 119);
            this.txtReportes.Name = "txtReportes";
            this.txtReportes.Size = new System.Drawing.Size(242, 306);
            this.txtReportes.TabIndex = 47;
            this.txtReportes.Text = "";
            // 
            // btnMostrarReportes
            // 
            this.btnMostrarReportes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarReportes.Location = new System.Drawing.Point(405, 119);
            this.btnMostrarReportes.Name = "btnMostrarReportes";
            this.btnMostrarReportes.Size = new System.Drawing.Size(107, 91);
            this.btnMostrarReportes.TabIndex = 48;
            this.btnMostrarReportes.Text = "Mostrar Reportes";
            this.btnMostrarReportes.UseVisualStyleBackColor = true;
            this.btnMostrarReportes.Click += new System.EventHandler(this.btnMostrarReportes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarReportes);
            this.Controls.Add(this.txtReportes);
            this.Controls.Add(this.btnLimpiarAsis);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.btnEnviarAsis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Assistencia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviarAsis;
        private System.Windows.Forms.RichTextBox txtEnviar;
        private System.Windows.Forms.Button btnLimpiarAsis;
        private System.Windows.Forms.RichTextBox txtReportes;
        private System.Windows.Forms.Button btnMostrarReportes;
    }
}