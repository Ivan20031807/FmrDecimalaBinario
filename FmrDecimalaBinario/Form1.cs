using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FmrDecimalaBinario
{
    public partial class fmrdecimalabinario : Form
    {
        public fmrdecimalabinario()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            int[] res = binario(numero);
            Console.WriteLine("Inicio");
            for (int i=res.Length-1; i>=0; i--)
            {
                Console.Write("{0}" , res[i]);
            }
            Console.WriteLine("Fin");
            if (res[0] == 1)
            {
                this.Encendido_o_apagado1.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado1.Checked = false;
            }
            if (res[1] == 1)
            {
                this.Encendido_o_apagado2.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado2.Checked = false;
            }
            if (res[2] == 1)
            {
                this.Encendido_o_apagado3.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado3.Checked = false;
            }
            if (res[3] == 1)
            {
                this.Encendido_o_apagado4.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado4.Checked = false;
            }
            if (res[4] == 1)
            {
                this.Encendido_o_apagado5.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado5.Checked = false;
            }
            if (res[5] == 1)
            {
                this.Encendido_o_apagado6.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado6.Checked = false;
            }
            if (res[6] == 1)
            {
                this.Encendido_o_apagado7.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado7.Checked = false;
            }
            if (res[7] == 1)
            {
                this.Encendido_o_apagado8.Checked = true;
            }
            else
            {
                this.Encendido_o_apagado8.Checked = false;
            }
            

        }
        private int [] binario(int num)
        {
            int [] bin = {0, 0, 0, 0, 0, 0, 0, 0 };
            //int[] bin = new int[8];
            int i = 0;
            int resto = 0;
            while (num > 0)
            {
                resto = num % 2;
                bin[i++] = resto;
                num = num / 2;
                Console.WriteLine("{0}", resto);
            }
            return bin;
        }

        private void Encendido_o_apagado1_CheckedChanged(object sender, EventArgs e)
        {
            sumaBinarioaDecimal();
        }
        void sumaBinarioaDecimal()
        {
            int num = 0;
            if (Encendido_o_apagado1.Checked) num += 1;
            if (Encendido_o_apagado2.Checked) num += 2;
            if (Encendido_o_apagado3.Checked) num += 4;
            if (Encendido_o_apagado4.Checked) num += 8;
            if (Encendido_o_apagado5.Checked) num += 16;
            if (Encendido_o_apagado6.Checked) num += 32;
            if (Encendido_o_apagado7.Checked) num += 64;
            if (Encendido_o_apagado8.Checked) num += 128;
            this.txtNumero.Text = num.ToString();
        }
    } 
    
}
