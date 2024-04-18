using JogoGourmet.Classes;
using NUnit.Framework;

namespace JogoGourmet.Tests;

[TestFixture]
internal class FormInputUsuarioTests
{
    [Test]
    public void DeveSerPossivelExibirACaixaDeDialogoParaUsuarioFornecerDados()
    {
        string texto = "Teste de texto";
        string caption = "Teste de caption";
        FormInputUsuario.MostrarCaixaDialogo(texto, caption);
        Assert.Pass("O método MostrarCaixaDialogo foi chamado corretamente.");
    }
}
