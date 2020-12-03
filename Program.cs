using System;
using POOAlunos.classes;

namespace POOAlunos
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno();
            Console.WriteLine("Digite o nome do aluno:");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno:");
            aluno1.curso = Console.ReadLine();
            
            Console.WriteLine("Digite o RG do aluno:");
            aluno1.rg = Console.ReadLine();
            
            Console.WriteLine("Digite a idade do aluno:");
            aluno1.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a média final do aluno:");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da mensalidade:");
            aluno1.valorMensalidade = float.Parse(Console.ReadLine());
            
            Console.WriteLine("O aluno é bolsista? s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                aluno1.bolsista = true;
            }else{
                aluno1.bolsista = false;
            }

            //Menu
               int opcao;

            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Ver média do aluno"); 
                Console.WriteLine("[2] - Ver mensalidade do aluno"); 
                Console.WriteLine("[0] - Sair"); 

            } while (opcao != 0);

            
            switch (opcao)
            {
                case 1:
                Console.WriteLine($"A média final do aluno{aluno1.nome} = {aluno1.verMediaAluno()}");
                    break;

                case 2:
                Console.WriteLine($"O valor da mensalidade do aluno fica em: {aluno1.verMensalidade()}");
                    break;

                case 0:
                Console.WriteLine("Obrigado por acessar");  
                    break;      
                default:
                Console.WriteLine("Opção inválida!");
                    break;
            }while (opcao != 0);
            
            

        }
    }
}
