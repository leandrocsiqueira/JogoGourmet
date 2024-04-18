
namespace JogoGourmet.Classes;
internal class GerenciadorArvore
{
    internal GerenciadorNos? raiz { get; private set; }
    internal void DefinirNoRaiz(string raiz) => this.raiz ??= new(raiz);
    internal static void IncluirNo(GerenciadorNos? raiz, string nome,
        Posicionamento posicao)
    {
        if (raiz is null) return;

        GerenciadorNos novoNo = new(nome);

        if (posicao == Posicionamento.ladoEsquerdo)
        {
            raiz.DeterminarNoAnterior(novoNo);
        }
        else
        {
            raiz.DeterminarNoSeguinte(novoNo);
        }
    }
}
