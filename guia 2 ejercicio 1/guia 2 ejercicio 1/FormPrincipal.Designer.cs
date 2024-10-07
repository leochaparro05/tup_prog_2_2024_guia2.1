namespace guia_2_ejercicio_1
{
    partial class FormPrincipal
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
            this.LBregistrar = new System.Windows.Forms.ListBox();
            this.LBverRegisro = new System.Windows.Forms.ListBox();
            this.BTNregistrar = new System.Windows.Forms.Button();
            this.BTNverRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBregistrar
            // 
            this.LBregistrar.FormattingEnabled = true;
            this.LBregistrar.Location = new System.Drawing.Point(54, 12);
            this.LBregistrar.Name = "LBregistrar";
            this.LBregistrar.Size = new System.Drawing.Size(415, 199);
            this.LBregistrar.TabIndex = 0;
            // 
            // LBverRegisro
            // 
            this.LBverRegisro.FormattingEnabled = true;
            this.LBverRegisro.Location = new System.Drawing.Point(54, 235);
            this.LBverRegisro.Name = "LBverRegisro";
            this.LBverRegisro.Size = new System.Drawing.Size(415, 199);
            this.LBverRegisro.TabIndex = 1;
            // 
            // BTNregistrar
            // 
            this.BTNregistrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNregistrar.Location = new System.Drawing.Point(566, 88);
            this.BTNregistrar.Name = "BTNregistrar";
            this.BTNregistrar.Size = new System.Drawing.Size(158, 88);
            this.BTNregistrar.TabIndex = 2;
            this.BTNregistrar.Text = "REGISTRAR";
            this.BTNregistrar.UseVisualStyleBackColor = true;
            this.BTNregistrar.Click += new System.EventHandler(this.BTNregistrar_Click);
            // 
            // BTNverRegistro
            // 
            this.BTNverRegistro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNverRegistro.Location = new System.Drawing.Point(566, 273);
            this.BTNverRegistro.Name = "BTNverRegistro";
            this.BTNverRegistro.Size = new System.Drawing.Size(158, 91);
            this.BTNverRegistro.TabIndex = 3;
            this.BTNverRegistro.Text = "VER REGISTRO";
            this.BTNverRegistro.UseVisualStyleBackColor = true;
            this.BTNverRegistro.Click += new System.EventHandler(this.BTNverRegistro_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNverRegistro);
            this.Controls.Add(this.BTNregistrar);
            this.Controls.Add(this.LBverRegisro);
            this.Controls.Add(this.LBregistrar);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBregistrar;
        private System.Windows.Forms.ListBox LBverRegisro;
        private System.Windows.Forms.Button BTNregistrar;
        private System.Windows.Forms.Button BTNverRegistro;
    }
}