using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema_Venda_Livros_PJ
{
    class Login
    {
        public string Email { get; set; }
        public int Senha { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public string DtNascimento { get; set; }
        List<Login> Usuario = new List<Login>();

        public Login()
        {
            MenuLogin();
        }

        public Login(string email, int senha, string nome, string endereco, int telefone, string dtNascimento)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            DtNascimento = dtNascimento;
        }

        public void MenuLogin()
        {

            bool continuar = true;
            do
            {
                Console.WriteLine(@"
            --------------------------
            |                        |
            |    Escolha uma opção   |
            |                        |
            |   [1] Cadastro         |
            |   [2] Login            |
            |   [0] Sair             |
            |                        |
            --------------------------
            ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //bool validacao = ValidarLogin();
                        CadastrarUsuario();

                        /*Livros nome = new Livros();
                        nome.ListarLivros();
                        Console.WriteLine();*/

                        /*  if (validacao == true)
                          {
                          }*/
                        break;


                    case 2:
                        ValidarLogin();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine("Muito Obrigado!!!!");
                        continuar = false;
                        break;

                }



            } while (continuar == true);

        }
        public bool ValidarLogin()
        {
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Senha: ");
            int senha = int.Parse(Console.ReadLine());

            //operadores comparação
            // && = "E" todas as verificações deve retornar true
            // || = "OU" uma das verificações deve retornar true

            foreach (var user in Usuario)
            {
                if (email == user.Email && senha == user.Senha)
                {
                    Console.WriteLine("Usuário logado com sucesso!!!");
                    Console.WriteLine();
                    Console.WriteLine("Pressione Enter para Continuar! ");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    MenuSenac();
                    return true;
                }
                else
                {
                    Console.WriteLine("Senha ou email Inválido");
                    return false;
                }
            }
            return false;
        }

        public void CadastrarUsuario()
        {

            Console.WriteLine("Nome:");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            this.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            this.Telefone = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de Nascimento: ");
            this.DtNascimento = Console.ReadLine();
            Console.WriteLine("Email: ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Senha: ");
            this.Senha = int.Parse(Console.ReadLine());

            Usuario.Add(new Login(this.Email, this.Senha, this.Nome, this.Endereco, this.Telefone, this.DtNascimento));
        }




        public void GerarMenuOpcao()
        {

        }

       
        public void MenuSenac()
        {
            bool continuar = true;
            
            do
            {
                Console.WriteLine(@"
                ----------------------------
                |                          |
                |                          |          
                |     Seja Bem-Vindo ao    |
                |       SenacBook          |
                |                          |
                |       [1] Livro          |
                |       [2] Comprar        |
                |       [0] Sair           |
                |                          |
                ---------------------------- 
                ");
                Console.WriteLine();
                Console.WriteLine("Escolha uma das Opções acima! ");
                Thread.Sleep(1000);

               
                int selecionar = int.Parse(Console.ReadLine()); 
                

                switch (selecionar)
                {


                    case 1:
                        Livros nome = new Livros();
                        nome.ListarLivros();
                        Console.WriteLine();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine("Muito Obrigado!!!!");
                        continuar = false;
                        break;

                }

            } while (continuar == true);

        }

      

    }
}



