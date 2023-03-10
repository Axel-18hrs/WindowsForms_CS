using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_CS.Clases;
using static System.Net.WebRequestMethods;

namespace WindowsForms_CS
{
    public partial class Form1 : Form
    {
        private int nn;
        private Contacto[] personas = new Contacto[1000];
        private StreamReader leerArchivo;
        private StreamWriter escribirArchivo;
        private SaveFileDialog ruta;

        public Form1()
        {
            InitializeComponent();
            nn = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Quieres empezar con un archivo anterior?", "???", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                return;
            }
            ruta = new SaveFileDialog()
            {
                Filter = "txt files (*.txt) | *.txt | All files (*.*) | *.*",
                Title = "Guardando tus datos"
            };
            if (ruta.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Error al escoger la ruta de archivo. ", "Error", MessageBoxButtons.OK);
                return;
            }
            using (leerArchivo = new StreamReader(ruta.FileName))
            {
                while (!leerArchivo.EndOfStream)
                {
                    string line = leerArchivo.ReadLine();
                    string[] values = line.Split('\t');
                    dgvDatosFormulario.Rows.Add(values);
                }
                leerArchivo.Close();
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            ruta = new SaveFileDialog();
            ruta.Filter = "txt files (*.txt) | *.txt | All files (*.*) | *.*";
            ruta.Title = "Guardando tus datos";
            if (ruta.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Error al escoger la ruta de archivo. ", "Error", MessageBoxButtons.OK);
                return;
            }

            using (escribirArchivo = new StreamWriter(ruta.FileName))
            {
                foreach (DataGridViewRow fila in dgvDatosFormulario.Rows)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        escribirArchivo.Write(celda.Value.ToString() + "\t");
                    }
                    escribirArchivo.WriteLine();
                }
                escribirArchivo.Close();
            }
        }

        private void btnEnviarDatos_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text == null)
            {
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un nombre.");
            }
            else
            {
                ErrorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtApPaterno.Text) || txtApPaterno.Text == null)
            {
                ErrorProvider2.SetError(txtApPaterno, "Debe ingresar un apellido P.");
            }
            else
            {
                ErrorProvider2.Clear();
            }
            if (string.IsNullOrEmpty(txtApMaterno.Text) || txtApMaterno.Text == null)
            {
                ErrorProvider3.SetError(txtApMaterno, "Debe ingresar un apellido M.");
            }
            else
            {
                ErrorProvider3.Clear();
            }
            if (string.IsNullOrEmpty(txtNumeroTelefono.Text) || txtNumeroTelefono.Text == null)
            {
                ErrorProvider4.SetError(txtNumeroTelefono, "Debe ingresar un numero.");
            }
            else
            {
                ErrorProvider4.Clear();
            }

            Regex regex = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
            if (string.IsNullOrEmpty(txtCorreo.Text) || txtCorreo.Text == null || !regex.IsMatch(txtCorreo.Text))
            {
                ErrorProvider5.SetError(txtCorreo, "Debe ingresar un numero.");
            }
            else
            {
                ErrorProvider5.Clear();
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApPaterno.Text) || string.IsNullOrWhiteSpace(txtApMaterno.Text) || string.IsNullOrWhiteSpace(txtNumeroTelefono.Text) || !regex.IsMatch(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Le doy memoria a la persona (contacto) desde el primer índice.
            personas[nn] = new Contacto
            {
                Nombre = txtNombre.Text,
                APPaterno = txtApPaterno.Text,
                APMaterno = txtApMaterno.Text,
                Telefono = txtNumeroTelefono.Text,
                Correo = txtCorreo.Text,
                FechaNacimiento = dtpFechaNacimiento.Value
            };
            Edad1(personas[nn].Edad);
            Edad1();
            // Parte del programa que se encarga de imprimir los datos en el DataGridView.
            dgvDatosFormulario.Rows.Add(nn + 1, personas[nn].Nombre, personas[nn].APPaterno, personas[nn].APMaterno, personas[nn].Telefono, personas[nn].Correo, personas[nn].FechaNacimiento, personas[nn].Edad);
            nn += 1;

            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtNumeroTelefono.Clear();
            txtCorreo.Clear();
            dtpFechaNacimiento.ResetText();
        }
        // Este botón elimina la celda seleccionada.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si la cantidad de filas dentro del DataGridView es mayor que cero, se puede seguir eliminando.
            if (dgvDatosFormulario.Rows.Count > 0)
            {
                // Eliminar cada fila seleccionada.
                foreach (DataGridViewRow fila in dgvDatosFormulario.SelectedRows)
                    dgvDatosFormulario.Rows.Remove(fila);
            }
            else
               MessageBox.Show("No hay más elementos que eliminar en este apartado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se ha presionado la tecla "Enter".
            if (e.KeyCode == Keys.Enter)
            {
                // Verificar si el control activo es un TextBox.
                if (this.ActiveControl is TextBox)
                    // Establecer el enfoque en el siguiente TextBox.
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        public void Edad1(int x)
        {
            if (x >= 18)
                MessageBox.Show("Eres mayor de edad", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (x < 18)
                MessageBox.Show("Eres menor de edad", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void Edad1()
        {
            MessageBox.Show("El ser mayor de edad deja menos sospechas en cuanto los datos que proporciones");
        }

     
    }
}
