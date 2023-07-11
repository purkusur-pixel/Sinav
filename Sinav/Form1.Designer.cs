namespace Sinav
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
            button_diskalifiye = new Button();
            label_sbt_TC = new Label();
            label_sbt_adi = new Label();
            label_gogus_no = new Label();
            label_sbt_skor = new Label();
            button_kaydet = new Button();
            button_manuel = new Button();
            button_terk = new Button();
            button_barkod = new Button();
            label_tc = new Label();
            label_isim = new Label();
            label_gogus = new Label();
            label_skor = new Label();
            SuspendLayout();
            // 
            // button_diskalifiye
            // 
            button_diskalifiye.Location = new Point(556, 31);
            button_diskalifiye.Name = "button_diskalifiye";
            button_diskalifiye.Size = new Size(75, 23);
            button_diskalifiye.TabIndex = 0;
            button_diskalifiye.Text = "Diskalifiye";
            button_diskalifiye.UseVisualStyleBackColor = true;
            // 
            // label_sbt_TC
            // 
            label_sbt_TC.AutoSize = true;
            label_sbt_TC.Location = new Point(26, 31);
            label_sbt_TC.Name = "label_sbt_TC";
            label_sbt_TC.Size = new Size(82, 15);
            label_sbt_TC.TabIndex = 1;
            label_sbt_TC.Text = "T.C Kimlik No:";
            // 
            // label_sbt_adi
            // 
            label_sbt_adi.AutoSize = true;
            label_sbt_adi.Location = new Point(26, 86);
            label_sbt_adi.Name = "label_sbt_adi";
            label_sbt_adi.Size = new Size(63, 15);
            label_sbt_adi.TabIndex = 2;
            label_sbt_adi.Text = "Adı Soyadı";
            // 
            // label_gogus_no
            // 
            label_gogus_no.AutoSize = true;
            label_gogus_no.Location = new Point(26, 138);
            label_gogus_no.Name = "label_gogus_no";
            label_gogus_no.Size = new Size(63, 15);
            label_gogus_no.TabIndex = 3;
            label_gogus_no.Text = "Göğüs No:";
            // 
            // label_sbt_skor
            // 
            label_sbt_skor.AutoSize = true;
            label_sbt_skor.Location = new Point(26, 200);
            label_sbt_skor.Name = "label_sbt_skor";
            label_sbt_skor.Size = new Size(33, 15);
            label_sbt_skor.TabIndex = 4;
            label_sbt_skor.Text = "Skor:";
            // 
            // button_kaydet
            // 
            button_kaydet.Location = new Point(26, 266);
            button_kaydet.Name = "button_kaydet";
            button_kaydet.Size = new Size(305, 23);
            button_kaydet.TabIndex = 5;
            button_kaydet.Text = "Kaydet";
            button_kaydet.UseVisualStyleBackColor = true;
            // 
            // button_manuel
            // 
            button_manuel.Location = new Point(216, 196);
            button_manuel.Name = "button_manuel";
            button_manuel.Size = new Size(115, 23);
            button_manuel.TabIndex = 6;
            button_manuel.Text = "Manuel Giriş";
            button_manuel.UseVisualStyleBackColor = true;
            // 
            // button_terk
            // 
            button_terk.Location = new Point(556, 78);
            button_terk.Name = "button_terk";
            button_terk.Size = new Size(75, 23);
            button_terk.TabIndex = 7;
            button_terk.Text = "Terk";
            button_terk.UseVisualStyleBackColor = true;
            // 
            // button_barkod
            // 
            button_barkod.Location = new Point(366, 266);
            button_barkod.Name = "button_barkod";
            button_barkod.Size = new Size(265, 23);
            button_barkod.TabIndex = 8;
            button_barkod.Text = "Barkod Al";
            button_barkod.UseVisualStyleBackColor = true;
            button_barkod.Click += button_barkod_Click;
            // 
            // label_tc
            // 
            label_tc.AutoSize = true;
            label_tc.Location = new Point(124, 31);
            label_tc.Name = "label_tc";
            label_tc.Size = new Size(45, 15);
            label_tc.TabIndex = 9;
            label_tc.Text = "labelTC";
            // 
            // label_isim
            // 
            label_isim.AutoSize = true;
            label_isim.Location = new Point(124, 86);
            label_isim.Name = "label_isim";
            label_isim.Size = new Size(54, 15);
            label_isim.TabIndex = 10;
            label_isim.Text = "labelIsım";
            // 
            // label_gogus
            // 
            label_gogus.AutoSize = true;
            label_gogus.Location = new Point(124, 138);
            label_gogus.Name = "label_gogus";
            label_gogus.Size = new Size(64, 15);
            label_gogus.TabIndex = 11;
            label_gogus.Text = "labelGosus";
            // 
            // label_skor
            // 
            label_skor.AutoSize = true;
            label_skor.Location = new Point(124, 200);
            label_skor.Name = "label_skor";
            label_skor.Size = new Size(55, 15);
            label_skor.TabIndex = 12;
            label_skor.Text = "labelSkor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 321);
            Controls.Add(label_skor);
            Controls.Add(label_gogus);
            Controls.Add(label_isim);
            Controls.Add(label_tc);
            Controls.Add(button_barkod);
            Controls.Add(button_terk);
            Controls.Add(button_manuel);
            Controls.Add(button_kaydet);
            Controls.Add(label_sbt_skor);
            Controls.Add(label_gogus_no);
            Controls.Add(label_sbt_adi);
            Controls.Add(label_sbt_TC);
            Controls.Add(button_diskalifiye);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_diskalifiye;
        private Label label_sbt_TC;
        private Label label_sbt_adi;
        private Label label_gogus_no;
        private Label label_sbt_skor;
        private Button button_kaydet;
        private Button button_manuel;
        private Button button_terk;
        private Button button_barkod;
        private Label label_tc;
        private Label label_isim;
        private Label label_gogus;
        private Label label_skor;
    }
}