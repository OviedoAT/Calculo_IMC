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
                MessageBox.Show("Rellene todos los campos", "Calculo IMC");
            }
        }

        private void TxtBxEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        } 

        private void TxtBxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtBxSancada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtBxPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }
    }
}
