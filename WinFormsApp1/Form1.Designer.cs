namespace WinFormsApp1
{
    partial class Form1
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
            aloneButton1 = new ReaLTaiizor.Controls.AloneButton();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButtonSticky1 = new ReaLTaiizor.Controls.ForeverButtonSticky();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverTextBox1 = new ReaLTaiizor.Controls.ForeverTextBox();
            foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            foreverTextBox2 = new ReaLTaiizor.Controls.ForeverTextBox();
            foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            foreverTextBox3 = new ReaLTaiizor.Controls.ForeverTextBox();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            foreverMaximize1 = new ReaLTaiizor.Controls.ForeverMaximize();
            foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            parrotGroupBox2.SuspendLayout();
            foreverForm1.SuspendLayout();
            foreverGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // aloneButton1
            // 
            aloneButton1.BackColor = Color.Transparent;
            aloneButton1.EnabledCalc = true;
            aloneButton1.Font = new Font("Segoe UI", 9F);
            aloneButton1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneButton1.Location = new Point(638, 373);
            aloneButton1.Name = "aloneButton1";
            aloneButton1.Size = new Size(150, 50);
            aloneButton1.TabIndex = 1;
            aloneButton1.Text = "aloneButton1";
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = Color.DodgerBlue;
            parrotGroupBox2.BorderWidth = 1;
            parrotGroupBox2.Controls.Add(aloneTextBox1);
            parrotGroupBox2.Location = new Point(27, 74);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(761, 191);
            parrotGroupBox2.TabIndex = 3;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "parrotGroupBox2";
            parrotGroupBox2.TextColor = Color.DodgerBlue;
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.EnabledCalc = true;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneTextBox1.Location = new Point(16, 55);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(230, 36);
            aloneTextBox1.TabIndex = 1;
            aloneTextBox1.Text = "aloneTextBox1";
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.DodgerBlue;
            parrotGroupBox1.BorderWidth = 1;
            parrotGroupBox1.Location = new Point(12, 61);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(776, 194);
            parrotGroupBox1.TabIndex = 3;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "parrotGroupBox1";
            parrotGroupBox1.TextColor = Color.DodgerBlue;
            // 
            // foreverForm1
            // 
            foreverForm1.BackColor = Color.White;
            foreverForm1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverForm1.BorderColor = Color.DodgerBlue;
            foreverForm1.Controls.Add(foreverMinimize1);
            foreverForm1.Controls.Add(foreverMaximize1);
            foreverForm1.Controls.Add(foreverClose1);
            foreverForm1.Controls.Add(foreverGroupBox1);
            foreverForm1.Controls.Add(foreverButtonSticky1);
            foreverForm1.Controls.Add(foreverButton1);
            foreverForm1.Dock = DockStyle.Fill;
            foreverForm1.Font = new Font("Segoe UI", 12F);
            foreverForm1.ForeverColor = Color.FromArgb(35, 168, 109);
            foreverForm1.HeaderColor = Color.FromArgb(45, 47, 49);
            foreverForm1.HeaderMaximize = false;
            foreverForm1.HeaderTextFont = new Font("Segoe UI", 12F);
            foreverForm1.Image = null;
            foreverForm1.Location = new Point(0, 0);
            foreverForm1.MinimumSize = new Size(210, 50);
            foreverForm1.Name = "foreverForm1";
            foreverForm1.Padding = new Padding(1, 51, 1, 1);
            foreverForm1.Sizable = true;
            foreverForm1.Size = new Size(556, 450);
            foreverForm1.TabIndex = 0;
            foreverForm1.Text = "Cadastro de Usuário";
            foreverForm1.TextColor = Color.FromArgb(234, 234, 234);
            foreverForm1.TextLight = Color.SeaGreen;
            // 
            // foreverButton1
            // 
            foreverButton1.BackColor = Color.Transparent;
            foreverButton1.BaseColor = Color.FromArgb(35, 168, 109);
            foreverButton1.Font = new Font("Segoe UI", 12F);
            foreverButton1.Location = new Point(162, 388);
            foreverButton1.Name = "foreverButton1";
            foreverButton1.Rounded = false;
            foreverButton1.Size = new Size(150, 50);
            foreverButton1.TabIndex = 0;
            foreverButton1.Text = "Salvar";
            foreverButton1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverButtonSticky1
            // 
            foreverButtonSticky1.BackColor = Color.Transparent;
            foreverButtonSticky1.BaseColor = Color.FromArgb(35, 168, 109);
            foreverButtonSticky1.Font = new Font("Segoe UI", 12F);
            foreverButtonSticky1.Location = new Point(337, 388);
            foreverButtonSticky1.Name = "foreverButtonSticky1";
            foreverButtonSticky1.Rounded = false;
            foreverButtonSticky1.Size = new Size(155, 50);
            foreverButtonSticky1.TabIndex = 1;
            foreverButtonSticky1.Text = "Cancelar";
            foreverButtonSticky1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.ArrowColorH = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.Controls.Add(foreverLabel3);
            foreverGroupBox1.Controls.Add(foreverTextBox3);
            foreverGroupBox1.Controls.Add(foreverLabel2);
            foreverGroupBox1.Controls.Add(foreverTextBox2);
            foreverGroupBox1.Controls.Add(foreverLabel1);
            foreverGroupBox1.Controls.Add(foreverTextBox1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(27, 75);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(497, 293);
            foreverGroupBox1.TabIndex = 2;
            foreverGroupBox1.Text = "Cadastro de Usuário";
            foreverGroupBox1.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // foreverTextBox1
            // 
            foreverTextBox1.BackColor = Color.Transparent;
            foreverTextBox1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox1.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox1.FocusOnHover = false;
            foreverTextBox1.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox1.Location = new Point(41, 72);
            foreverTextBox1.MaxLength = 32767;
            foreverTextBox1.Multiline = false;
            foreverTextBox1.Name = "foreverTextBox1";
            foreverTextBox1.ReadOnly = false;
            foreverTextBox1.Size = new Size(424, 34);
            foreverTextBox1.TabIndex = 0;
            foreverTextBox1.TextAlign = HorizontalAlignment.Left;
            foreverTextBox1.UseSystemPasswordChar = false;
            // 
            // foreverLabel1
            // 
            foreverLabel1.AutoSize = true;
            foreverLabel1.BackColor = Color.Transparent;
            foreverLabel1.Font = new Font("Segoe UI", 8F);
            foreverLabel1.ForeColor = Color.LightGray;
            foreverLabel1.Location = new Point(41, 50);
            foreverLabel1.Name = "foreverLabel1";
            foreverLabel1.Size = new Size(46, 19);
            foreverLabel1.TabIndex = 3;
            foreverLabel1.Text = "Nome";
            // 
            // foreverLabel2
            // 
            foreverLabel2.AutoSize = true;
            foreverLabel2.BackColor = Color.Transparent;
            foreverLabel2.Font = new Font("Segoe UI", 8F);
            foreverLabel2.ForeColor = Color.LightGray;
            foreverLabel2.Location = new Point(41, 133);
            foreverLabel2.Name = "foreverLabel2";
            foreverLabel2.Size = new Size(50, 19);
            foreverLabel2.TabIndex = 5;
            foreverLabel2.Text = "E-mail:";
            // 
            // foreverTextBox2
            // 
            foreverTextBox2.BackColor = Color.Transparent;
            foreverTextBox2.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox2.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox2.FocusOnHover = false;
            foreverTextBox2.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox2.Location = new Point(41, 155);
            foreverTextBox2.MaxLength = 32767;
            foreverTextBox2.Multiline = false;
            foreverTextBox2.Name = "foreverTextBox2";
            foreverTextBox2.ReadOnly = false;
            foreverTextBox2.Size = new Size(424, 34);
            foreverTextBox2.TabIndex = 4;
            foreverTextBox2.TextAlign = HorizontalAlignment.Left;
            foreverTextBox2.UseSystemPasswordChar = false;
            // 
            // foreverLabel3
            // 
            foreverLabel3.AutoSize = true;
            foreverLabel3.BackColor = Color.Transparent;
            foreverLabel3.Font = new Font("Segoe UI", 8F);
            foreverLabel3.ForeColor = Color.LightGray;
            foreverLabel3.Location = new Point(41, 209);
            foreverLabel3.Name = "foreverLabel3";
            foreverLabel3.Size = new Size(46, 19);
            foreverLabel3.TabIndex = 7;
            foreverLabel3.Text = "Senha";
            // 
            // foreverTextBox3
            // 
            foreverTextBox3.BackColor = Color.Transparent;
            foreverTextBox3.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox3.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox3.FocusOnHover = false;
            foreverTextBox3.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox3.Location = new Point(41, 231);
            foreverTextBox3.MaxLength = 32767;
            foreverTextBox3.Multiline = false;
            foreverTextBox3.Name = "foreverTextBox3";
            foreverTextBox3.ReadOnly = false;
            foreverTextBox3.Size = new Size(424, 34);
            foreverTextBox3.TabIndex = 6;
            foreverTextBox3.TextAlign = HorizontalAlignment.Left;
            foreverTextBox3.UseSystemPasswordChar = false;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(516, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 3;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverMaximize1
            // 
            foreverMaximize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverMaximize1.BackColor = Color.White;
            foreverMaximize1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverMaximize1.DefaultLocation = true;
            foreverMaximize1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverMaximize1.Font = new Font("Marlett", 12F);
            foreverMaximize1.Location = new Point(481, 15);
            foreverMaximize1.Name = "foreverMaximize1";
            foreverMaximize1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverMaximize1.Size = new Size(18, 18);
            foreverMaximize1.TabIndex = 4;
            foreverMaximize1.Text = "foreverMaximize1";
            foreverMaximize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverMinimize1
            // 
            foreverMinimize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverMinimize1.BackColor = Color.White;
            foreverMinimize1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverMinimize1.DefaultLocation = true;
            foreverMinimize1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverMinimize1.Font = new Font("Marlett", 12F);
            foreverMinimize1.Location = new Point(451, 15);
            foreverMinimize1.Name = "foreverMinimize1";
            foreverMinimize1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverMinimize1.Size = new Size(18, 18);
            foreverMinimize1.TabIndex = 5;
            foreverMinimize1.Text = "foreverMinimize1";
            foreverMinimize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 450);
            Controls.Add(foreverForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1020);
            MinimumSize = new Size(190, 40);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            TransparencyKey = Color.Fuchsia;
            parrotGroupBox2.ResumeLayout(false);
            foreverForm1.ResumeLayout(false);
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.AloneButton aloneButton1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBox3;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBox2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBox1;
        private ReaLTaiizor.Controls.ForeverButtonSticky foreverButtonSticky1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
        private ReaLTaiizor.Controls.ForeverMaximize foreverMaximize1;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
    }
}
