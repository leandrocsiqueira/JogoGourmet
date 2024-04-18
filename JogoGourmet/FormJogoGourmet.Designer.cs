namespace JogoGourmet
{
    partial class FormJogoGourmet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogoGourmet));
            PnlFormJogoGourmet = new Panel();
            BtnFormJogoGourmet = new Button();
            LblMensagemInicial = new Label();
            PnlFormJogoGourmet.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFormJogoGourmet
            // 
            PnlFormJogoGourmet.AccessibleDescription = "Painel do formulário Jogo Gourmet";
            PnlFormJogoGourmet.AccessibleName = "PainelFormulario";
            PnlFormJogoGourmet.Controls.Add(BtnFormJogoGourmet);
            PnlFormJogoGourmet.Controls.Add(LblMensagemInicial);
            PnlFormJogoGourmet.Location = new Point(0, 0);
            PnlFormJogoGourmet.Name = "PnlFormJogoGourmet";
            PnlFormJogoGourmet.Size = new Size(499, 202);
            PnlFormJogoGourmet.TabIndex = 0;
            // 
            // BtnFormJogoGourmet
            // 
            BtnFormJogoGourmet.FlatStyle = FlatStyle.System;
            BtnFormJogoGourmet.Location = new Point(206, 127);
            BtnFormJogoGourmet.Name = "BtnFormJogoGourmet";
            BtnFormJogoGourmet.Size = new Size(94, 37);
            BtnFormJogoGourmet.TabIndex = 3;
            BtnFormJogoGourmet.Text = "OK";
            BtnFormJogoGourmet.UseVisualStyleBackColor = true;
            BtnFormJogoGourmet.Click += BtnFormJogoGourmet_Click;
            // 
            // LblMensagemInicial
            // 
            LblMensagemInicial.AccessibleDescription = "Pense em um prato que gosta";
            LblMensagemInicial.AccessibleName = "PensarPrato";
            LblMensagemInicial.BackColor = SystemColors.Window;
            LblMensagemInicial.Dock = DockStyle.Fill;
            LblMensagemInicial.Location = new Point(0, 0);
            LblMensagemInicial.Name = "LblMensagemInicial";
            LblMensagemInicial.Size = new Size(499, 202);
            LblMensagemInicial.TabIndex = 2;
            LblMensagemInicial.Text = "Pense em um prato que gosta";
            LblMensagemInicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormJogoGourmet
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(500, 200);
            Controls.Add(PnlFormJogoGourmet);
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "FormJogoGourmet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            PnlFormJogoGourmet.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlFormJogoGourmet;
        private Button BtnFormJogoGourmet;
        private Label LblMensagemInicial;
    }
}
