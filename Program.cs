

using System.Globalization;

namespace firstproject

{

    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            int quantidadeDeQuarto = int.Parse(Console.ReadLine());
            double precoDoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] sobrenomeIdadeAltura = Console.ReadLine().Split(' ');

            string sobrenome = sobrenomeIdadeAltura[0];
            int idade = int.Parse(sobrenomeIdadeAltura[1]);
            double altura = double.Parse(sobrenomeIdadeAltura[2]);


            Console.WriteLine("Entre com seu nome completo: ");
            Console.WriteLine(nome);
            Console.WriteLine(quantidadeDeQuarto);
            Console.WriteLine(precoDoProduto.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }


    }

}