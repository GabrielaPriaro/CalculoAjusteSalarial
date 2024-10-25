//Problema "aumento" (adaptado de URI 1048)
//Uma empresa vai conceder um aumento percentual de salário aos seus funcionários dependendo de quanto
//cada pessoa ganha, conforme tabela ao lado. Fazer um programa para ler o salário de uma pessoa, daí mostrar
//qual o novo salário desta pessoa depois do aumento, quanto foi o aumento e qual foi a porcentagem de aumento.
//Salário atual Aumento
//Até R$ 1000.00 20%
//Acima de R$ 1000.00 até R$ 3000.00 15%
//Acima de R$ 3000.00 até R$ 8000.00 10%
//Acima de R$ 8000.00 5% 

using System.Globalization;

namespace CalculoAjusteSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, ajusteSalario, porcentAjuste;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine(), CI);

            if (salario <= 1000)
            {
                porcentAjuste = 20;
            }
            else if (salario > 1000 && salario <= 3000)
            {
                porcentAjuste = 15;
            }
            else if (salario > 3000 && salario <= 8000)
            {
                porcentAjuste = 10;
            }
            else
            {
                porcentAjuste = 5;
            }

            novoSalario = salario + (salario * porcentAjuste / 100);
            ajusteSalario = novoSalario - salario;
            

            Console.WriteLine($"Novo salario = R$ {novoSalario.ToString("F2", CI)}");
            Console.WriteLine($"Ajuste salarial = R$ {ajusteSalario.ToString("F2", CI)}");
            Console.WriteLine($"Porcentagem ajuste salarial = {porcentAjuste.ToString("F2", CI)} %");
        }
    }
}
