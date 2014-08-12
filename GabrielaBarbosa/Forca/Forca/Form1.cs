using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string palavra = "cachorro";
        private void button2_Click(object sender, EventArgs e)
        {

            string[] erro = new string[7];

            Dica.Text = "";

            int b = 0;
            foreach (char partiu in palavra)
            {
                b++;
            }
            string []dahora = new string [b];

            string [] resposta =  new string[b];
            int c = 0;
            foreach (char agora in palavra)
            {
                resposta[c++] = agora.ToString();
            }

            string palpite = textBoxPalpite.Text ;

            int i = 0;

           

            for (int a = 0; a < resposta.Length; a++)
            {
                if ( palpite == resposta[a])
                {
                    dahora[a] = resposta[a];
                    Dica.Text += dahora[a];
                }

                else
                {
                    Dica.Text += "_ ";
                    erro[a] = palpite;
                    textBoxErro.Text = erro[a];
                }
            }

        }

        private void NovoJogo_Click(object sender, EventArgs e)
        {
            Dica.Text = "";

            int b = 0;
            foreach (char partiu in palavra)
            {
                b++;
            }

            for (int i = 0; i < b; i++)
            {
                Dica.Text += "_ ";
            }
        }
    }
}
