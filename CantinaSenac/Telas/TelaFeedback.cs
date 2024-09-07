public class TelaFeedback : ITela
{
    public TelaFeedback()
    {
        ExibirTela();
    }
    public void ExibirTela()
    {
        string feedback;
        System.Console.WriteLine("Digite seu feedback\n");
        feedback = Console.ReadLine();
       
    }
}