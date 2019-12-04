using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorRUTRUN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validador validRUT = new Validador();
            
            if (txtRUN.Text.Contains("-"))
            {
                String[] origRUNcDigito = txtRUN.Text.Split('-');
                if (origRUNcDigito[1] == validRUT.VerifiRut(origRUNcDigito[0]))
                {
                    MessageBox.Show("El RUN o RUT ingresado es válido.", "Validador", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("El RUN o RUT ingresado no es válido. Por favor, verifique su información.", "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String[] origRUNcDigito = new String[2];
                origRUNcDigito[0] = txtRUN.Text.Substring(0, txtRUN.Text.Length - 1);
                origRUNcDigito[1] = txtRUN.Text[txtRUN.Text.Length - 1].ToString();
                if (origRUNcDigito[1] == validRUT.VerifiRut(origRUNcDigito[0]))
                {
                    MessageBox.Show("El RUN o RUT ingresado es válido.", "Validador", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("El RUN o RUT ingresado no es válido. Por favor, verifique su información.", "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
