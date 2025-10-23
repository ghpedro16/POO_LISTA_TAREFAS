// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var tarefa01 = new Tarefa();

tarefa01.Nome = "Fazer compras";
tarefa01.Descricao = "Comprar arroz, feijão e frutas";
tarefa01.DataCriacao = DateTime.Now;
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Inserindo dados no banco de dados!");

var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: {idInserido}");

tarefa01.Nome = "Fazer compras";
tarefa01.Descricao = "Comprar comida para o meu gato";
tarefa01.DataCriacao = DateTime.Now;
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Atualizando dados no banco de dados!");

operacoes.Alterar(tarefa01);

operacoes.Excluir(tarefa01.Id);
Console.WriteLine($"Dados excluidos no banco de dados com sucesso. Id: {tarefa01.Id}");