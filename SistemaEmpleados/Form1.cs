using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private const string PlaceholderGenero = "'f' o 'm'";
        private const string PlaceholderFechaNacimiento = "dd/mm/aa";
        private const string PlaceholderFechaIngreso = "dd/mm/aa";
        private const string PlaceholderSalario = "Solo numeros";
        private const string PlaceholderEdad = "Su edad es...";
        private const string PlaceholderAntiguedad = "Su antigüedad es...";
        private const string PlaceholderPrestaciones="Sus prestaciones son...";
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
            setPlaceholder(txtPrestaciones, PlaceholderPrestaciones);

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

            double nuevoSalario;
            if (!double.TryParse(txtSalario.Text, out nuevoSalario))
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
            Fecha fecha = new Fecha();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string generoText = txtGenero.Text; 
            string fechaNac = txtFechaNacimiento.Text;
            string fechaIng = txtFechaIngreso.Text;
            string salario = txtSalario.Text;
            char genero = generoText[0];

            string[] campos = {nombre, apellido, genero.ToString(), fechaNac, fechaIng, salario};
            string[] placeholders = { PlaceholderNombre, PlaceholderApellido, PlaceholderFechaNacimiento, PlaceholderFechaIngreso, PlaceholderSalario, PlaceholderGenero };

            if (nombre == PlaceholderNombre && apellido == PlaceholderApellido && generoText == PlaceholderGenero && fechaNac == PlaceholderFechaNacimiento && fechaIng == PlaceholderFechaIngreso && salario == PlaceholderSalario)
            { 
                for (int i = 0; i < campos.Length; i++)
                {

                    if (string.IsNullOrWhiteSpace(campos[i]) || campos[i] == placeholders[i])
                    {
                        lblMensajeEmple.Text = "⚠ Todos los campos son obligatorios y deben ser válidos";
                        lblMensajeEmple.ForeColor = Color.Red;
                        return;
                    }
                }
            }
            if (generoText.Length > 1)
            {
                lblMensajeEmple.Text = "⚠ El género debe ser 'f' o 'm'";
                lblMensajeEmple.ForeColor = Color.Red;
                return;
            } else {
                
                if (genero == 'f' || genero == 'F')
                {
                    pictureBox1.Image = Properties.Resources.mujer; // Imagen de mujer
                    this.BackColor = Color.LightPink;
                }
                else if (genero == 'm' || genero == 'M')
                {
                    pictureBox1.Image = Properties.Resources.hombre; // Imagen de hombre
                    this.BackColor = Color.LightBlue;
                }
                else
                {
                    if (generoText == PlaceholderGenero)
                    {
                        lblMensajeEmple.Text = "⚠ Debe digitar una genero";
                        lblMensajeEmple.ForeColor = Color.Red;
                        return;

                    }
                    else
                    {
                        lblMensajeEmple.Text = "⚠ El género debe ser 'f' o 'm'";
                        lblMensajeEmple.ForeColor = Color.Red;
                        return;
                    }
                }
            }

            try
            {

                if ((fechaNac == "" || fechaNac == PlaceholderFechaNacimiento) &&
                            (fechaIng == "" || fechaIng == PlaceholderFechaIngreso) &&
                            (salario == "" || salario == PlaceholderSalario))
                {
                    empleado = new Empleado(nombre, apellido, genero);
                }
                // Si hay salario pero no fechas
                else if ((fechaNac == "" || fechaNac == PlaceholderFechaNacimiento) &&
                         (fechaIng == "" || fechaIng == PlaceholderFechaIngreso) &&
                         (salario != "" && salario != PlaceholderSalario))
                {
                    double pSalario = double.Parse(salario);
                    empleado = new Empleado(nombre, apellido, genero, pSalario);
                }

                else
                {
                    string[] fechaDivNac = fechaNac.Split('/');
                    string[] fechaDivIng = fechaIng.Split('/');
                    Fecha pFechaNac = new Fecha(int.Parse(fechaDivNac[0]), int.Parse(fechaDivNac[1]), int.Parse(fechaDivNac[2]));
                    Fecha pFechaIng = new Fecha(int.Parse(fechaDivIng[0]), int.Parse(fechaDivIng[1]), int.Parse(fechaDivIng[2]));
                    double pSalario = double.Parse(salario);
                    empleado = new Empleado(nombre, apellido, genero, pFechaNac, pFechaIng, pSalario);
                }


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
            setPlaceholder(txtFechaNacimiento, "dd/mm/aa");
            setPlaceholder(txtFechaIngreso, "dd/mm/aa");
            setPlaceholder(txtGenero, "'f' o 'm'");
            setPlaceholder(txtSalario, "Solo numeros");
            setPlaceholder(txtCalcularEdad, "Su edad es...");
            setPlaceholder(txtAntiguedad, "Su antigüedad es...");
            setPlaceholder(txtPrestaciones, "Sus prestaciones son...");
            lblMensajeEmple.Text = "";
            lblMensajeEmple.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
        

            if (empleado == null)
            {
                lblMensajeEmple.Text = "⚠ No hay empleado registrado";
                lblMensajeEmple.ForeColor = Color.Red;
                return;
            }

            MessageBox.Show("Su salario actual es: "+empleado.getSalario().ToString("N0"), "SALARIO");
        
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            if (empleado == null)
            {
                lblMensajeEmple.Text = "⚠ No hay empleado registrado";
                lblMensajeEmple.ForeColor = Color.Red;
                return;
            }
            MessageBox.Show("La fecha de ingreso es: "+ empleado.getFechaIngreso().toString());

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularPrestaciones_Click(object sender, EventArgs e)
        {
            if (empleado == null)
            {
                txtPrestaciones.Text = "Debe registrar un empleado";
                txtPrestaciones.ForeColor = Color.Red;
                return;
            }

            Fecha fechaIng = empleado.getFechaIngreso();

            // Calcular edad actual
            Fecha fechaNac = empleado.getFechaNacimiento();
            DateTime fechaNacimiento = new DateTime(fechaNac.getAnio(), fechaNac.getMes(), fechaNac.getDia());
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
                edad=edad-1;

            int antiguedad= DateTime.Today.Year - fechaIng.getAnio();

            // Calcular prestaciones
            double prestaciones = (edad * antiguedad) / 12.0;

            txtPrestaciones.Text = prestaciones.ToString("N2");
            txtPrestaciones.ForeColor = Color.Black;
        }
    }
}
