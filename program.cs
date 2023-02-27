using System;
namespace Atividade
{
class Program
{
static void Main (string[] args){float val_pag;
Console.WriteLine("Informe Nome");
string var_nome = Console.ReadLine();
Console.WriteLine("Informe Endereço");
string var_endereco = Console.ReadLine();
Console.WriteLine("Pessoa Física (f) ou Pessoa Jurídica (j) ?");
string var_tipo = Console.ReadLine();
if(var_tipo == "f")
{
// --- Pessoa Física ----
pessoa_fisica pf = new pessoa_fisica();
pf.nome = var_nome;
pf.endereco = var_endereco;
Console.WriteLine("Informar CPF:");
pf.cpf = Console.ReadLine();
Console.WriteLine("Informar RG:");
pf.rg = Console.ReadLine();
Console.WriteLine("Informar Valor de Compra:");
val_pag = float.Parse(Console.ReadLine());
pf.Pagar_Imposto(val_pag);
Console.WriteLine("-------- Pessoa Física ---------");
Console.WriteLine("Nome ..........: " + pf.nome);
Console.WriteLine("Endereço ......: " + pf.endereco);
Console.WriteLine("CPF ...........: " + pf.cpf);
Console.WriteLine("RG ............: " + pf.rg);
Console.WriteLine("Valor de Compra: " +
pf.valor.ToString("C"));
Console.WriteLine("Imposto .......: " +
pf.valor_imposto.ToString("C"));
Console.WriteLine("Total a Pagar : " +
pf.total.ToString("C"));
}
if(var_tipo == "j")
{
}
}
}
}
