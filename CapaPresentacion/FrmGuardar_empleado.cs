//using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmGuardar_empleado : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmGuardar_empleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGuardar_empleado_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (this.txtNombre.Text == string.Empty || this.txtTelefono.Text == string.Empty) // || this.txtClave_farmacia.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del empleado", "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
                else
                {
                    if (this.Insert == true)
                    {
                        CNEmpleado.Guardar(this.txtNombre.Text, this.txtDireccion.Text, this.txtTelefono.Text); //, Convert.ToInt32(this.txtClave_farmacia.Text));
                        MessageBox.Show("Empleado registrado correctamente", "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        txtClave_farmacia.Enabled = false;
                        CNEmpleado.Editar(Convert.ToInt32(this.txtClave_empleado.Text), this.txtNombre.Text, this.txtDireccion.Text, this.txtTelefono.Text); //, Convert.ToInt32(this.txtClave_farmacia));
                        MessageBox.Show("Empleado editado correctamente", "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListar_empleado form = new FrmListar_empleado();
                    form.Show();
                    this.Hide();

                }
            }
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            */
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "ERROR SQL:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERROR GENERAL:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmListar_empleado form = new FrmListar_empleado();
            form.Show();
            this.Hide();
        }
    }
}
