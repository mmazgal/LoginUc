namespace LoginUc
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
            label1 = new Label();
            label2 = new Label();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            buttonKayitOl = new Button();
            buttonGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 124);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 194);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(199, 121);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(125, 27);
            textBoxKullaniciAdi.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(199, 187);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(125, 27);
            textBoxSifre.TabIndex = 3;
            // 
            // buttonKayitOl
            // 
            buttonKayitOl.Location = new Point(163, 252);
            buttonKayitOl.Name = "buttonKayitOl";
            buttonKayitOl.Size = new Size(94, 29);
            buttonKayitOl.TabIndex = 4;
            buttonKayitOl.Text = "Kayıt Ol";
            buttonKayitOl.UseVisualStyleBackColor = true;
            buttonKayitOl.Click += buttonKayitOl_Click;
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(286, 252);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(94, 29);
            buttonGiris.TabIndex = 5;
            buttonGiris.Text = "Giriş";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 309);
            Controls.Add(buttonGiris);
            Controls.Add(buttonKayitOl);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Button buttonKayitOl;
        private Button buttonGiris;
    }
}
