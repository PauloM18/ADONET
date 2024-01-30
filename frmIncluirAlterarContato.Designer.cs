namespace _9_ADONET
{
    partial class frmIncluirAlterarContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txbNome = new TextBox();
            txbEmail = new TextBox();
            lblEmail = new Label();
            txbTelefone = new TextBox();
            lblTelefone = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(23, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(84, 25);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(425, 23);
            txbNome.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(84, 66);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(425, 23);
            txbEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 69);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(84, 108);
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(425, 23);
            txbTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(23, 116);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(356, 146);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(437, 146);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(64, 26);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmIncluirAlterarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 189);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txbTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txbEmail);
            Controls.Add(lblEmail);
            Controls.Add(txbNome);
            Controls.Add(lblNome);
            Name = "frmIncluirAlterarContato";
            Text = "Incluir/Alterar de Contato";
            Load += frmIncluirAlterarContato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txbNome;
        private TextBox txbEmail;
        private Label lblEmail;
        private TextBox txbTelefone;
        private Label lblTelefone;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}