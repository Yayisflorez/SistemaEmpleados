using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleados
{
    public partial class SitemaEmpleados : Form
    {
        Empleado empleado;

        private const string PlaceholderNombre = "Ingrese el nombre";
        private const string PlaceholderApellido = "Ingrese el apellido";
        private const string PlaceholderGenero = "f o m";
        private const string PlaceholderFechaNacimiento = "dd/mm/aa";
        private const string PlaceholderFechaIngreso = "dd/mm/aa";
        private const string PlaceholderSalario = "Solo numeros";
        private const string PlaceholderEdad = "Su edad es...";
        private const string PlaceholderAntiguedad = "Su antigüedad es...";
        public SitemaEmpleados()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setPlaceholder(txtNombre, PlaceholderNombre);
            setPlaceholder(txtApellido, PlaceholderApellido);
            setPlaceholder(txtGenero, PlaceholderGenero);
            setPlaceholder(txtFechaNacimiento, PlaceholderFechaNacimiento);
            setPlaceholder(txtFechaIngreso, PlaceholderFechaIngreso);
            setPlaceholder(txtSalario, PlaceholderSalario);
            setPlaceholder(txtCalcularEdad, PlaceholderEdad);
            setPlaceholder(txtAntiguedad, PlaceholderAntiguedad);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (empleado == null)
            {
                lblMensajeEmple.Text = "⚠ Primero debe guardar un empleado antes de modificarlo";
                lblMensajeEmple.ForeColor = Color.Red;
                return;
            }

            int nuevoSalario;
            if (!int.TryParse(txtSalario.Text, out nuevoSalario))
            {
                lblMensajeEmple.Text = "⚠ Ingrese un salario válido (solo números)";
                lblMensajeEmple.ForeColor = Color.Red;
                return;
            }

            empleado.ModificarSalario(nuevoSalario);
            lblMensajeEmple.Text = $"✅ Salario modificado correctamente. Nuevo salario: {empleado.getSalario()}";
            lblMensajeEmple.ForeColor = Color.Green;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string genero = txtGenero.Text.ToLower(); // Convertir a minúsculas
            string fechaNac = txtFechaNacimiento.Text;
            string fechaIng = txtFechaIngreso.Text;
            string salarioTxt = txtSalario.Text;

            string[] campos = { nombre, apellido, genero, fechaNac, fechaIng, salarioTxt };
            string[] placeholders = { PlaceholderNombre, PlaceholderApellido, PlaceholderGenero.ToLower(),
                              PlaceholderFechaNacimiento, PlaceholderFechaIngreso, PlaceholderSalario };
            // Validar que todos los campos estén llenos y no contengan solo el placeholder
            for (int i = 0; i < campos.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(campos[i]) || campos[i] == placeholders[i])
                {
                    lblMensajeEmple.Text = "⚠ Todos los campos son obligatorios y deben ser válidos";
                    lblMensajeEmple.ForeColor = Color.Red;
                    return;
                }
            }
            DateTime fechaNacimiento;
            DateTime fechaIngreso;
            int salario;
        
            // Validar género con imagen en PictureBox
            if (genero == "f")
            {
                pictureBox1.Image = Properties.Resources.mujer; // Imagen de mujer
                this.BackColor = Color.LightPink;
            }
            else if (genero == "m")
            {
                pictureBox1.Image = Properties.Resources.hombre; // Imagen de hombre
                this.BackColor = Color.LightBlue;
            }
            else
            {
                lblMensajeEmple.Text = "⚠ El género debe ser 'f' o 'm'";
                lblMensajeEmple.ForeColor = Color.Red;
                return;
            }

            // 🔹 Validar fechas y salario
            try
            {
                fechaNacimiento = DateTime.Parse(fechaNac);
                fechaIngreso = DateTime.Parse(fechaIng);
                salario = int.Parse(salarioTxt);

                // Crear empleado
                empleado = new Empleado(nombre, apellido, genero, fechaNacimiento, fechaIngreso, salario);

                lblMensajeEmple.Text = "✅ Información guardada correctamente";
                lblMensajeEmple.ForeColor = Color.Green;
            }
            catch
            {
                lblMensajeEmple.Text = "⚠ Verifique que las fechas";
                lblMensajeEmple.ForeColor = Color.Red;
            }
        }


        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);

            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad= edad-1;// aún no ha cumplido años este año
            }
            txtCalcularEdad.Text =edad.ToString() + " años ";
            txtCalcularEdad.ForeColor = Color.Black;
        }
        private void setPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void btnCalcularAntiguedad_Click(object sender, EventArgs e)
        {
            DateTime fechaIngreso = DateTime.Parse(txtFechaIngreso.Text);
            int antiguedad = DateTime.Today.Year - fechaIngreso.Year;
            if (DateTime.Today < fechaIngreso.AddYears(antiguedad))
            {
                antiguedad=antiguedad-1; //Si aún no ha cumplido aniversario este año, restar 1
            }
            txtAntiguedad.Text = antiguedad.ToString() + " años";
            txtAntiguedad.ForeColor = Color.Black;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            setPlaceholder(txtNombre, "Ingrese el nombre");
            setPlaceholder(txtApellido, "Ingrese el apellido");
            setPlaceholder(txtGenero, "f o m");
            setPlaceholder(txtFechaNacimiento, "dd/mm/aa");
            setPlaceholder(txtFechaIngreso, "dd/mm/aa");
            setPlaceholder(txtSalario, "Solo numeros");
            setPlaceholder(txtCalcularEdad, "Su edad es...");
            setPlaceholder(txtAntiguedad, "Su antigüedad es...");
            lblMensajeEmple.Text = "";
            lblMensaje.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



