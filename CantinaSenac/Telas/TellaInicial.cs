public class TelaInicial: ITela {
    public TelaInicial(){
        ExibirTela();    
    }
    
    public void ExibirTela() {
        string nomeUsuario;
 
        System.Console.WriteLine("Olá seja bem vindo(a) ao Portal Cantina Senac - digite 1 para se cadastrar, e caso jã tenha cadastro digite 2 para logar\n");
        int escolha = int.Parse(Console.ReadLine());
        if (escolha == 1) {
            new TelaCadastroAdministrador();
        } else{
            new TelaLogin();
        }

    }
}