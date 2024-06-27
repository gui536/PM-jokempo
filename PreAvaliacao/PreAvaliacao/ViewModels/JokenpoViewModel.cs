using CommunityToolkit.Mvvm.ComponentModel;
using PreAvaliacao.Models;

namespace PreAvaliacao.ViewModels;

//Classe não herda ContentPage, herda ObservableObject
public partial class JokenpoViewModel : ObservableObject
{

    [ObservableProperty]
    private string result;

    [ObservableProperty]
    private string escolha;

    [ObservableProperty]
    private int pontuacaoJogador;

    [ObservableProperty]
    private int pontuacaoComputador;

    //Implementar o construtor
    //Implementar o jogar command

    //Verificar o nome dos métodos
    public void Joagr()
    {
        Jogador1 jogador = new Jogador1();
        Jogador1 pc = new Jogador1();
        jogador.Jogar();

        if (Escolha == "pedra" && jogador.Sorteio == "tesoura" || Escolha == "papel" && jogador.Sorteio == "pedra" || Escolha == "tesoura" && jogador.Sorteio == "papel")
        {
            result = "Você ganhou";
            jogador.Pontos++;
        }
        else
        {
            result = "Você perdeu";
            pc.Pontos++;
        }
    }
}