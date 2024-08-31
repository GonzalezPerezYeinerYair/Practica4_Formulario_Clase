using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica4_Formulario_Clase
{
    public partial class ventana : Form
    {
        public ventana()// creamos la ventana
        {
            InitializeComponent();
        }

        private void btn_guardar(object sender, EventArgs e) //boton guardar
        {
            string nombre = tb_nombre.Text;
            string apellido = tb_apellidos.Text;
            string telefono = tb_telefono.Text; //Se guarda los datos del formulario en variables tipo string
            string estatura = tb_estatura.Text;
            string edad = tb_edad.Text;

            string genero = ""; //metodo para elegir genero 
            if (rb_hombre.Checked) {
                genero = "hombre";
            }
            else if (rb_mujer.Checked) {
                genero = "mujer";
            }
            //Se guardan las variables del formulario en un solo ente llamlo "datos"
            string datos = $"nombre: {nombre} \r\n apellidos: {apellido} \r\n " +
                $"telefono: {telefono} \r\n Estatura: {estatura} \r\n Edad:{edad} \r\n Genero:{genero}";
            //se guarda la futura ruta de archivo en una variable
            string ruta_archivo = "C:/Users/User/Desktop/Programacion_avanzada_textos.txt";
            bool archivos_existe = File.Exists(ruta_archivo);

            //Con esta funcion podemos crear  un cuadro de texto y unir informacion a elladeste 
            using (StreamWriter writer = new StreamWriter(ruta_archivo, true)) {
                if (archivos_existe) {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }

            //mensaje de accion terminada
            MessageBox.Show("Datos gusrdados con exito: \r\n" + datos + "\r\nInformacion");
        }
        //Boton de limpiar
        private void btn_cancelar(object sender, EventArgs e)
        {
            tb_apellidos.Clear();
            tb_telefono.Clear();
            tb_edad.Clear();
            tb_estatura.Clear();
            tb_nombre.Clear();
            rb_hombre.Checked = false;
            rb_mujer.Checked = false;
        }     
        
        // Estos crean los componentes del formulario. 
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
