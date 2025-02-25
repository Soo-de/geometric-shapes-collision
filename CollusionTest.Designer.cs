namespace NDP_2._ODEV
{
    partial class CollisionTest
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
            components = new System.ComponentModel.Container();
            timer_Move = new System.Windows.Forms.Timer(components);
            panel_Collusion = new Panel();
            button_return1 = new Button();
            comboBox_Decision = new ComboBox();
            text_CollisionControl = new Label();
            stage_Collision = new Panel();
            panel_Collusion.SuspendLayout();
            stage_Collision.SuspendLayout();
            SuspendLayout();
            // 
            // timer_Move
            // 
            timer_Move.Enabled = true;
            timer_Move.Interval = 25;
            timer_Move.Tick += timer_Move_Tick;
            // 
            // panel_Collusion
            // 
            panel_Collusion.BackColor = Color.DarkSeaGreen;
            panel_Collusion.Controls.Add(button_return1);
            panel_Collusion.Controls.Add(comboBox_Decision);
            panel_Collusion.Dock = DockStyle.Left;
            panel_Collusion.Location = new Point(0, 0);
            panel_Collusion.Name = "panel_Collusion";
            panel_Collusion.Size = new Size(160, 358);
            panel_Collusion.TabIndex = 0;
            // 
            // button_return1
            // 
            button_return1.BackColor = Color.LemonChiffon;
            button_return1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_return1.Location = new Point(10, 314);
            button_return1.Name = "button_return1";
            button_return1.Size = new Size(136, 32);
            button_return1.TabIndex = 0;
            button_return1.Text = "Ana Sayfa";
            button_return1.UseVisualStyleBackColor = false;
            button_return1.Click += button_return1_Click;
            // 
            // comboBox_Decision
            // 
            comboBox_Decision.BackColor = Color.LemonChiffon;
            comboBox_Decision.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox_Decision.FormattingEnabled = true;
            comboBox_Decision.Items.AddRange(new object[] { "Nokta-Kare", "Nokta-Dikdörtgen", "Nokta-Çember", "Nokta-Küre", "Nokta-Silindir", "Dikdörtgen-Dikdörtgen", "Dikdörtgen-Çember", "Çember-Çember", "Silindir-Silindir", "Küre-Dikdörtgen", "Küre-Küre", "Küre-Silindir", "Yüzey-Küre", "Yüzey-Kare", "Yüzey-Dikdörtgen", "D.Prizma-D.Prizma" });
            comboBox_Decision.Location = new Point(3, 132);
            comboBox_Decision.Name = "comboBox_Decision";
            comboBox_Decision.Size = new Size(151, 27);
            comboBox_Decision.TabIndex = 1;
            comboBox_Decision.Text = "Çarpışma Seçiniz";
            // 
            // text_CollisionControl
            // 
            text_CollisionControl.AutoSize = true;
            text_CollisionControl.BackColor = Color.DarkSeaGreen;
            text_CollisionControl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            text_CollisionControl.Location = new Point(102, 0);
            text_CollisionControl.Name = "text_CollisionControl";
            text_CollisionControl.Size = new Size(0, 23);
            text_CollisionControl.TabIndex = 2;
            // 
            // stage_Collision
            // 
            stage_Collision.BackColor = Color.LightYellow;
            stage_Collision.Controls.Add(text_CollisionControl);
            stage_Collision.Location = new Point(175, 12);
            stage_Collision.Name = "stage_Collision";
            stage_Collision.Size = new Size(386, 334);
            stage_Collision.TabIndex = 1;
            // 
            // CollisionTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(573, 358);
            Controls.Add(stage_Collision);
            Controls.Add(panel_Collusion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CollisionTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CollusionTest";
            panel_Collusion.ResumeLayout(false);
            stage_Collision.ResumeLayout(false);
            stage_Collision.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Collusion;
        private ComboBox comboBox_Decision;
        private System.Windows.Forms.Timer timer_Move;
        private Button button_return1;
        private Panel stage_Collision;
        private Label text_CollisionControl;
    }
}