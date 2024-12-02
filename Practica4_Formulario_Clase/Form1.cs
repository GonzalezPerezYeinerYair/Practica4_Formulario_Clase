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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;//importamos la libresioas para realizar la coneccion con la BD


namespace Practica4_Formulario_Clase
{
    public partial class ventana : Form
    {
        string SqlConection = "server=loccalhost; port=3306; Database=Formulario_Registro; UID=root; Pwd=5002y;";
        public ventana()// creamos la ventana
        {
            InitializeComponent();
            // Inicializamos los controladores de eventos para validaciones dinámicas
            tb_nombre.TextChanged += validar_nombre;
            tb_apellidos.TextChanged += validar_apellidos;
            tb_edad.TextChanged += validar_edad;
            tb_estatura.TextChanged += validar_estatura;
            tb_telefono.Leave += validar_telefono;
        }

        //Metodo para Enviar a infromacion al MySql
        private void InsertarRegistro(string nombre, string apellidos, int edad, decimal estatura, string telefono, string genero)//anates de enviar el archivo hay que parsear el 
        {
            //Aqui se importa el string que definimos el la linea 20 el SqlConection
            using (MySqlConnection conection = new MySqlConnection(SqlConection))
            {
                conection.Open();

                string insertQuery = "INSERT INTO registros (Nombre, Apellidos, Edad, Estatura, Telefono, Genero) " +
                 "VALUES (@Nombre, @Apellidos, @Edad, @Estatura, @Telefono, @Genero)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    //Paramatros que se añaden 
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();
                }
                conection.Close();
            }
        }
        private void btn_guardar(object sender, EventArgs e) //boton guardar
        {

            string nombre = tb_nombre.Text;
            string apellidos = tb_apellidos.Text;
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
            string datos = $"nombre: {nombre} \r\n apellidos: {apellidos} \r\n " +
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
                InsertarRegistro(nombre, apellidos, Int32.Parse(edad), decimal.Parse(estatura), telefono, genero);
            }

            //mensaje de accion terminada
            MessageBox.Show("Datos gusrdados con exito: \r\n" + datos + "\r\nInformacion");
        }

        ////////metodos booleanos para validar los enteros o decimales///

        private bool EsTextoValido(string valor) {

            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }
        private bool EsEnteroValido(string valor) {

            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsEnteroValidoDe10Digitos(string valor) {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsDecimalValido(string valor) {
        decimal resultado;
        return decimal. TryParse(valor, out resultado);
        }
        //Metodos para validar/////////////////////////////////////////////////////////////////

       //validar nombre
        private void validar_nombre(object sender, EventArgs e)
        {

            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {

                MessageBox.Show("por favor, ingrese un Nombre valido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        
        //validar apellidos
        private void validar_apellidos(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese Apellidos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        // Método para validar la edad
        private void validar_edad(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            if (!EsEnteroValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una Edad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        // Método para validar la estatura
        private void validar_estatura(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una Estatura válida (número positivo)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        // Método para validar el teléfono
        private void validar_telefono(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            if (textbox.Text.Length == 10 && EsEnteroValidoDe10Digitos(textbox.Text))
            {
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una numero de telefono valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
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
