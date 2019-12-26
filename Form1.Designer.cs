namespace abc
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.VietNam = new System.Windows.Forms.RadioButton();
            this.English = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TrungQuoc = new System.Windows.Forms.RadioButton();
            this.HanQuoc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NhatBan = new System.Windows.Forms.RadioButton();
            this.TayBanNha = new System.Windows.Forms.RadioButton();
            this.Duc = new System.Windows.Forms.RadioButton();
            this.Phap = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(843, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Score:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(981, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mistake:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(755, 498);
            this.progressBar1.Maximum = 29;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(312, 32);
            this.progressBar1.TabIndex = 4;
            // 
            // VietNam
            // 
            this.VietNam.AutoSize = true;
            this.VietNam.Location = new System.Drawing.Point(755, 536);
            this.VietNam.Name = "VietNam";
            this.VietNam.Size = new System.Drawing.Size(21, 20);
            this.VietNam.TabIndex = 5;
            this.VietNam.TabStop = true;
            this.VietNam.UseVisualStyleBackColor = true;
            this.VietNam.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Location = new System.Drawing.Point(831, 536);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(21, 20);
            this.English.TabIndex = 6;
            this.English.TabStop = true;
            this.English.UseVisualStyleBackColor = true;
            this.English.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(844, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(747, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 46);
            this.label10.TabIndex = 8;
            this.label10.Text = "15";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(986, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrungQuoc
            // 
            this.TrungQuoc.AutoSize = true;
            this.TrungQuoc.Location = new System.Drawing.Point(907, 536);
            this.TrungQuoc.Name = "TrungQuoc";
            this.TrungQuoc.Size = new System.Drawing.Size(21, 20);
            this.TrungQuoc.TabIndex = 10;
            this.TrungQuoc.TabStop = true;
            this.TrungQuoc.UseVisualStyleBackColor = true;
            this.TrungQuoc.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // HanQuoc
            // 
            this.HanQuoc.AutoSize = true;
            this.HanQuoc.Location = new System.Drawing.Point(983, 536);
            this.HanQuoc.Name = "HanQuoc";
            this.HanQuoc.Size = new System.Drawing.Size(21, 20);
            this.HanQuoc.TabIndex = 10;
            this.HanQuoc.TabStop = true;
            this.HanQuoc.UseVisualStyleBackColor = true;
            this.HanQuoc.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(784, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 104);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hộp nào có màu sắc bất thường?";
            // 
            // NhatBan
            // 
            this.NhatBan.AutoSize = true;
            this.NhatBan.Location = new System.Drawing.Point(755, 614);
            this.NhatBan.Name = "NhatBan";
            this.NhatBan.Size = new System.Drawing.Size(21, 20);
            this.NhatBan.TabIndex = 10;
            this.NhatBan.TabStop = true;
            this.NhatBan.UseVisualStyleBackColor = true;
            this.NhatBan.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // TayBanNha
            // 
            this.TayBanNha.AutoSize = true;
            this.TayBanNha.Location = new System.Drawing.Point(831, 614);
            this.TayBanNha.Name = "TayBanNha";
            this.TayBanNha.Size = new System.Drawing.Size(21, 20);
            this.TayBanNha.TabIndex = 10;
            this.TayBanNha.TabStop = true;
            this.TayBanNha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.TayBanNha.UseVisualStyleBackColor = true;
            this.TayBanNha.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // Duc
            // 
            this.Duc.AutoSize = true;
            this.Duc.Location = new System.Drawing.Point(907, 614);
            this.Duc.Name = "Duc";
            this.Duc.Size = new System.Drawing.Size(21, 20);
            this.Duc.TabIndex = 10;
            this.Duc.TabStop = true;
            this.Duc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Duc.UseVisualStyleBackColor = true;
            this.Duc.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // Phap
            // 
            this.Phap.AutoSize = true;
            this.Phap.Location = new System.Drawing.Point(980, 612);
            this.Phap.Name = "Phap";
            this.Phap.Size = new System.Drawing.Size(21, 20);
            this.Phap.TabIndex = 10;
            this.Phap.TabStop = true;
            this.Phap.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Phap.UseVisualStyleBackColor = true;
            this.Phap.CheckedChanged += new System.EventHandler(this.LanguageRadioButtons_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::abc.Properties.Resources.korea;
            this.pictureBox1.Location = new System.Drawing.Point(983, 551);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::abc.Properties.Resources.china;
            this.pictureBox4.Location = new System.Drawing.Point(907, 551);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::abc.Properties.Resources._1200px_Flag_of_the_United_Kingdom_svg;
            this.pictureBox3.Location = new System.Drawing.Point(831, 551);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::abc.Properties.Resources.france;
            this.pictureBox8.Location = new System.Drawing.Point(983, 627);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(70, 48);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::abc.Properties.Resources.germany;
            this.pictureBox7.Location = new System.Drawing.Point(907, 627);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::abc.Properties.Resources.spain;
            this.pictureBox6.Location = new System.Drawing.Point(831, 627);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::abc.Properties.Resources.japan;
            this.pictureBox5.Location = new System.Drawing.Point(755, 627);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::abc.Properties.Resources.vietnam;
            this.pictureBox2.Location = new System.Drawing.Point(755, 551);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::abc.Properties.Resources.eye_doctor2;
            this.pictureBox9.Location = new System.Drawing.Point(755, 67);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(312, 425);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1334, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Phap);
            this.Controls.Add(this.Duc);
            this.Controls.Add(this.TayBanNha);
            this.Controls.Add(this.NhatBan);
            this.Controls.Add(this.HanQuoc);
            this.Controls.Add(this.TrungQuoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.English);
            this.Controls.Add(this.VietNam);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox9);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
   
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton VietNam;
        private System.Windows.Forms.RadioButton English;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton TrungQuoc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton HanQuoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton NhatBan;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton TayBanNha;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton Duc;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.RadioButton Phap;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

