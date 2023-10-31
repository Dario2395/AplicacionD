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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        MessageBox.Show(ex.Message, "Eliminando Producto",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {



                    MessageBox.Show("Debes seleccionar un producto", "Eliminando producto",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (dataProducto.SelectedRows.Count <= 0) //En caso que no exista renglón seleccionado
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modifica producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                //Copiar los valores de datagridview a las cajas de texto

                textBox1.Text = dataProducto.CurrentRow.Cells["Producto"].Value.ToString();

                textBox2.Text = dataProducto.CurrentRow.Cells["Descripcion"].Value.ToString();

                textBox3.Text = dataProducto.CurrentRow.Cells["Marca"].Value.ToString();

                textBox4.Text = dataProducto.CurrentRow.Cells["Precio"].Value.ToString();

                comboBox1.Text = dataProducto.CurrentRow.Cells["Stock"].Value.ToString();

                comboBox2.Text = dataProducto.CurrentRow.Cells["Lugar"].Value.ToString();

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
                MessageBox.Show(ex.Message, "Agregando Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 reg2 = new Form4();
            reg2.Show();
        }
    }
    }

        
    


