
namespace pryPachecoEtapa4
{
    partial class frmEtapa4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnBarco = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.Location = new System.Drawing.Point(1, 334);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(491, 95);
            this.lstVehiculos.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(498, 334);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(65, 95);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(1, 12);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(101, 45);
            this.btnAuto.TabIndex = 7;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnBarco
            // 
            this.btnBarco.Location = new System.Drawing.Point(1, 127);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(101, 45);
            this.btnBarco.TabIndex = 8;
            this.btnBarco.Text = "Barco";
            this.btnBarco.UseVisualStyleBackColor = true;
            this.btnBarco.Click += new System.EventHandler(this.btnBarco_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(1, 244);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(101, 45);
            this.btnAvion.TabIndex = 9;
            this.btnAvion.Text = "Avion";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // frmEtapa4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 441);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEtapa4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEtapa4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.Button btnAvion;
    }
}

