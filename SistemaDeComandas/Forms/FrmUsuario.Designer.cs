﻿namespace SistemaDeComandas.Forms
{
    partial class FrmUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            btnEditar = new ReaLTaiizor.Controls.NightButton();
            btnCancelar = new ReaLTaiizor.Controls.NightButton();
            btnSalvar = new ReaLTaiizor.Controls.NightButton();
            btnExcluir = new ReaLTaiizor.Controls.NightButton();
            cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            dgvUsuario = new DataGridView();
            btnNovo = new ReaLTaiizor.Controls.NightButton();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            txtSenha = new ReaLTaiizor.Controls.NightTextBox();
            nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            txtEmail = new ReaLTaiizor.Controls.NightTextBox();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            txtNome = new ReaLTaiizor.Controls.NightTextBox();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            btnVoltar = new ReaLTaiizor.Controls.NightButton();
            nightForm1.SuspendLayout();
            cyberGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            cyberGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(btnVoltar);
            nightForm1.Controls.Add(btnEditar);
            nightForm1.Controls.Add(btnCancelar);
            nightForm1.Controls.Add(btnSalvar);
            nightForm1.Controls.Add(btnExcluir);
            nightForm1.Controls.Add(cyberGroupBox2);
            nightForm1.Controls.Add(btnNovo);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(800, 694);
            nightForm1.TabIndex = 0;
            nightForm1.Text = "FrmUsuario";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.DialogResult = DialogResult.None;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ForeColor = Color.FromArgb(255, 255, 128);
            btnEditar.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnEditar.HoverForeColor = Color.White;
            btnEditar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnEditar.Location = new Point(180, 579);
            btnEditar.MinimumSize = new Size(144, 47);
            btnEditar.Name = "btnEditar";
            btnEditar.NormalBackColor = Color.FromArgb(255, 255, 128);
            btnEditar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnEditar.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnEditar.PressedForeColor = Color.White;
            btnEditar.Radius = 20;
            btnEditar.Size = new Size(144, 47);
            btnEditar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnEditar.TabIndex = 19;
            btnEditar.Text = "# Editar";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.DialogResult = DialogResult.None;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnCancelar.HoverForeColor = Color.White;
            btnCancelar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnCancelar.Location = new Point(630, 579);
            btnCancelar.MinimumSize = new Size(144, 47);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackColor = Color.Red;
            btnCancelar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnCancelar.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnCancelar.PressedForeColor = Color.White;
            btnCancelar.Radius = 20;
            btnCancelar.Size = new Size(144, 47);
            btnCancelar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "X Cancelar";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.DialogResult = DialogResult.None;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.ForeColor = Color.FromArgb(128, 128, 255);
            btnSalvar.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnSalvar.HoverForeColor = Color.White;
            btnSalvar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnSalvar.Location = new Point(330, 579);
            btnSalvar.MinimumSize = new Size(144, 47);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NormalBackColor = Color.FromArgb(128, 128, 255);
            btnSalvar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnSalvar.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnSalvar.PressedForeColor = Color.White;
            btnSalvar.Radius = 20;
            btnSalvar.Size = new Size(144, 47);
            btnSalvar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "✔ Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.DialogResult = DialogResult.None;
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.ForeColor = Color.FromArgb(242, 93, 89);
            btnExcluir.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnExcluir.HoverForeColor = Color.White;
            btnExcluir.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnExcluir.Location = new Point(480, 579);
            btnExcluir.MinimumSize = new Size(144, 47);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnExcluir.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnExcluir.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnExcluir.PressedForeColor = Color.White;
            btnExcluir.Radius = 20;
            btnExcluir.Size = new Size(144, 47);
            btnExcluir.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "X Excluir";
            // 
            // cyberGroupBox2
            // 
            cyberGroupBox2.Alpha = 10;
            cyberGroupBox2.BackColor = Color.Transparent;
            cyberGroupBox2.Background = true;
            cyberGroupBox2.Background_WidthPen = 2F;
            cyberGroupBox2.BackgroundPen = true;
            cyberGroupBox2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.Controls.Add(dgvUsuario);
            cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox2.Lighting = false;
            cyberGroupBox2.LinearGradient_Background = false;
            cyberGroupBox2.LinearGradientPen = false;
            cyberGroupBox2.Location = new Point(41, 371);
            cyberGroupBox2.Name = "cyberGroupBox2";
            cyberGroupBox2.PenWidth = 15;
            cyberGroupBox2.RGB = false;
            cyberGroupBox2.Rounding = true;
            cyberGroupBox2.RoundingInt = 20;
            cyberGroupBox2.Size = new Size(718, 187);
            cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox2.TabIndex = 15;
            cyberGroupBox2.Tag = "Cyber";
            cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox2.Timer_RGB = 300;
            // 
            // dgvUsuario
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvUsuario.DefaultCellStyle = dataGridViewCellStyle5;
            dgvUsuario.Location = new Point(30, 20);
            dgvUsuario.Name = "dgvUsuario";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvUsuario.Size = new Size(662, 150);
            dgvUsuario.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.DialogResult = DialogResult.None;
            btnNovo.Font = new Font("Segoe UI", 10F);
            btnNovo.ForeColor = Color.FromArgb(128, 255, 128);
            btnNovo.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnNovo.HoverForeColor = Color.White;
            btnNovo.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnNovo.Location = new Point(30, 579);
            btnNovo.MinimumSize = new Size(144, 47);
            btnNovo.Name = "btnNovo";
            btnNovo.NormalBackColor = Color.FromArgb(128, 255, 128);
            btnNovo.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnNovo.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnNovo.PressedForeColor = Color.White;
            btnNovo.Radius = 20;
            btnNovo.Size = new Size(144, 47);
            btnNovo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnNovo.TabIndex = 14;
            btnNovo.Text = "! Novo";
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 10;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 2F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(txtSenha);
            cyberGroupBox1.Controls.Add(nightLabel3);
            cyberGroupBox1.Controls.Add(txtEmail);
            cyberGroupBox1.Controls.Add(nightLabel2);
            cyberGroupBox1.Controls.Add(txtNome);
            cyberGroupBox1.Controls.Add(nightLabel1);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(41, 49);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 20;
            cyberGroupBox1.Size = new Size(718, 297);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 13;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // txtSenha
            // 
            txtSenha.ActiveBorderColor = Color.FromArgb(242, 93, 89);
            txtSenha.BackColor = Color.FromArgb(43, 48, 67);
            txtSenha.BaseBackColor = Color.FromArgb(43, 48, 67);
            txtSenha.ColorBordersOnEnter = true;
            txtSenha.DisableBorderColor = Color.FromArgb(60, 63, 80);
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.ForeColor = Color.FromArgb(127, 131, 140);
            txtSenha.Image = null;
            txtSenha.Location = new Point(29, 219);
            txtSenha.MaxLength = 32767;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = false;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.ShowBottomBorder = true;
            txtSenha.ShowTopBorder = true;
            txtSenha.Size = new Size(651, 50);
            txtSenha.TabIndex = 7;
            txtSenha.Text = "********";
            txtSenha.TextAlignment = HorizontalAlignment.Left;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.Watermark = "";
            txtSenha.WatermarkColor = Color.FromArgb(116, 120, 129);
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // nightLabel3
            // 
            nightLabel3.AutoSize = true;
            nightLabel3.BackColor = Color.Transparent;
            nightLabel3.Font = new Font("Segoe UI", 9F);
            nightLabel3.ForeColor = Color.White;
            nightLabel3.Location = new Point(29, 191);
            nightLabel3.Name = "nightLabel3";
            nightLabel3.Size = new Size(39, 15);
            nightLabel3.TabIndex = 6;
            nightLabel3.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.ActiveBorderColor = Color.FromArgb(242, 93, 89);
            txtEmail.BackColor = Color.FromArgb(43, 48, 67);
            txtEmail.BaseBackColor = Color.FromArgb(43, 48, 67);
            txtEmail.ColorBordersOnEnter = true;
            txtEmail.DisableBorderColor = Color.FromArgb(60, 63, 80);
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(127, 131, 140);
            txtEmail.Image = null;
            txtEmail.Location = new Point(29, 131);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = false;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.ShowBottomBorder = true;
            txtEmail.ShowTopBorder = true;
            txtEmail.Size = new Size(651, 50);
            txtEmail.TabIndex = 5;
            txtEmail.Text = "johndoe@example.com";
            txtEmail.TextAlignment = HorizontalAlignment.Left;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.Watermark = "";
            txtEmail.WatermarkColor = Color.FromArgb(116, 120, 129);
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 9F);
            nightLabel2.ForeColor = Color.White;
            nightLabel2.Location = new Point(29, 103);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(36, 15);
            nightLabel2.TabIndex = 4;
            nightLabel2.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.ActiveBorderColor = Color.FromArgb(242, 93, 89);
            txtNome.BackColor = Color.FromArgb(43, 48, 67);
            txtNome.BaseBackColor = Color.FromArgb(43, 48, 67);
            txtNome.ColorBordersOnEnter = true;
            txtNome.DisableBorderColor = Color.FromArgb(60, 63, 80);
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.ForeColor = Color.FromArgb(127, 131, 140);
            txtNome.Image = null;
            txtNome.Location = new Point(29, 45);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = false;
            txtNome.ShortcutsEnabled = true;
            txtNome.ShowBottomBorder = true;
            txtNome.ShowTopBorder = true;
            txtNome.Size = new Size(651, 50);
            txtNome.TabIndex = 3;
            txtNome.Text = "John Doe";
            txtNome.TextAlignment = HorizontalAlignment.Left;
            txtNome.UseSystemPasswordChar = false;
            txtNome.Watermark = "";
            txtNome.WatermarkColor = Color.FromArgb(116, 120, 129);
            txtNome.Enter += txtNome_Enter;
            txtNome.Leave += txtNome_Leave;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 9F);
            nightLabel1.ForeColor = Color.White;
            nightLabel1.Location = new Point(29, 18);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(40, 15);
            nightLabel1.TabIndex = 2;
            nightLabel1.Text = "Nome";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.DialogResult = DialogResult.None;
            btnVoltar.Font = new Font("Segoe UI", 10F);
            btnVoltar.ForeColor = Color.FromArgb(242, 93, 89);
            btnVoltar.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnVoltar.HoverForeColor = Color.White;
            btnVoltar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnVoltar.Location = new Point(30, 632);
            btnVoltar.MinimumSize = new Size(144, 47);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnVoltar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnVoltar.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnVoltar.PressedForeColor = Color.White;
            btnVoltar.Radius = 20;
            btnVoltar.Size = new Size(144, 47);
            btnVoltar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "< Voltar";
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 694);
            Controls.Add(cyberGroupBox1);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 860);
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuario";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            cyberGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightButton btnNovo;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.NightTextBox txtSenha;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private ReaLTaiizor.Controls.NightTextBox txtEmail;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.NightTextBox txtNome;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private ReaLTaiizor.Controls.NightButton btnExcluir;
        private ReaLTaiizor.Controls.NightButton btnEditar;
        private ReaLTaiizor.Controls.NightButton btnCancelar;
        private ReaLTaiizor.Controls.NightButton btnSalvar;
        private DataGridView dgvUsuario;
        private ReaLTaiizor.Controls.NightButton btnVoltar;
    }
}