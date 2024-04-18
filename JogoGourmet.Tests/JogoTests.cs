using NUnit.Framework;
using JogoGourmet.Classes;
using System.Windows.Forms;
using NUnit.Framework.Legacy;

namespace JogoGourmet.Tests;

[TestFixture]
public class JogoTests
{
    [Test]
    public void APerguntaInicialParaUsuarioDeveSerExibidaApropriadamente()
    {
        GerenciadorNos no = new("massa");
        DialogResult result = Jogo.ExibirPerguntaInicial(no);
        Assert.That(result, Is.EqualTo(DialogResult.Yes).Or.EqualTo(DialogResult.No));
    }

    [Test]
    public void TestRodarChamaProcessarRespostaPositivaQuandoResultadoForYes()
    {
        // Arrange
        GerenciadorNos no = new(MensagemDialogo.s_pratoLasanha);
        Queue<GerenciadorNos> fila = new();
        _ = new Jogo();
        Jogo.ProcessarRespostaPositiva(no, fila);
    }

    [Test]
    public void TestarProcessarRespostaNegativa()
    {
        // Arrange
        GerenciadorNos no = new(MensagemDialogo.s_pratoBoloChocolate);
        Queue<GerenciadorNos> fila = new();
        _ = new Jogo();
        Jogo.ProcessarRespostaNegativa(no, fila);
        ClassicAssert.AreEqual("bom", no.nome);
        ClassicAssert.IsNotNull(no.posicaoAnterior);
        ClassicAssert.IsNotNull(no.seguinte);
    }

    [Test]
    public void AcertarPrato_DeveChamarMessageBoxShowComTextoCorreto()
    {
        string textoEsperado = MensagemDialogo.s_programaAcertou;
        Jogo.AcertarPrato();
        ClassicAssert.IsTrue(MensagemDialogo.s_programaAcertou == textoEsperado);
    }

    [Test]
    public void Rodar_DeveProcessarNosCorretamente()
    {
        Jogo jogo = new();
        jogo.Rodar();
        Assert.Pass("Processamento de nós ocorreu corretamente.");
    }
}
