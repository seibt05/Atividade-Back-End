using System;

namespace Aplicação
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Pessoa Física (f) ou Pessoa Jurídica (j): ");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();

                System.Console.WriteLine("Informar o nome: ");
                pf.nome = Console.ReadLine();

                System.Console.WriteLine("Informar o endereço: ");
                pf.endereco = Console.ReadLine();

                System.Console.WriteLine("Informar o CPF: ");
                pf.cpf = Console.ReadLine();

                System.Console.WriteLine("Informar o RG: ");
                pf.rg = Console.ReadLine();

                System.Console.WriteLine("Informar o valor: ");
                float val_pag = float.Parse(Console.ReadLine());

                pf.Pagar_Imposto(val_pag);

                System.Console.WriteLine("Nome: " + pf.nome);
                System.Console.WriteLine("Endereço: " + pf.endereco);
                System.Console.WriteLine("CPF: " + pf.cpf);
                System.Console.WriteLine("RG: " + pf.rg);
                System.Console.WriteLine("Valor: " + pf.valor);
                System.Console.WriteLine("Valor do Imposto: " + pf.valor_imposto);
                System.Console.WriteLine("Total: " + pf.total);
            }
            else if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();

                System.Console.WriteLine("Informar o nome: ");
                pj.nome = Console.ReadLine();

                System.Console.WriteLine("Informar o endereço: ");
                pj.endereco = Console.ReadLine();

                System.Console.WriteLine("Informar o CNPJ: ");
                pj.CNPJ = Console.ReadLine();

                System.Console.WriteLine("Informar a Inscrição Estadual: ");
                pj.ie = Console.ReadLine();

                System.Console.WriteLine("Informar o valor: ");
                float val_pag = float.Parse(Console.ReadLine());

                pj.Pagar_Imposto(val_pag);

                System.Console.WriteLine("Nome: " + pj.nome);
                System.Console.WriteLine("Endereço: " + pj.endereco);
                System.Console.WriteLine("CNPJ: " + pj.CNPJ);
                System.Console.WriteLine("Inscrição Estadual: " + pj.ie);
                System.Console.WriteLine("Valor: " + pj.valor);
                System.Console.WriteLine("Valor do Imposto: " + pj.valor_imposto);
                System.Console.WriteLine("Total: " + pj.total);
            }
            else
            {
                System.Console.WriteLine("Tipo de pessoa inválido");
            }
        }
    }
}
