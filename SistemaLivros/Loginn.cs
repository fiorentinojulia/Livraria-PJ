using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venda_Livros_PJ
{
    class Loginn
    {
        public class cadastro
        {
            public Model Projeto { get; set; }
            public Loginn Detalhe { get; set; }


            cadastro modelo;
            public int opcao;

            public cadastro()
            {
                this.modelo = new cadastro();//Criando uma chave            
                ConsultarOpcao = -1;
            }//Fim do construtor

            public int ConsultarOpcao
            {
                get { return this.opcao; }
                set { this.opcao = value; }
            }

            public void MenuLogin()
            {


                Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                                  "0. Login\n" +
                                  "1. Cadastrar-se\n");
                opcao = Convert.ToInt32(Console.ReadLine());




            }//Fim do menu





            public void Operacao()
            {
                MenuLogin();//Mostrar o menu em tela
                switch (ConsultarOpcao)
                {
                    case 0:

                        string Login;
                        string senha;
                        Console.WriteLine("Login: ");
                        Login = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Senha: ");
                        senha = Convert.ToString(Console.ReadLine());

                        break;

                    case 1:
                        string nome;
                        string endereco;
                        string telefone;
                        string dtNascimento;
                        string login1;
                        string senha1;

                        Console.WriteLine("nome: ");
                        nome = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("endereço");
                        endereco = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("telefone");
                        telefone = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("data de nascimento");
                        dtNascimento = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("login");
                        login1 = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("senha");
                        senha1 = Convert.ToString(Console.ReadLine());


                        break;

                }//fim do switch
            }
        }
    }
}
