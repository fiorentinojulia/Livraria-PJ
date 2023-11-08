using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venda_Livros_PJ
{
    class Livros
    {
        public int IdLivro { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public float Valor { get; set; } //Float é mais leve que o double.
        List<Livros> Livro = new List<Livros>();

        public Livros()
        {
        }

        public Livros(int idLivro, string nome, int estoque, float valor)
        {
            IdLivro = idLivro;
            Nome = nome;
            Estoque = estoque;
            Valor = valor;
        }

        public void ListarLivros()
        {
            Cadastrar();
            Console.WriteLine("Escolha um livro conforme seu número");
            foreach (Livros item in Livro)
            {
                Console.WriteLine($@"
                {item.IdLivro}º Livro
                Nome: {item.Nome}
                Estoque: {item.Estoque}
                Valor: R${item.Valor}
                ");
            }
            int opcao = int.Parse(Console.ReadLine());

            foreach (var verificaLivro in Livro)
            {
                if (verificaLivro.IdLivro == opcao && verificaLivro.Estoque >= 1)
                {
                    
                }
            }
        }
        public void Cadastrar()
        {
            Livro.Add(new Livros(1, "Crepusculo", 3 , 40.99f));
            Livro.Add(new Livros(2, "O Colecionador de Lagrimas", 0 , 39.99f));
            Livro.Add(new Livros(3, "O Menino do Pijama Listrado", 1 , 30.00f));

        }


    }
}
