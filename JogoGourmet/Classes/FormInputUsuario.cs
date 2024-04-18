namespace JogoGourmet.Classes;
public class FormInputUsuario
{
    public static string MostrarCaixaDialogo(string texto, string caption)
    {
        using (Form formulario = CriarFormulario(caption))
        {
            Control[] inputUsuario = CriarControles(formulario, texto);

            formulario.Controls.AddRange(inputUsuario);

            return formulario.ShowDialog() == DialogResult.OK ?
                inputUsuario[1].Text : "";
        }
    }

    private static Form CriarFormulario(string caption) => new()
    {
        Width = 500,
        Height = 180,
        FormBorderStyle = FormBorderStyle.FixedDialog,
        Text = caption,
        StartPosition = FormStartPosition.CenterScreen
    };

    private static Control[] CriarControles(Form form, string texto)
    {
        Label LblInputUsuario = new()
        {
            Text = texto,
            Left = 50,
            Top = 20,
            AutoSize = true
        };

        TextBox TxtInputUsuario = new()
        {
            Left = 50,
            Top = 50,
            Width = 400
        };

        Button btnConfirmacao = new()
        {
            Text = "Ok",
            Left = 350,
            Height = 30,
            Width = 100,
            Top = 90,
            DialogResult = DialogResult.OK
        };

        btnConfirmacao.Click += (sender, e) => { form.Close(); };

        form.AcceptButton = btnConfirmacao;

        return [LblInputUsuario, TxtInputUsuario, btnConfirmacao];
    }
}
