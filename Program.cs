using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int ano;

            Console.WriteLine("Digite o dia do seu aniverário: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o mês do seu aniverário: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano do seu aniverário: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            string nomeMes = CapturarMês(mes);

            Console.WriteLine("Data de Nascimento: " + dia.ToString("00") + "/" + mes.ToString("00") + "/" + ano);
            Console.WriteLine("Você nasceu em: " + dia.ToString("00") + " de " + nomeMes + " de " + ano);

            Console.ReadLine();
        }

        public static string CapturarMês (int mes)
        {
            string[] listames = new string[12];
            listames[0] = "Janeiro";
            listames[1] = "Fevereiro";
            listames[2] = "Março";
            listames[3] = "Abril";
            listames[4] = "Maio";
            listames[5] = "Junho";
            listames[6] = "Julho";
            listames[7] = "Agosto";
            listames[8] = "Setembro";
            listames[9] = "Outubro";
            listames[10] = "Novembro";
            listames[11] = "Dezembro";

            return listames[mes - 1];
        }
    }
}
