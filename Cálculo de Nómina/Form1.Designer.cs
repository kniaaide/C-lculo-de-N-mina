namespace Cálculo_de_Nómina
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstReporte;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpReporte;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstReporte = new System.Windows.Forms.ListBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.grpReporte = new System.Windows.Forms.GroupBox();

            this.grpDatos.SuspendLayout();
            this.grpReporte.SuspendLayout();
            this.SuspendLayout();

            // grpDatos
            this.grpDatos.Text = "Datos del empleado";
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Size = new System.Drawing.Size(320, 220);

            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(10, 25);
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtNombre.Location = new System.Drawing.Point(95, 25);
            this.txtNombre.Size = new System.Drawing.Size(210, 22);

            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Location = new System.Drawing.Point(10, 58);
            this.lblTipo.Size = new System.Drawing.Size(80, 20);
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Location = new System.Drawing.Point(95, 58);
            this.cmbTipo.Size = new System.Drawing.Size(210, 22);
            this.cmbTipo.Items.AddRange(new object[] { "Asalariado", "Por Horas" });
            this.cmbTipo.SelectedIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);

            this.lblDato1.Text = "Sueldo Mensual ($):";
            this.lblDato1.Location = new System.Drawing.Point(10, 91);
            this.lblDato1.Size = new System.Drawing.Size(80, 20);
            this.lblDato1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtDato1.Location = new System.Drawing.Point(95, 91);
            this.txtDato1.Size = new System.Drawing.Size(210, 22);

            this.lblDato2.Text = "Pago por Hora ($):";
            this.lblDato2.Location = new System.Drawing.Point(10, 124);
            this.lblDato2.Size = new System.Drawing.Size(80, 20);
            this.lblDato2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDato2.Visible = false;

            this.txtDato2.Location = new System.Drawing.Point(95, 124);
            this.txtDato2.Size = new System.Drawing.Size(210, 22);
            this.txtDato2.Visible = false;

            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(95, 170);
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnLimpiar.Text = "Limpiar todo";
            this.btnLimpiar.Location = new System.Drawing.Point(205, 170);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.cmbTipo);
            this.grpDatos.Controls.Add(this.lblDato1);
            this.grpDatos.Controls.Add(this.txtDato1);
            this.grpDatos.Controls.Add(this.lblDato2);
            this.grpDatos.Controls.Add(this.txtDato2);
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Controls.Add(this.btnLimpiar);

            // grpReporte
            this.grpReporte.Text = "Reporte de nómina";
            this.grpReporte.Location = new System.Drawing.Point(12, 242);
            this.grpReporte.Size = new System.Drawing.Size(320, 160);

            this.lstReporte.Location = new System.Drawing.Point(10, 22);
            this.lstReporte.Size = new System.Drawing.Size(295, 128);
            this.lstReporte.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstReporte.HorizontalScrollbar = true;

            this.grpReporte.Controls.Add(this.lstReporte);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 415);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cálculo de Nómina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpReporte.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}