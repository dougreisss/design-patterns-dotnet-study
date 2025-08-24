namespace Bridge;

public class JanelaDialogo : JanelaAbstrata
{
    public JanelaDialogo(IJanelaBridge janela) : base(janela) { }

    public override void desenhar()
    {
        desenharJanela("Salvar?");
        desenharBotao("Sim");
        desenharBotao("Não");
    }
}
