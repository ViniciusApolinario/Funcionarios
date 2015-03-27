using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    public class Funcionario
    {
       public string NomeCompleto;
       public string Idade;
       public string Genero;
       public string CPF;
       public string salario;
       public string NumeroDeFilhos;
       public string Profissao;
       public string Email;
       public string Telefone;
       public string Endereco;
       public string sangue;
       public string[] all = new string[12];

       public void addInform()
       {
               all[0] = NomeCompleto;
               all[1] = Idade;
               all[2] = Genero;
               all[3] = CPF;
               all[4] = salario;
               all[5] = NumeroDeFilhos;
               all[6] = Profissao;
               all[7] = Email;
               all[8] = Telefone;
               all[9] = Endereco;
               all[10] = sangue;
               File.WriteAllLines(@"c:\users\yago.melo\desktop\test.txt", all);
           
       }

       public void Funcionario(string _NomeCompleto, string _Idade, string _Genero, string _CPF, string _salario, string _NumeroDeFilhos, string _Profissao, string _Email ,
           string _Telefone, string _Endereço, string _sangue)
       {
           NomeCompleto = _NomeCompleto;
           Idade = _Idade;
           Genero = _Genero;
           CPF = _CPF;
           salario = _salario;
           NumeroDeFilhos = _NumeroDeFilhos;
           Profissao = _Profissao;
           Email = _Email;
           Telefone = _Telefone;
           Endereco = _Endereço;
           sangue = _sangue;
       }
 
    }
}
