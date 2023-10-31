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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox4.Text;
            string gmail = textBox3.Text;

            string usuarioCorrecto = "juan";
            string contraseñaCorrecta = "practica";
            string gmailCorrecto = "juan777@cbtis75.edu.mx";

            if (username == usuarioCorrecto && password == contraseñaCorrecta && gmail == gmailCorrecto)
            {
                MessageBox.Show($"¡Bienvenido, {usuarioCorrecto}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 mainForm = new Form3();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Usuario, contraseña o correo incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            reg.Show();
        }
    }
}
        
    

