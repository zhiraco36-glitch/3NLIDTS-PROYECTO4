using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_PROYECTO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string Apellido = txt_Apellidos.Text;
            string tel = txt_Telefono.Text;
            string edad = txt_Edad.Text;
            string estatura = txt_Estatura.Text;
            string genero = "";
            if (rb_Fem.Checked)
            {
                genero = "Femenino";

            }
            if (rb_Mas.Checked)
            {
                genero = "Masculino";

            }
            if (rb_otro.Checked)
            {
                genero = "Otro";
            }
            string mensaje = $"Nombre: {nombre} \n\r Apellidos: {Apellido} \n\r Telefono: {tel} \n\r Edad: {edad}\n\r Estatura: {estatura}\n\r genero {genero}";
            string ruta = Path.Combine(Application.StartupPath, "registros.txt");
            using (StreamWriter escritor= new StreamWriter (ruta, true))
                MessageBox.Show(mensaje, "Confirmacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellidos.Clear();
            txt_Telefono.Clear();
            txt_Edad.Clear();
            txt_Estatura.Clear();
            rb_Fem.Checked = false;
            rb_Mas.Checked = false;
            rb_otro.Checked = false;
            

        }
    }
}
