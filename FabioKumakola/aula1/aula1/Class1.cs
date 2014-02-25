using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class Class1
    {
        public int x;

        public double[] n = new double[100000];

        private double pmaior = 0;
        private double pmenor = 0;
        private double maiormedia = 0;
        private double menormedia = 0;
        private double soma = 0;
        private double media;
        private double maiorvalor = -1;
        private double menorvalor = 11;
        private double dp = 0;
        private double mediana;

        public string rmedia()
        {
            for (int i = 0; i < x; i++)
            {
                soma = n[i] + soma;
            }

            this.media = Math.Round(soma / x * 100) / 100;

            return "A média dos números dados são: " + media;
        }

        public string rmaiorvalor()
        {
            for (int i = 1; i < x; i++)
                if (n[i] > maiorvalor)
                    maiorvalor = n[i];

            return "O maior valor é: " + maiorvalor;
        }

        public string rmenorvalor()
        {
            for (int i = 1; i < x; i++)
                if (n[i] < menorvalor)
                    menorvalor = n[i];

            return "O menor valor é: " + menorvalor;
        }

        public string rmaiormedia()
        {
            for (int i = 0; i < x; i++)
                if (n[i] > media)
                    maiormedia++;

            return "Tem " + maiormedia + " acima da média.";
        }
        public string rmenormedia()
        {
            for (int i = 0; i < x; i++)
                if (n[i] < media)
                    menormedia++;

            return "Tem " + menormedia + " abaixo da média.";
        }

        public string rpmaior()
        {
            pmaior = Math.Round((maiormedia / x) * 100 * 100) / 100;
            return pmaior + "% estão acima da média";
        }

        public string rpmenor()
        {
            pmenor = Math.Round((menormedia / x) * 100 * 100) / 100;
            return pmenor + "% estão abaixo da média";
        }

        public string reeleicao()
        {
            if (media >= 4.87 && pmaior >= 60)
                return "Será reeleito.";
            else
                return "Não será reeleito.";
        }

        public string rdp()
        {
            double[] d = new double[x];
            
            for (int i = 0; i < x; i++)
                d[i] = n[i] - media;

            for (int i = 0; i < x; i++)
                d[i] = d[i] * d[i];

            for (int i = 0; i < x; i++)
                dp = dp + d[i];

            dp = dp / x;
            dp = Math.Round(Math.Sqrt(dp) * 100) / 100;

            return "O desvio padrão é de: " + dp;
        }

        public string rmediana()
        {
            
            if (x % 2 == 0)
            {
                int y = x / 2;
                int z = y - 1;

                mediana = (n[y] + n[z]) / 2; 
            }
            else
            {
                int y = x / 2;

                mediana = n[y];
            }
            return "A mediana dos números é: " + mediana;
        }
    }


}
