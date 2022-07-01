using System;


namespace Processo
{

    class Candidato
    {
        static void Main(string[] args)
        {
            // uma pequena demonstração do que será feita em c#
            // Farei um processo seletivo através das informações do candidato e caso ele se enquadre nos requisitos, imprima a msg para a próxima etapa. caso contrário, desclassificado!

            string situacao;
            string nome;
            string empresa;
            // Declaração das variáveis

            Console.WriteLine("Insira o nome da empresa: "); //Armazenando o dado declarado para a variável "empresa"
            empresa = Console.ReadLine();

            Console.WriteLine("Seja bem vindo a empresa " + empresa.ToUpper()); //concatenando a mensagem registrada junto ao nome da empresa
            Console.WriteLine("");
            Console.WriteLine("Digite seu nome: "); // Nome do candidato
            nome = Console.ReadLine();
            Console.WriteLine("Ola " + nome); // Retorno da mensagem registrada junto ao nome do candidato
            Console.WriteLine("...");
            Console.WriteLine("Você possui experiência na área? (Responda sim ou não): ");
            situacao = Console.ReadLine();

            if (situacao.ToLower() == "sim") //Estrutura condicional. Se, a informação armazenada corresponde com esta condição
            {
                Console.WriteLine("parabéns, você será convocado para a proxima etapa !!");
            }
            else if (situacao.ToLower() == "nao") // Senão se, outro critério definido está de acordo com a condição declarada abaixo!
            {
                Console.WriteLine("Você possui algum conhecimento em linguagem de programação? (Responda sim ou não): ");
                situacao = Console.ReadLine();
                if (situacao.ToLower() == "sim")
                {
                    Console.WriteLine("Parabens, você será convocado para a próxima etapa");
                }
                else //Senão, finalizamos na última condição
                {
                    Console.WriteLine("Infelizmente você não se enquadra nos requisitos da vaga !!!");

                }

            }
        }
    }
}