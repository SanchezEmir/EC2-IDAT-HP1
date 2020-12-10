
namespace pl_EmirSanchezRamirezEC2
{
    partial class SegundaParte
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
            this.txtNumeroEntero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbNumerosEnteros = new System.Windows.Forms.ListBox();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroEntero
            // 
            this.txtNumeroEntero.Location = new System.Drawing.Point(132, 31);
            this.txtNumeroEntero.Name = "txtNumeroEntero";
            this.txtNumeroEntero.Size = new System.Drawing.Size(130, 20);
            this.txtNumeroEntero.TabIndex = 0;
            this.txtNumeroEntero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(284, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa Numeros :";
            // 
            // lsbNumerosEnteros
            // 
            this.lsbNumerosEnteros.FormattingEnabled = true;
            this.lsbNumerosEnteros.Location = new System.Drawing.Point(132, 81);
            this.lsbNumerosEnteros.Name = "lsbNumerosEnteros";
            this.lsbNumerosEnteros.Size = new System.Drawing.Size(129, 147);
            this.lsbNumerosEnteros.TabIndex = 3;
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(284, 81);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(75, 23);
            this.btnPares.TabIndex = 4;
            this.btnPares.Text = "PARES";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(284, 121);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(75, 23);
            this.btnImpares.TabIndex = 5;
            this.btnImpares.Text = "IMPARES";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Números Enteros :";
            // 
            // SegundaParte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.lsbNumerosEnteros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumeroEntero);
            this.Name = "SegundaParte";
            this.Text = "SegundaParte";
            this.Load += new System.EventHandler(this.SegundaParte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroEntero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbNumerosEnteros;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.Label label2;
    }
}