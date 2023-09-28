namespace SGA
{
    partial class FormReportCurso
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
            groupBox1 = new GroupBox();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox2 = new GroupBox();
            CboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            TxtAgrupamento = new GroupBox();
            CboAgrupa = new ReaLTaiizor.Controls.MaterialComboBox();
            TxtDataCriacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            TxtAgrupamento.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVisualizar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(TxtAgrupamento);
            groupBox1.Controls.Add(TxtDataCriacao);
            groupBox1.Location = new Point(19, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(523, 290);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(112, 36);
            btnVisualizar.TabIndex = 13;
            btnVisualizar.Text = "&VISUALIZAR";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(647, 290);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(97, 36);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "&IMPRIMIR";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboTipo
            // 
            cboTipo.AutoResize = false;
            cboTipo.BackColor = Color.FromArgb(255, 255, 255);
            cboTipo.Depth = 0;
            cboTipo.DrawMode = DrawMode.OwnerDrawVariable;
            cboTipo.DropDownHeight = 174;
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.DropDownWidth = 121;
            cboTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTipo.FormattingEnabled = true;
            cboTipo.Hint = "Tipo";
            cboTipo.IntegralHeight = false;
            cboTipo.ItemHeight = 43;
            cboTipo.Items.AddRange(new object[] { "", "Técnico", "Tecnólogo", "Bacharelado", "Licenciatura", "Pós-Graduação" });
            cboTipo.Location = new Point(259, 20);
            cboTipo.MaxDropDownItems = 4;
            cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(474, 49);
            cboTipo.StartIndex = 0;
            cboTipo.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CboImpressora);
            groupBox2.Location = new Point(18, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 94);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Impressora";
            // 
            // CboImpressora
            // 
            CboImpressora.AutoResize = false;
            CboImpressora.BackColor = Color.FromArgb(255, 255, 255);
            CboImpressora.Depth = 0;
            CboImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            CboImpressora.DropDownHeight = 174;
            CboImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            CboImpressora.DropDownWidth = 121;
            CboImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CboImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CboImpressora.FormattingEnabled = true;
            CboImpressora.Hint = "Impressora";
            CboImpressora.IntegralHeight = false;
            CboImpressora.ItemHeight = 43;
            CboImpressora.Location = new Point(6, 33);
            CboImpressora.MaxDropDownItems = 4;
            CboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CboImpressora.Name = "CboImpressora";
            CboImpressora.Size = new Size(709, 49);
            CboImpressora.StartIndex = 0;
            CboImpressora.TabIndex = 9;
            // 
            // TxtAgrupamento
            // 
            TxtAgrupamento.Controls.Add(CboAgrupa);
            TxtAgrupamento.Location = new Point(17, 89);
            TxtAgrupamento.Name = "TxtAgrupamento";
            TxtAgrupamento.Size = new Size(721, 94);
            TxtAgrupamento.TabIndex = 9;
            TxtAgrupamento.TabStop = false;
            TxtAgrupamento.Text = "Agrupamento";
            // 
            // CboAgrupa
            // 
            CboAgrupa.AutoResize = false;
            CboAgrupa.BackColor = Color.FromArgb(255, 255, 255);
            CboAgrupa.Depth = 0;
            CboAgrupa.DrawMode = DrawMode.OwnerDrawVariable;
            CboAgrupa.DropDownHeight = 174;
            CboAgrupa.DropDownStyle = ComboBoxStyle.DropDownList;
            CboAgrupa.DropDownWidth = 121;
            CboAgrupa.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CboAgrupa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CboAgrupa.FormattingEnabled = true;
            CboAgrupa.Hint = "Agrupamento";
            CboAgrupa.IntegralHeight = false;
            CboAgrupa.ItemHeight = 43;
            CboAgrupa.Items.AddRange(new object[] { "Nenhum", "Data de Criação", "Tipo" });
            CboAgrupa.Location = new Point(6, 33);
            CboAgrupa.MaxDropDownItems = 4;
            CboAgrupa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CboAgrupa.Name = "CboAgrupa";
            CboAgrupa.Size = new Size(709, 49);
            CboAgrupa.StartIndex = 0;
            CboAgrupa.TabIndex = 9;
            // 
            // TxtDataCriacao
            // 
            TxtDataCriacao.AnimateReadOnly = false;
            TxtDataCriacao.AutoCompleteMode = AutoCompleteMode.None;
            TxtDataCriacao.AutoCompleteSource = AutoCompleteSource.None;
            TxtDataCriacao.BackgroundImageLayout = ImageLayout.None;
            TxtDataCriacao.CharacterCasing = CharacterCasing.Normal;
            TxtDataCriacao.Depth = 0;
            TxtDataCriacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtDataCriacao.HideSelection = true;
            TxtDataCriacao.Hint = "Data de Criação";
            TxtDataCriacao.LeadingIcon = null;
            TxtDataCriacao.Location = new Point(24, 21);
            TxtDataCriacao.MaxLength = 32767;
            TxtDataCriacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtDataCriacao.Name = "TxtDataCriacao";
            TxtDataCriacao.PasswordChar = '\0';
            TxtDataCriacao.PrefixSuffixText = null;
            TxtDataCriacao.ReadOnly = false;
            TxtDataCriacao.RightToLeft = RightToLeft.No;
            TxtDataCriacao.SelectedText = "";
            TxtDataCriacao.SelectionLength = 0;
            TxtDataCriacao.SelectionStart = 0;
            TxtDataCriacao.ShortcutsEnabled = true;
            TxtDataCriacao.Size = new Size(224, 48);
            TxtDataCriacao.TabIndex = 7;
            TxtDataCriacao.TabStop = false;
            TxtDataCriacao.TextAlign = HorizontalAlignment.Left;
            TxtDataCriacao.TrailingIcon = null;
            TxtDataCriacao.UseSystemPasswordChar = false;
            // 
            // FormReportCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormReportCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cursos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            TxtAgrupamento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox CboImpressora;
        private GroupBox TxtAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox CboAgrupa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtDataCriacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
    }
}