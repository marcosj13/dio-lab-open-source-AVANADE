
TaskSchedulerApp


🗓 Sistema de Agendamento de Tarefas
Feito em C# com Entity Framework Core
Autor: Marcos José da Silva


Descrição:
------------
TaskSchedulerApp é um sistema de console interativo
para gerenciar tarefas do dia a dia. Permite criar,
listar e concluir tarefas, mantendo todas salvas
automaticamente em banco SQLite.

Funcionalidades:
-----------------
1. Adicionar Tarefa
   - Título
   - Descrição
   - Data de agendamento

2. Listar Tarefas
   - Visualiza todas as tarefas cadastradas
   - Mostra status: Concluída ou Pendente

3. Concluir Tarefa
   - Marca uma tarefa como concluída

4. Persistência de Dados
   - Todas as tarefas são salvas em banco SQLite

Tecnologias Utilizadas:
-----------------------
- C# (.NET 7/8)
- Entity Framework Core
- SQLite
- Console App

Como Usar:
-----------
1. Clone o repositório

2. Entre na pasta do projeto:
   cd TaskSchedulerApp

3. Instale os pacotes do Entity Framework Core:
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.Sqlite

4. Execute o projeto:
   dotnet run

5. Siga as instruções do menu para gerenciar suas tarefas.

Estrutura do Projeto:
---------------------
TaskSchedulerApp/
│
├── Program.cs           # Menu interativo e execução principal
├── Tarefa.cs            # Modelo da Tarefa
├── TarefaContext.cs     # Contexto do Entity Framework
├── tarefas.db           # Banco SQLite gerado automaticamente
└── README.cs            # Este arquivo

Próximos Passos e Melhorias:
-----------------------------
- Adicionar prioridade e tags para tarefas
- Implementar alertas e notificações
- Filtros por data, prioridade ou categoria
- Evoluir para interface gráfica (WPF ou Blazor)
- Exportação de tarefas para CSV ou PDF

Observações:
-------------
- Código modular e expansível
- Ótimo para aprendizado de CRUD, EF Core e persistência em SQLite
- Fácil de adaptar para interface gráfica e novas funcionalidades

