using Ejercicio1_1_.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1_1_
{
    public partial class Form1 : Form
    {
        List<Cuenta> cuentas = new List<Cuenta>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            #region parseo
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);
            #endregion

            //creamos una nueva cuenta con el parseo
            Cuenta nuevo = new Cuenta(dni, nombre, importe);

            cuentas.Sort();
            int idx = cuentas.BinarySearch(nuevo);
            if (idx >= 0)
            {
                //actualizo el registro
                cuentas[idx].Nombre = nuevo.Nombre;
                cuentas[idx].Importe += nuevo.Importe;  //acumulo 
            }
            else
            {
                cuentas.Add(nuevo);
            }

            btnActualizar.PerformClick(); //llama al evento onclick del botón Actualizar

            //fin de la modificación
            tbDNI.Clear();
            tbNombre.Clear();
            tbImporte.Clear();
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbVer.Items.Clear();
            foreach (Cuenta cuenta in cuentas)
            {
                lsbVer.Items.Add(cuenta);
            }

        }

        private void lsbVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta selectedCuenta = lsbVer.SelectedItem as Cuenta;

            if (selectedCuenta != null)
            {
                tbDNI.Text = selectedCuenta.DNI.ToString();
                tbNombre.Text = selectedCuenta.Nombre;
                tbImporte.Text = selectedCuenta.Importe.ToString("0.00");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Su función es leer un archivo de texto de “campo fijo” (cada línea tiene datos en posiciones específicas) 
            //y crear objetos Cuenta a partir de esas líneas.

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string path = openFileDialog1.FileName; //Ruta de accesso del archivo

                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read); //clase que permite trabajar con archivos a nivel de bytes.
                StreamReader sr = new StreamReader(fs); //  clase que permite leer texto desde un FileStream.

                while (sr.EndOfStream == false) 
                {
                    string linea = sr.ReadLine(); //Lee una línea completa del archivo (un registro).

                    string dni = linea.Substring(0, 9).Trim();
                    string nombre = linea.Substring(9, 10).Trim();
                    string importe = linea.Substring(19, 9).Trim();

                    Cuenta Cuenta = new Cuenta(Convert.ToInt32(dni), nombre, Convert.ToDouble(importe));
                }
                sr.Close();
                fs.Close();

            }
            btnActualizar.PerformClick();

        }
    }
}
