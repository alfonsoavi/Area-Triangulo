using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Área_Triángulo
{
    public partial class Form1 : Form
    {
        int numero = 1;

        public Form1()
        {
            InitializeComponent();
            t_num.Text = Convert.ToString(numero);
            string sentencia = "select numero from tabla_area ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {

                int fact = Convert.ToInt32(registros[0].ToString());
                numero = fact + 1;
                t_num.Text = Convert.ToString(numero);
            }

            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_base.Text.Equals("") || t_altura.Text.Equals(""))
                MessageBox.Show("Los campos Base y Altura se encuentras sin datos");
            else
            { 
            int BASE;
            BASE = Convert.ToInt32(t_base.Text);

                int ALTURA;
            ALTURA = Convert.ToInt32(t_altura.Text);

                double resultado;
            resultado = (BASE * ALTURA) / 2;
            t_area.Text = Convert.ToString(resultado);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (t_base.Text.Equals("") || t_altura.Text.Equals("") || t_area.Text.Equals(""))
            {
                MessageBox.Show("Los campos Base y Altura deben estar llenos para guardar");
            }
            else
            {
                string sentencia = "insert into tabla_area values(" + t_num.Text + ","
            + t_base.Text + ","+ t_altura.Text + "," + t_area.Text + ")";
                Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();

                numero = Convert.ToInt32(t_num.Text);
                numero = numero + 1;
                t_num.Text = Convert.ToString(numero);
                t_base.Text = "";
                t_altura.Text = "";
                t_area.Text = "";
                conexion.Close();

                MessageBox.Show("Los datos se guardaron correctamente");
            }
        }

        private void VerInfor_Click(object sender, EventArgs e)
        {
            obtener_datos();
        }

        public void obtener_datos()
        {
            TablaArea.Rows.Clear();
            string sentencia = "select * from tabla_area ";
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {

                string num = registros[0].ToString();
                string bas = registros[1].ToString();
                string alt = registros[2].ToString();
                string are = registros[3].ToString();

                TablaArea.Rows.Add(num, bas, alt, are);
            }

            conexion.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            {
                String n = (String)TablaArea.CurrentRow.Cells[0].Value;
                string sentencia = "delete from tabla_area where numero=" + n;
                //Console.WriteLine(sentencia);
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Los datos se eliminaron correctamente");
                obtener_datos();
            }
            {
                numero = 1;
                string sentencia = "select numero from tabla_area ";
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");

                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                while (registros.Read())
                {

                    int fact = Convert.ToInt32(registros[0].ToString());
                    numero = fact + 1;

                }
                t_num.Text = Convert.ToString(numero);
                conexion.Close();
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            String n = (String)TablaArea.CurrentRow.Cells[0].Value;
            string sentencia = "select * from tabla_area where numero=" + n;
            //Console.WriteLine(sentencia);
            SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                string num = registros[0].ToString();
                string bas = registros[1].ToString();
                string altu = registros[2].ToString();
                string ar = registros[3].ToString();

                t_num.Text = num;
                t_base.Text = bas;
                t_altura.Text = altu;
                t_area.Text = ar;
            }
            conexion.Close();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            {
                if (t_base.Text.Equals("") || t_altura.Text.Equals("") || t_area.Text.Equals(""))
                {
                    MessageBox.Show("Los campos Base y Altura deben estar llenos para actualizar");
                }
                else
                {
                    string sentencia = "update tabla_area set base=" + t_base.Text + ",altura="
                                    + t_altura.Text + ",area= " + t_area.Text + " where numero=" + t_num.Text;
                    //Console.WriteLine(sentencia);
                    SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();
                    t_num.Text = "";
                    t_base.Text = "";
                    t_altura.Text = "";
                    t_area.Text = "";
                    conexion.Close();
                    MessageBox.Show("Los datos se actulizaron correctamente");
                }
            }
            {
                string sentencia = "select numero from tabla_area ";
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=usuario;Trusted_Connection=True;");
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                while (registros.Read())
                {
                    int num = Convert.ToInt32(registros[0].ToString());
                    numero = num + 1;
                    t_num.Text = Convert.ToString(numero);
                }

                conexion.Close();
            }
        }
    }
    
}
