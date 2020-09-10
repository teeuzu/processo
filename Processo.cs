using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Princeso
{

      class Princeso
    {
     static void Main (string [] args)
        {
        // uma pequena demonstração do que será feita em c#
        // Farei um processo seletivo através das informações do candidato e caso ele se enquadre nos requisitos, imprima a msg para a próxima etapa. caso contrário, desclassificado!
       
       string situacao;
       string nome;
       
     
       Console.WriteLine ("Seja bem vindo a empresa x ");
       Console.WriteLine("");
       Console.WriteLine ("Digite seu nome: ");
      nome = Console.ReadLine ();
      Console.WriteLine ("Ola " + nome );
      Console.WriteLine("...");
      Console.WriteLine("Você possui experiência na área? ");
      situacao = Console.ReadLine();
      
      if (situacao.ToLower() == "sim")
      {
      	Console.WriteLine ("parabéns, você será convocado para a proxima etapa !!");
      }
      else 	if (situacao.ToLower() == "nao")
      	{
      	Console.WriteLine("Você possui algum conhecimento em linguagem de programação?");
      	situacao = Console.ReadLine();
      	if (situacao.ToLower() == "sim")
      	{
      	Console.WriteLine("Parabens, você será convocado para a próxima etapa");
      	}
      	else
      	{
      		      	Console.WriteLine ("Infelizmente você não se enquadra nos requisitos da vaga !!!");

      	}
      	
        }
    }
}
}
