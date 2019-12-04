namespace ValidadorRUTRUN
{
    partial class Form1
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
            this.txtRUN = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRUN
            // 
            this.txtRUN.Location = new System.Drawing.Point(12, 29);
            this.txtRUN.Name = "txtRUN";
            this.txtRUN.Size = new System.Drawing.Size(284, 20);
            this.txtRUN.TabIndex = 0;
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(12, 55);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(284, 23);
            this.btnValid.TabIndex = 1;
            this.btnValid.Text = "Validar";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el RUN o RUT con o sin puntos y digito verificador.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 86);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.txtRUN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Validador RUN/RUT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRUN;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Label label1;
    }
}

