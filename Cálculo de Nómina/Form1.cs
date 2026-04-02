using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace Cálculo_de_Nómina
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;

        public Form1()
        {
            InitializeComponent();
        }

        // ── Botón AGREGAR ──────────────────────────────────────────
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Ingresa el nombre del empleado.", "Campo vacío",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string id = $"EMP-{contadorId:D3}";
                Empleado emp;

                if (cmbTipo.SelectedIndex == 0) // Asalariado
                {
                    if (!double.TryParse(txtDato1.Text, out double sueldo) || sueldo <= 0)
                    {
                        MessageBox.Show("Ingresa un sueldo mensual válido.", "Dato inválido",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    emp = new EmpleadoAsalariado(id, nombre, sueldo);
                }
                else // Por Horas
                {
                    if (!int.TryParse(txtDato1.Text, out int horas) || horas <= 0)
                    {
                        MessageBox.Show("Ingresa horas trabajadas válidas.", "Dato inválido",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!double.TryParse(txtDato2.Text, out double pago) || pago <= 0)
                    {
                        MessageBox.Show("Ingresa el pago por hora válido.", "Dato inválido",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    emp = new EmpleadoPorHoras(id, nombre, horas, pago);
                }

                // Agregar al ListBox
                lstReporte.Items.Add(emp.ObtenerInforme());
                contadorId++;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Botón LIMPIAR ──────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
            contadorId = 1;
            LimpiarCampos();
        }

        // ── Cambio de tipo de empleado ─────────────────────────────
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0) // Asalariado
            {
                lblDato1.Text = "Sueldo Mensual ($):";
                lblDato2.Visible = false;
                txtDato2.Visible = false;
                txtDato1.Clear();
            }
            else // Por Horas
            {
                lblDato1.Text = "Horas Trabajadas:";
                lblDato2.Visible = true;
                txtDato2.Visible = true;
                txtDato1.Clear();
                txtDato2.Clear();
            }
        }

        // ── Helpers ────────────────────────────────────────────────
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDato1.Clear();
            txtDato2.Clear();
            txtNombre.Focus();
        }
    }
}