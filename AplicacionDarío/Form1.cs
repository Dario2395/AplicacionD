using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDarío
{
    public partial class Form1 : Form
    {
        private int intentosRestantes = 3;
        private const string usuarioCorrecto = "juan";
        private const string contraseñaCorrecta = "practica";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Error: Debe completar ambos campos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Length < 3)
            {
                MessageBox.Show("Error: El usuario debe tener al menos 3 caracteres.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (username == usuarioCorrecto && password == contraseñaCorrecta)
                {
                    MessageBox.Show("¡Bienvenido, Juan!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Oculta la ventana de inicio de sesión
                    Form3 mainForm = new Form3();
                    mainForm.ShowDialog(); // Muestra la pantalla principal
                    this.Close(); // Cierra la ventana de inicio de sesión
                }
                else if (intentosRestantes > 1)
                {
                    intentosRestantes--;
                    MessageBox.Show($"Error: Usuario o contraseña incorrectos. Intentos restantes: {intentosRestantes}", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se han agotado los intentos de inicio de sesión.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); // Salir de la aplicación
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 regg = new Form2();
            regg.Show();
        }
    }
}
