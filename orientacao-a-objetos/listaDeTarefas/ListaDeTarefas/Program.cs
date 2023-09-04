using ListaDeTarefas;

var listaDeTarefas = new ListaDeTarefa();

listaDeTarefas.AdicionarTarefa("teste00");
listaDeTarefas.AdicionarTarefa("teste01");

ExibirMenu();

void ExibirMenu() 
{
    Console.Clear();
    Console.WriteLine("Seja bem vindo! Crie sua lista de tarefas :) \n");
    Console.WriteLine("Menu de opções:\n");
    Console.WriteLine("1 - Adicionar tarefa a lista");
    Console.WriteLine("2 - Lista de tarefas");
    Console.WriteLine("3 - Remover tarefa da lista");
    Console.WriteLine("4 - Concluir tarefa da lista");
    Console.WriteLine("0 - Sair \n");
    int opcaoEscolhida = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Adicione tarefas em sua lista: \n");
            string nomeAtividade = Console.ReadLine();
            listaDeTarefas.AdicionarTarefa(nomeAtividade);
            ExibirMenu();
            break;

        case 2:
            Console.WriteLine("Sua lista de tarefas:\n ");

            listaDeTarefas.ExibirTarefas();

            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu.");
            Console.ReadLine();

            ExibirMenu();
            break;

        case 3:
            ExcluirTarefa();
            break;

        case 4:
            ConcluirTarefa();
            break;

        case 0:
            Console.WriteLine("Tchau! Até logo :)");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            Thread.Sleep(4000);
            ExibirMenu();
            break;
    }
}

void ExcluirTarefa()
{
    Console.WriteLine("Suas tarefas: \n");

    listaDeTarefas.ExibirTarefas();

    Console.WriteLine("\nQual o número da tarefa deseja excluir?\n");
    string idTarefaExcluir = Console.ReadLine();

    bool tarefaExcluida = listaDeTarefas.ExcluirTarefa(int.Parse(idTarefaExcluir));

    if (tarefaExcluida == false)
    {
        Console.WriteLine("\nTarefa não encontrada. Tente novamente\n");
        ExcluirTarefa();
    }

    Console.WriteLine("\nTarefa excluída com sucesso da sua lista!");

    Thread.Sleep(4000);
    ExibirMenu();
}

void ConcluirTarefa()
{

    Console.WriteLine("Suas tarefas: \n");

    listaDeTarefas.ExibirTarefas();

    Console.WriteLine("\nQual o número da tarefa deseja marcar como concluída?\n");
    string idTarefaConcluir = Console.ReadLine();

    bool tarefaConcluida = listaDeTarefas.ConcluirTarefa(int.Parse(idTarefaConcluir));

    if (tarefaConcluida == false)
    {
        Console.WriteLine("\nTarefa não encontrada. Tente novamente.\n");
        ConcluirTarefa();
    }
    
    Console.WriteLine("\nAtualização de tarefa realizada com sucesso!");

    Thread.Sleep(4000);
    ExibirMenu();
}