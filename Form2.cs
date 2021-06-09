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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnviarAsis_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Asistencia_Estacionamiento.txt", true);
            try
            {
                escribir.WriteLine("Asistencia");
                escribir.WriteLine("Reporte:");
                escribir.WriteLine(txtEnviar.Text);
                escribir.WriteLine("Fecha y Hora de reporte: \n" + DateTime.Now);
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escribir.Close();
        }

        private void btnLimpiarAsis_Click(object sender, EventArgs e)
        {
            txtEnviar.Text = "";
        }

        private void btnMostrarReportes_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\juand\OneDrive\Escritorio\Cuarto Semestre\Estructura de Archivos\Segundo Parcial\Archivos txt proyecto\Asistencia_Estacionamiento.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    txtReportes.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
