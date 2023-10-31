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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";

            string titulo = "Eliminando el registro"; //título del cuadro de diálogo

            if (!(dataProducto.CurrentRow is null)) //En caso que no exista renglón seleccionado DataGridView
            {
                //Cuadro de diálogo con botónes Si o No

                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataProducto.Rows.Remove(dataProducto.CurrentRow); //Eliminar el renglón

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eliminando registro",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {



                    MessageBox.Show("Debes seleccionar un registro", "Eliminando registro",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (dataProducto.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modifica personal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {



                textBox1.Text = dataProducto.CurrentRow.Cells["Nombre"].Value.ToString();

                textBox2.Text = dataProducto.CurrentRow.Cells["Apellidos"].Value.ToString();

                textBox3.Text = dataProducto.CurrentRow.Cells["Matricula"].Value.ToString();

                textBox4.Text = dataProducto.CurrentRow.Cells["Puesto"].Value.ToString();

                comboBox1.Text = dataProducto.CurrentRow.Cells["Edad"].Value.ToString();

                comboBox2.Text = dataProducto.CurrentRow.Cells["Turno"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow renglon = (DataGridViewRow)dataProducto.Rows[0].Clone();
            try
            {
                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox2.Text;
                renglon.Cells[2].Value = textBox3.Text;
                renglon.Cells[3].Value = textBox4.Text;
                renglon.Cells[4].Value = comboBox1.Text;
                renglon.Cells[5].Value = comboBox2.Text;


                dataProducto.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

