using System;
using System.Collections;
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

        int cont = 0;


        private void button2_Click(object sender, EventArgs e)
        {

            string[] erro = new string[7];

            Dica.Text = "";

            

            int b = 0;
            foreach (char contagem in msg)
            {
                b++;
            }
            string []mostrar = new string [b];
            string[] dica = new string[b];

            string [] resposta =  new string[b];
            int c = 0;
            foreach (char agora in msg)
            {
                resposta[c++] = agora.ToString();
            }

            string palpite = textBoxPalpite.Text ;

            int i = 0;

            string d = "";

            for (int a = 0; a < resposta.Length; a++)
            {
                
                if ( palpite == resposta[a])
                {
                    dica[a] = resposta[a];

                    d = dica[a];

                    Dica.Text += dica[a];
                }

                else
                {
                    if (dica[a] == d)
                    {
                        dica[a] = d;
                    }
                    else
                    {
                        dica[a] = " _";
                        Dica.Text += dica[a];
                        erro[a] = palpite;
                        textBoxErro.Text += erro[a] + " ";
                    }
                }
            }

        }
        public static string msg = "";
        private void NovoJogo_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();

            newForm2.ShowDialog();

            string palavra = 

            Dica.Text = "";

            int b = 0;
            foreach (char partiu in msg)
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
