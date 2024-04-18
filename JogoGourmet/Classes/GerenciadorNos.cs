namespace JogoGourmet.Classes;
internal class GerenciadorNos(string noRaiz)
{
    internal string nome { get; set; } = noRaiz;
    internal GerenciadorNos? posicaoAnterior { get; set; }
    internal GerenciadorNos? seguinte { get; set; }
    internal void DeterminarNoAnterior(GerenciadorNos no)
        => posicaoAnterior = no;
    internal void DeterminarNoSeguinte(GerenciadorNos no)
        => seguinte = no;
}
