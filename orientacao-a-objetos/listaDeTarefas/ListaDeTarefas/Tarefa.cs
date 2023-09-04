namespace ListaDeTarefas
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; }
        public bool Concluida { get; private set; }

        public Tarefa(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }

        public void Concluir()
        {
            Concluida = true;
        } 

        public override string ToString()
        {
            if (Concluida)
            {
                return $"- ({Id}) {Nome} [X]";
            }
            return $"- ({Id}) {Nome} [ ]";
        }
    }
}
