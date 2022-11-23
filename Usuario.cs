public Usuario{
    int id;
    string nome;
    List<Ambiente> ambientes;

    public bool concederPermissao(Ambiente ambiente){
        ambiente.setTipoAcesso(true);
    }

    public bool revogarPermissao(Ambiente ambiente){
        ambiente.setTipoAcesso(false);
    }
}
