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

        ArrayList array = new ArrayList();


        private void button2_Click(object sender, EventArgs e)
        {

            string erro = "";

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

                    array[a] = resposta[a];

                    d = dica[a];

                    Dica.Text += array[a];
                }

                else
                {
                    if (dica[a]=="_ ")
                    {
                        Dica.Text += array[a];

                    }
                    else
                    {
                        
                        Dica.Text += array[a];
                        erro += palpite+" ";
                        textBoxErro.Text = erro;
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
                array.Add("_ ");
            }

            for (int i = 0; i < b; i++)
            {
                
                
                Dica.Text += "_ ";
            }
        }
    }
}
