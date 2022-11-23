public Program{
    public static void Main(String[] args){
        Console.WriteLine("0. Sair");
        Console.WriteLine("1. Cadastrar ambiente")
        Console.WriteLine("2. Consultar ambiente");
        Console.WriteLine("3. Excluir ambiente");
        Console.WriteLine("4. Cadastrar usuario");
        Console.WriteLine("5. Consultar usuario");
        Console.WriteLine("6. Excluir usuario");
        Console.WriteLine("7. Conceder permissão de acesso ao usuario (informar ambiente e usuário - vincular ambiente ao usuário)");
        Console.WriteLine("8. Revogar permissão de acesso ao usuario (informar ambiente e usuário - desvincular ambiente do usuário)");
        Console.WriteLine("9. Registrar acesso (informar o ambiente e o usuário - registrar o log respectivo)");
        Console.WriteLine("10. Consultar logs de acesso (informar o ambiente e listar os logs - filtrar por logs autorizados/negados/todos)");

        int c = Console.ReadInt();
        Switch(c){
            case 0;
            Application.Exit();
            break;
            case 1;
            break;
            case 2;
            break;
            case 3;
            break;
            case 4;
            break;
            case 5;
            break;
            case 6;
            break;
            case 7;
            break;
            case 8;
            break;
            case 9;
            break;
            case 10;
            break;
        }
    }
}
