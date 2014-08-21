using System;
using System.Collections;
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


        List<string> mostrar = new List<string>();

        int errosRestantes = 7;



        private void button2_Click(object sender, EventArgs e)
        {


            textBoxPalpite.Focus();

            Dica.Text = "";

            int c = 0;

            string palpite = textBoxPalpite.Text;

            int contagem = msg.Length;



            string[] resposta = new string[contagem];

            char[] certas = new char[contagem];

            foreach (char agora in msg)
            {
                resposta[c] = agora.ToString();
                c++;
            }

            int contadoracertos = resposta.Length;

            int paraacertar = resposta.Length;

            for (int a = 0; a < resposta.Length; a++)
            {

                if (palpite == resposta[a])
                {


                    mostrar[a] = resposta[a];


                    Dica.Text += mostrar[a];

                    contadoracertos--;
                }

                else
                {

                    if (mostrar[a].ToString() == "_ ")
                    {
                        Dica.Text += mostrar[a];
                    }
                    else
                    {
                        Dica.Text += mostrar[a].ToString();
                    }
                }
            }

            if (Dica.Text == msg)
            {
                parabens parabens = new parabens();
                parabens.Show();

            }

            if (errosRestantes == 1)
            {
                poxa poxa = new poxa();
                poxa.Show();
            }

            if (paraacertar == contadoracertos)
            {
                textBoxErro.Text += palpite + " ";
                errosRestantes--;
                ntentativas.Text = errosRestantes.ToString();
            }

            textBoxPalpite.Clear();

        }
        public static string msg = "";
        private void NovoJogo_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();

            errosRestantes = 7;

            ntentativas.Text = errosRestantes.ToString();

            textBoxErro.Clear();

            newForm2.ShowDialog();

            Dica.Text = "";

            mostrar.Clear();
            int b = 0;
            foreach (char partiu in msg)
            {
                b++;

                mostrar.Add("_ ");
            }

            for (int i = 0; i < b; i++)
            {
                Dica.Text += "_ ";
            }
        }

        private void textBoxErro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
