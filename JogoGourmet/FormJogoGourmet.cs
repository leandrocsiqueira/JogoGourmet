using JogoGourmet.Classes;
namespace JogoGourmet;
internal partial class FormJogoGourmet : Form
{
    private readonly Jogo _jogo;
    public FormJogoGourmet()
    {
        InitializeComponent();
        _jogo = new();
    }

    private void BtnFormJogoGourmet_Click(object sender, EventArgs e)
    {
        _jogo.Rodar();
    }
}
