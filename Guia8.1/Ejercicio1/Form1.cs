using Ejercicio1.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio1
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
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDni.Text);
            double Importe = Convert.ToDouble(tbImporte.Text);
            Cuenta c = new Cuenta(nombre, dni, Importe);
           

            cuentas.Sort();
            int idx = cuentas.BinarySearch(c);
            if (idx >= 0)// actualizar
                
            {
                cuentas[idx].Nombre = nombre;
                cuentas[idx].Importe = Importe;
            }
            else
            {
                
                cuentas.Add(c);
            }
            

            btnActualizar.PerformClick();

            tbNombre.Clear();
            tbDni.Clear();
            tbImporte.Clear();
                
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ltResultado.Items.Clear();
            foreach (Cuenta c in cuentas)
            {
                ltResultado.Items.Add(c);
            }



        }

        private void ltResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta c = ltResultado.SelectedItem as Cuenta;
            if (c != null)
            {
                tbDni.Text = $"{c.Dni}";
                tbImporte.Text = $"{c.Importe}";
                tbNombre.Text = $"{c.Nombre}";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                string path = openFileDialog1.FileName;
                FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (sr.EndOfStream == false) 
                {
                    string linea = sr.ReadLine();
                    string dni = linea.Substring(0, 9);
                    string nombre = linea.Substring(9, 10).Trim();
                    string importe = linea.Substring(19, 9);
                    Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToDouble(importe));
                }
            }
        }
    }
}
