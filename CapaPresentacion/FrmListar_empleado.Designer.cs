namespace CapaPresentacion
{
    partial class FrmListar_empleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dlistar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(55, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 96);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busqueda por nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(25, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(376, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(480, 43);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(89, 34);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(579, 43);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(89, 34);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // dlistar
            // 
            this.dlistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistar.Location = new System.Drawing.Point(55, 198);
            this.dlistar.Name = "dlistar";
            this.dlistar.RowHeadersWidth = 51;
            this.dlistar.RowTemplate.Height = 24;
            this.dlistar.Size = new System.Drawing.Size(695, 240);
            this.dlistar.TabIndex = 2;
            // 
            // FrmListar_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dlistar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmListar_empleado";
            this.Text = "FrmListar_empleado";
            this.Load += new System.EventHandler(this.FrmListar_empleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dlistar;
    }
}