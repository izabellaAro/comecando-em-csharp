using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTarefas
{
    public class ListaDeTarefa
    {
        public List<Tarefa> Tarefas { get; set; }

        public ListaDeTarefa() 
        {
            Tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(string nomeTarefa)
        {
            Tarefa tarefa = new Tarefa(nomeTarefa, Tarefas.Count + 1);
            Tarefas.Add(tarefa);
        }

        public void ExibirTarefas()
        {
            foreach (Tarefa tarefa in Tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }

        public bool ConcluirTarefa(int idTarefaConcluir)
        {
            Tarefa? aTarefaConcluir = ObterTarefaPorId(idTarefaConcluir);
            if (aTarefaConcluir == null)
            {
                return false;

            }
            aTarefaConcluir.Concluir();
            return true;
        }

        private Tarefa? ObterTarefaPorId(int idTarefaConcluir)
        {
            return Tarefas.FirstOrDefault(X => X.Id == idTarefaConcluir);
        }

        public bool ExcluirTarefa(int idTarefaExcluir)
        {
            var aTarefaExcluir = ObterTarefaPorId(idTarefaExcluir);

            if (aTarefaExcluir == null)
            {
                return false;
            }
            Tarefas.Remove(aTarefaExcluir);
            return true;
        }
    }
}
