namespace JogoGourmet.Classes;
internal class Jogo
{
    internal readonly GerenciadorArvore _no;
    internal Jogo()
    {
        _no = new();
        _no.DefinirNoRaiz("Massa");

        GerenciadorArvore.IncluirNo(_no.raiz,
            MensagemDialogo.s_pratoLasanha, Posicionamento.ladoEsquerdo);

        GerenciadorArvore.IncluirNo(_no.raiz,
            MensagemDialogo.s_pratoBoloChocolate, Posicionamento.ladoDireito);
    }

    internal static DialogResult ExibirPerguntaInicial(GerenciadorNos no)
        => MessageBox.Show(text: MensagemDialogo.s_perguntaInicial
            .Replace("$", no.nome), caption: MensagemDialogo.s_confirmacao,
            buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);

    internal static void ProcessarRespostaPositiva(GerenciadorNos no,
        Queue<GerenciadorNos> fila)
    {
        if (no.posicaoAnterior is null)
        {
            AcertarPrato();
        }
        else
        {
            fila.Enqueue(no.posicaoAnterior);
        }
    }

    internal static void ProcessarRespostaNegativa(GerenciadorNos no,
        Queue<GerenciadorNos> fila)
    {
        if (no.seguinte is null)
        {
            string nome = FormInputUsuario.MostrarCaixaDialogo(
                texto: MensagemDialogo.s_pratoPensado,
                caption: MensagemDialogo.s_tituloFormDesistencia);

            string caracteristicaPrato = FormInputUsuario
                .MostrarCaixaDialogo(texto: MensagemDialogo.s_fraseComLacuna
                .Replace("$1", nome)
                .Replace("$2", no.nome),
                caption: MensagemDialogo.s_mensagemInput);

            no.nome = caracteristicaPrato;

            GerenciadorArvore.IncluirNo(no, nome,
                Posicionamento.ladoEsquerdo);
            GerenciadorArvore.IncluirNo(no, no.nome,
                Posicionamento.ladoDireito);
        }
        else
        {
            fila.Enqueue(no.seguinte);
        }
    }

    internal static void AcertarPrato() => _ = MessageBox.Show(
            text: MensagemDialogo.s_programaAcertou,
            caption: MensagemDialogo.s_tituloDoJogo,
            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

    internal void Rodar()
    {
        Queue<GerenciadorNos> gerenciadorNos = new();
        GerenciadorNos? raiz = _no.raiz;

        if (raiz is not null)
        {
            gerenciadorNos.Enqueue(raiz);
        }

        while (gerenciadorNos.Count > 0)
        {
            GerenciadorNos noCorrente = gerenciadorNos.Dequeue();

            DialogResult resultado = ExibirPerguntaInicial(noCorrente);

            if (resultado == DialogResult.Yes)
            {
                ProcessarRespostaPositiva(noCorrente, gerenciadorNos);
            }
            else if (resultado == DialogResult.No)
            {
                ProcessarRespostaNegativa(noCorrente, gerenciadorNos);
            }
        }
    }       
}
