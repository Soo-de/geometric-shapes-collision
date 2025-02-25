namespace NDP_2._ODEV
{
    partial class MainPage
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
            text1 = new Label();
            text2 = new Label();
            text3 = new Label();
            text_anasayfa = new Label();
            button_Collision = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // text1
            // 
            text1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text1.AutoSize = true;
            text1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            text1.Location = new Point(348, 77);
            text1.Name = "text1";
            text1.Size = new Size(123, 26);
            text1.TabIndex = 1;
            text1.Text = "Hoşgeldiniz";
            // 
            // text2
            // 
            text2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text2.AutoSize = true;
            text2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            text2.Location = new Point(281, 143);
            text2.Name = "text2";
            text2.Size = new Size(261, 26);
            text2.TabIndex = 1;
            text2.Text = "Lütfen Yapmak İstediğiniz";
            // 
            // text3
            // 
            text3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text3.AutoSize = true;
            text3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            text3.Location = new Point(339, 211);
            text3.Name = "text3";
            text3.Size = new Size(142, 26);
            text3.TabIndex = 1;
            text3.Text = "İşlemi Seçiniz";
            // 
            // text_anasayfa
            // 
            text_anasayfa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text_anasayfa.AutoSize = true;
            text_anasayfa.BackColor = Color.DarkSeaGreen;
            text_anasayfa.Font = new Font("Times New Roman", 19.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            text_anasayfa.Location = new Point(32, 67);
            text_anasayfa.Name = "text_anasayfa";
            text_anasayfa.Size = new Size(152, 36);
            text_anasayfa.TabIndex = 0;
            text_anasayfa.Text = "Ana Sayfa";
            // 
            // button_Collision
            // 
            button_Collision.BackColor = Color.DarkSeaGreen;
            button_Collision.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_Collision.Location = new Point(43, 143);
            button_Collision.Name = "button_Collision";
            button_Collision.Size = new Size(129, 44);
            button_Collision.TabIndex = 1;
            button_Collision.Text = "Çarpışma Testi";
            button_Collision.UseVisualStyleBackColor = false;
            button_Collision.Click += Button_Collusion_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(43, 203);
            button1.Name = "button1";
            button1.Size = new Size(129, 44);
            button1.TabIndex = 1;
            button1.Text = "Şekil Çizdirme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button_Collision);
            panel1.Controls.Add(text_anasayfa);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 358);
            panel1.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(573, 358);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(text1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label text1;
        private Label text2;
        private Label text3;
        private Label text_anasayfa;
        private Button button_Collision;
        private Button button1;
        private Panel panel1;
    }
}
