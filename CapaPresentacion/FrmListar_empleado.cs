using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmListar_empleado : Form
    {
        public FrmListar_empleado()
        {
            InitializeComponent();
        }

        private void FrmListar_empleado_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Mostrar();
        }

        private void Mostrar()
        {
            this.dlistar.DataSource = CNEmpleado.Listar();
        }

        private void BuscarNombre()
        {
            this.dlistar.DataSource = CNEmpleado.BuscarNombre(txtnombre.Text);
        }

        private void BuscarClave()
        {
            this.dlistar.DataSource = CNEmpleado.BuscarClave(((int)nudclave.Value)); // se uso un numericUpDown por conflicto de tipo de datos con txtnombre
        }                                                                            // despues se convirtio el valor decimal de nudclave a int para que sea compatible   
                                                                                     // con el metodo buscarclave de CNEmpleado   
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                nudclave.Enabled = false;
                BuscarNombre();
            }
            else if(rbtnclave.Checked)
            {   
                txtnombre.Enabled = false;
                BuscarClave();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda.", "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmGuardar_empleado form = new FrmGuardar_empleado();

            form.Insert = true;

            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmGuardar_empleado form = new FrmGuardar_empleado();

            form.Edit = true;

            form.txtclave_empleado.Text = this.dlistar.CurrentRow.Cells["cve_empelado"].Value.ToString(); //cell hace referencia a una celda y toma el valor idcliente
            form.txtTelefono.Text = this.dlistar.CurrentRow.Cells["telefno"].Value.ToString();
            form.txtDireccion.Text = this.dlistar.CurrentRow.Cells["direccion"].Value.ToString();
            form.txtNombre.Text = this.dlistar.CurrentRow.Cells["nombrecompleto"].Value.ToString();
            form.txtClave.Text = this.dlistar.CurrentRow.Cells["rfc"].Value.ToString();
            

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el(los) registro(s)?", "Farmacia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlistar.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string cve_empleado = dlistar.CurrentRow.Cells["cve_empleado"].Value.ToString();
                        CNEmpleado.Eliminar(Convert.ToInt32(cve_empleado));

                        MessageBox.Show("Registro elimninado", "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Mostrar();
                    }
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
