using System.Globalization;
using TrabalhandoComClassesMelhoria;

namespace TrabalhandoComClasseMelhoria
{
    class Program

    {
        static void Main(string[] args)
        {


            /*Proposta de melhoria
            
            Quando executamos o comando,abaixo instaciamos um produto"p" com seus atributos "vazios":

            p = new Produto(); memoria: p = nome - null - preco 0.0 - quantidade 0

            Entretanto, faz sentido um produto que não tem nome?.Faz sentido um produto que não tem preço?

            Com o intuito de evitar a existência de produtos sem nome e sem preço, é possível fazer com que seja "obrigatoria" a iniciação desses valores? 

            Resposta: Sim, e só a gente criar um construtor, porque ai o programador vai ser obrigado a inserir um valor.
            */





            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");

            string nome = Console.ReadLine();

            Console.Write("Preço: ");

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciação a baixo

            Produto p = new Produto(nome, preco);




            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");

            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


            Console.Write("Digite o numero de produtos a ser removido do estoque: ");

            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine();

            Console.Write("Dados atualizados: " + p);

            Console.WriteLine();
        }
    }
}
