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


namespace Proyecto_Estructur_de_Archvos
{
    public partial class Form1 : Form
    {
        TimeSpan tiempoTranscurrido;

        DateTime tiempoInicio = DateTime.MinValue;
        private Timer ti;
        public Form1()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;

        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            label2.Text = hoy.ToString("hh.mm.ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Ingreso_Estacionamiento.txt", true);
            try
            {
                escribir.WriteLine("ESTACIONAMIENTO");
                escribir.WriteLine("INGRESO");
                escribir.WriteLine("Modelo: " + txtIngreso.Text);
                escribir.WriteLine("Placas: " + txtIngreso2.Text);
                escribir.WriteLine("Fecha y Hora de ingreso: \n" + DateTime.Now);
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escribir.Close();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Salida_Estacionamiento.txt", true);
            try
            {
                escribir.WriteLine("ESTACIONAMIENTO");
                escribir.WriteLine("SALIDA");
                escribir.WriteLine("Modelo: " + txtSalida1.Text);
                escribir.WriteLine("Placas: " + txtSalida2.Text);
                escribir.WriteLine("Fecha y Hora de salida: \n" + DateTime.Now);
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escribir.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {

        }

        private void btnEjecutar1_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Ingreso_Estacionamiento.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEjecutar2_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Salida_Estacionamiento.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox2.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtTiempoEstacionamiento.Text == "1")
            {
                MessageBox.Show("$10 Pesos en total.");
            }
            else
            {
                if (txtTiempoEstacionamiento.Text == "2")
                {
                    MessageBox.Show("$20 Pesos en total.");
                }
                else
                {
                    if (txtTiempoEstacionamiento.Text == "3")
                    {
                        MessageBox.Show("$30 Pesos en total.");
                    }
                    else
                    {
                        if (txtTiempoEstacionamiento.Text == "4")
                        {
                            MessageBox.Show("$40 Pesos en total.");
                        }
                        else
                        {
                            if (txtTiempoEstacionamiento.Text == "5")
                            {
                                MessageBox.Show("$50 Pesos en total.");
                            }
                            else
                            {
                                if (txtTiempoEstacionamiento.Text == "6")
                                {
                                    MessageBox.Show("$60 Pesos en total.");
                                }
                                else
                                {
                                    if (txtTiempoEstacionamiento.Text == "7")
                                    {
                                        MessageBox.Show("70 Pesos en total.");
                                    }
                                    else
                                    {
                                        if (txtTiempoEstacionamiento.Text == "8")
                                        {
                                            MessageBox.Show("$80 Pesos en total.");
                                        }
                                        else
                                        {
                                            if (txtTiempoEstacionamiento.Text == "9")
                                            {
                                                MessageBox.Show("$90 Pesos en total.");
                                            }
                                            else
                                            {
                                                if (txtTiempoEstacionamiento.Text == "10")
                                                {
                                                    MessageBox.Show("$100 Pesos en total.");
                                                }
                                                else
                                                {
                                                    if (txtTiempoEstacionamiento.Text == "11")
                                                    {
                                                        MessageBox.Show("$110 Pesos en total.");
                                                    }
                                                    else
                                                    {
                                                        if (txtTiempoEstacionamiento.Text == "12")
                                                        {
                                                            MessageBox.Show("$120 Pesos en total.");
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Limite de tiempo excedido: Favor de buscar ayuda.");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnLimpiar3_Click(object sender, EventArgs e)
        {
            txtIngreso.Text = "";
            txtIngreso2.Text = "";
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtSalida1.Text = "";
            txtSalida2.Text = "";
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            txtTiempoEstacionamiento.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Ingreso_Estacionamiento.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Ingreso_Estacionamiento.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Salida_Estacionamiento.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Salida_Estacionamiento.txt");
        }
    }
}
