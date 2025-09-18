using System;

namespace TaskSchedulerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new TarefaContext();
            context.Database.EnsureCreated(); // Cria o banco se não existir

            bool executar = true;

            while (executar)
            {
                Console.WriteLine("\n--- Sistema de Agendamento de Tarefas ---");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Concluir Tarefa");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarTarefa(context);
                        break;
                    case "2":
                        ListarTarefas(context);
                        break;
                    case "3":
                        ConcluirTarefa(context);
                        break;
                    case "4":
                        executar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void AdicionarTarefa(TarefaContext context)
        {
            Console.Write("Título da tarefa: ");
            string titulo = Console.ReadLine();
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Data de agendamento (yyyy-mm-dd hh:mm): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            var tarefa = new Tarefa { Titulo = titulo, Descricao = descricao, DataAgendada = data, Concluida = false };
            context.Tarefas.Add(tarefa);
            context.SaveChanges();

            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        static void ListarTarefas(TarefaContext context)
        {
            var tarefas = context.Tarefas.ToList();
            Console.WriteLine("\n--- Lista de Tarefas ---");
            foreach (var t in tarefas)
            {
                Console.WriteLine($"ID: {t.TarefaId} | {t.Titulo} | {t.Descricao} | Agendada para: {t.DataAgendada} | Concluída: {t.Concluida}");
            }
        }

        static void ConcluirTarefa(TarefaContext context)
        {
            Console.Write("Digite o ID da tarefa para concluir: ");
            int id = int.Parse(Console.ReadLine());
            var tarefa = context.Tarefas.Find(id);

            if (tarefa != null)
            {
                tarefa.Concluida = true;
                context.SaveChanges();
                Console.WriteLine("Tarefa concluída!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }
    }
}
