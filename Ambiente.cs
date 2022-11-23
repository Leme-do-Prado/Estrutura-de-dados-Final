public Ambiente{
    int id;
    string nome;
    Queue<Log> logs;

    Ambiente(int id, string nome){
        this.id = id;
        this.nome = nome;
    }

    public void registrarLog(Log log){
        new log = Log();
        logs.enqueue(log);
            }   
}
