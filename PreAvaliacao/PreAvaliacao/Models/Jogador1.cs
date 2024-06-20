namespace PreAvaliacao.Models;

public class Jogador1 
{
	public int Pontos { get; set; }
	public string Sorteio { get; set; }
    private int temp { get; set; }

    public Jogador1()
    {
        Pontos = 0;
    }

    public void Escolhrer(String escolha)
    {
        Sorteio = escolha;
    }


    public void Jogar()
	{
        Random rnd = new Random();
        temp = rnd.Next(3);
        if (temp == 1)
        {
            Sorteio = "Pedra";
        }
        else if (temp == 2)
        {
            Sorteio = "Papel";
        }
        else
        {
            Sorteio = "Tesoura";
        }
        this.Escolhrer(Sorteio);
    }
}