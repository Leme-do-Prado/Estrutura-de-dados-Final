public Cadastro{
    List<Usuario> usuarios;
    List<Ambiente> ambientes;

    public void adicionarUsuario(Usuario usuario){
        new usuario = Usuario();
        usuarios.add(usuario);
    }

    public bool removerUsuario(Usuario usuario){
        foreach(Usuario u in usuarios){
            int i = 0;
            if(u == usuario){
                usuarios.removeAt(i);
                return true;
            } 
            i++;
        }
    }

    public Usuario pesquisarUsuario(Usuario usuario){
        foreach(Usuario u in usuarios){
            if(u == usuario){
                return u;
            }
        }
    }

    public void adicionarAmbiente(Ambiente ambiente){
        new ambiente = Ambiente();
        ambientes.add(ambiente);
    }

    public bool removerAmbiente(Ambiente ambiente){
        foreach(Ambiente a in ambientes){
            int i = 0;
            if(a == ambiente){
                ambientes.removeAt(i);
                return true;
            }
            i++;
        }
    }

    public Ambiente pesquisarAmbiente(Ambiente ambiente){
        foreach(Ambiente a in ambientes){
            if(a == ambiente){
                return a;
            }
        }
    }
}
