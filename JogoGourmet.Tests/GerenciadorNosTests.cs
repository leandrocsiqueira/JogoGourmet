using JogoGourmet.Classes;
using NUnit.Framework;

namespace JogoGourmet.Tests;

[TestFixture]
public class GerenciadorNosTests
{
    [Test]
    public void NosDevemConseguirSerConfiguradosAdequadamente()
    {
        string noRaiz = "nome";
        GerenciadorNos no = new("nome");
        Assert.That(no.nome, Is.EqualTo(noRaiz));
    }

    [Test]
    public void DeveSerPossivelDeterminarONoAnteriorAoCorrente()
    {
        GerenciadorNos no = new("nome");
        GerenciadorNos noAnterior = new("posicaoAnterior");
        no.DeterminarNoAnterior(noAnterior);
        Assert.That(no.posicaoAnterior, Is.EqualTo(noAnterior));
    }

    [Test]
    public void DeveSerPossivelDeterminarONoPosteriorAoCorrente()
    {
        GerenciadorNos no = new("nome");
        GerenciadorNos noPosterior = new("seguinte");
        no.DeterminarNoSeguinte(noPosterior);
        Assert.That(no.seguinte, Is.EqualTo(noPosterior));
    }


}
