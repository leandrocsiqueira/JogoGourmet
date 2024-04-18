using NUnit.Framework;
using JogoGourmet.Classes;
using NUnit.Framework.Legacy;

namespace JogoGourmet.Tests;

[TestFixture]
internal class GerenciadorArvoreTests
{
    [Test]
    public void ConstrutorDeveConfigurarDado()
    {
        string noRaiz = "nome";
        GerenciadorNos no = new(noRaiz);
        Assert.That(no.nome, Is.EqualTo(noRaiz));
    }

    [Test]
    public void DeveSerPossivelIncluirUmNoAoLadoDireitodoNoCorrente()
    {
        GerenciadorNos no = new("nome");
        GerenciadorNos noPosterior = new("seguinte");

        no.DeterminarNoSeguinte(noPosterior);

        // Assert
        Assert.That(no.seguinte, Is.EqualTo(noPosterior));
    }

    [Test]
    public void UmNoDeveConseguirSerDefinidoAdequadamente()
    {
        GerenciadorArvore gerenciador = new();
        gerenciador.DefinirNoRaiz("Raiz");
        ClassicAssert.IsNotNull(gerenciador.raiz);
        ClassicAssert.AreEqual("Raiz", gerenciador.raiz?.nome);
    }

    [Test]
    public void DeveSerPossivelIncluirUmNoAoLadoEsquerdodoNoCorrente()
    {
        GerenciadorNos raiz = new("Raiz");
        GerenciadorArvore.IncluirNo(raiz, "Filho", Posicionamento.ladoEsquerdo);
        ClassicAssert.IsNotNull(raiz.posicaoAnterior);
        ClassicAssert.AreEqual("Filho", raiz.posicaoAnterior?.nome);
    }
} 
