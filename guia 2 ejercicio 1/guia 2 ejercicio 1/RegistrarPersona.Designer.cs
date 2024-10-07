namespace guia_2_ejercicio_1
{
    partial class RegistrarPersona
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
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.BTNaceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(183, 69);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 20);
            this.TBnombre.TabIndex = 2;
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(183, 119);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(100, 20);
            this.TBdni.TabIndex = 3;
            // 
            // BTNaceptar
            // 
            this.BTNaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNaceptar.Location = new System.Drawing.Point(88, 176);
            this.BTNaceptar.Name = "BTNaceptar";
            this.BTNaceptar.Size = new System.Drawing.Size(75, 23);
            this.BTNaceptar.TabIndex = 4;
            this.BTNaceptar.Text = "ACEPTAR";
            this.BTNaceptar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(88, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RegistrarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNaceptar);
            this.Controls.Add(this.TBdni);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarPersona";
            this.Text = "RegistrarPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TBnombre;
        public System.Windows.Forms.TextBox TBdni;
        public System.Windows.Forms.Button BTNaceptar;
        public System.Windows.Forms.Button button2;
    }
}