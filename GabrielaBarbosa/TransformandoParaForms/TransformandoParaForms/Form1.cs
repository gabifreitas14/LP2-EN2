using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformandoParaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            int[] cpf = new int[11];

            int[] um = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 0 };

            int[] dois = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] numeros = new int[10];

            int[] numerais = new int[10];

            int soma1 = 0;

            int soma2 = 0;

            int i = 0;
            foreach (char digito in textBoxCPF.Text)
            {
                cpf[i++] = int.Parse(digito.ToString());

            }

           



               

                for (int a = 0; a < 10; a++)
                {
                    numeros[a] = um[a] * cpf[a];

                    numerais[a] = dois[a] * cpf[a];

                    soma1 = soma1 + numeros[a];

                    soma2 = soma2 + numerais[a];

                }


                int divisao = soma1 % 11;

                int divisoes = soma2 % 11;

                if (divisao == 0 || divisao == 1)
                {
                    if (cpf[9] != 0)
                    {
                        MessageBox.Show("CPF Inválido");

                    }


                }


                else if ((11 - divisao) != cpf[9])
                {

                    MessageBox.Show("CPF Inválido");


                }

                else if (divisoes == 0 || divisoes == 1)
                {

                    if (cpf[10] != 0)
                    {
                        MessageBox.Show("CPF Inválido");

                    }

                    else
                    {
                        MessageBox.Show("CPF Válido");
                    }

                }

                else
                {

                    if (11 - divisoes != cpf[10])
                    {
                       MessageBox.Show("CPF Inválido");
                    }

                    else
                    {
                        MessageBox.Show("CPF Válido");
                    }


                }

                textBoxCPF.Focus();

            }

        }
    }
