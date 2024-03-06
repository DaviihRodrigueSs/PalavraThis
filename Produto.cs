using System.Globalization;


namespace TrabalhandoComClassesMelhoria
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //construtor padrão
        public Produto()
        {
            Quantidade = 10;
        }
        //Utilizando o metodo This
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
           

        }

        //Utlizando o metodo This, atribuindo nome e preco, sem precisar escrever novamente.
        public Produto(string nome, double preco, int quantidade) : this(nome,preco) 
        {
            
            Quantidade = quantidade;

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //void significa vazio
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        //sobreposição
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
