using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        ClsPersona persona;
        public Form1()
        {
            persona = new ClsPersona();
            InitializeComponent();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                persona.estatura = float.Parse(TxtBxEstatura.Text);
                persona.peso = float.Parse(TxtBxPeso.Text);
                persona.sancada = float.Parse(TxtBxSancada.Text);
                persona.pasos = int.Parse(TxtBxPasos.Text);

                MessageBox.Show(persona.Datos(), "Calculo IMC");

                TxtBxEstatura.Text = "";
                TxtBxPeso.Text = "";
                TxtBxSancada.Text = "";
                TxtBxPasos.Text = "";
            }
            catch
            {
                MessageBox.Show("Ingrese parámetros correctos", "Calculo IMC");

                TxtBxEstatura.Text = "";
                TxtBxPeso.Text = "";
                TxtBxSancada.Text = "";
                TxtBxPasos.Text = "";
            }
        }
    }
}
