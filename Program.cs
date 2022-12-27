using EFCoreExample.Contexts;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

var db = new AppDbContext();

var cliente = new Cliente
{
    Name = "Cleyson Lima",
    Cpf = "123.456.789.12",
    Endereco = new Endereco
    {
        Estado = "SP",
        Cidade = "São Paulo",
        Bairro = "Cerqueira César",
        Logradouro = "Travessa Alcides Cyrillo",
        Numero = "338",
        ClienteId = 1
    }
};
db.Add(cliente);
db.SaveChanges();


/*#########################################################################*/
/* cadastrando entidades com relacionamento 1:1 */
/* var endereco = new Endereco
{
    Estado = "DF",
    Cidade = "Brasília",
    Bairro = "Taguatinga Norte",
    Logradouro = "CNB 10 lote 03",
    Numero = "s/n",
    ClienteId = 1
};
db.Add(endereco);
db.SaveChanges(); */

/*
// outra maneira de fazer é assim:
var cliente = new Cliente
{
    Name = "Cleyson Lima",
    Cpf = "123.456.789.12",
    Endereco = new Endereco
    {
        Estado = "SP",
        Cidade = "São Paulo",
        Bairro = "Cerqueira César",
        Logradouro = "Travessa Alcides Cyrillo",
        Numero = "338",
        ClienteId = 1
    }
};
db.Add(cliente);
db.SaveChanges();
*/

/*#########################################################################*/
/* DELETAR REGISTROS */

/*
var cliente = db.Clientes.First();
db.Remove(cliente);
db.SaveChanges();
*/
/*
var cliente = db.Clientes.Find(1);
db.Remove(cliente);
db.SaveChanges();
*/
/*
var cliente = new Cliente { Id = 2 };
db.Remove(cliente);
db.SaveChanges();
*/

/*#########################################################################*/
/* ATUALIZAR REGISTROS */
/*
var cliente = db.Clientes.Find(1);
cliente.Cpf = "123.456.789-10";
db.SaveChanges();
*/

/*
// essa maneira é recomandada para API REST, pois já recebe na request todos os dados e não precisa consultar antes
var cliente = new Cliente
{
    Id = 2,
    Name = "João Ninguém editado",
    Cpf = "987.654.321-01"
};
db.Update(cliente);
db.SaveChanges();
*/

/*
var cliente = new Cliente
{
    Id = 2,
    Name = "João Ninguém",
    Cpf = "987.654.321-01"
};
db.Entry(cliente).State = EntityState.Modified;
db.SaveChanges();
*/

/*#########################################################################*/
/* CONSULTAR REGISTROS */
/*
// listar tudo!
foreach (var cliente in db.Clientes)
{
    Console.WriteLine(cliente);
}*/
/*
// consultar pelo Id
var cliente = db.Clientes.Find(1);
Console.WriteLine(cliente);
*/

/*
// consulta pelo nome, retornando todos os campos
var cliente = db.Clientes.Where(x => x.Name.Contains("John")).SingleOrDefault();
Console.WriteLine(cliente);

// consulta pelo nome, retornando somente o nome
var cliente2 = db.Clientes
    .Where(x => x.Name.Contains("John"))
    .Select(x => x.Name)
    .SingleOrDefault();

Console.WriteLine(cliente2);
*/

/*#########################################################################*/
/* INSERIR REGISTRO */
/*
var cliente = new Cliente
{
    Name = "John Doe",
    Cpf = "123.456.789.10"
};
db.Add(cliente);
db.SaveChanges();
*/

/*
var cliente1 = new Cliente
{
    Name = "Zé Ninguém",
    Cpf = "123.456.789.10"
};
var cliente2 = new Cliente
{
    Name = "Maria José",
    Cpf = "123.456.789.10"
};
db.AddRange(cliente1, cliente2);
db.SaveChanges();
*/