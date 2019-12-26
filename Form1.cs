using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace abc
{
    public partial class Form1 : Form
    {
        CultureInfo culture;
        ConDoi frmConDoi = new ConDoi();
        ChuotChui frmChuotChui = new ChuotChui();
        ConCho frmConCho = new ConCho();
        ConMeo frmConMeo = new ConMeo();
        ConHo frmConHo = new ConHo();
        DieuHau frmDieuHau = new DieuHau();
        private Random random = new Random();
        private int Level = 2;
        private int AnswerRight = 0;
        private int MaxAnswerRight = 1;
        private Color MainColor = new Color();
        int loi = 0;
        int i = 0;
        int z = 15;
       
        private List<List<Button>> NormalButton = new List<List<Button>>();
        private Button KeyButton;
        private int size;

        public Form1()
        {
            InitializeComponent();
            InitLevel();
            culture = CultureInfo.CurrentCulture;
            timer2.Interval = 1000;
        }

        public Color InitRandomColor()
        {

            Color color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            while (Convert.ToInt32(color.R) < 100 && Convert.ToInt32(color.B) < 100 && Convert.ToInt32(color.G) < 100)
            {
                color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }
            return color;


        }

        public Button InitKeyButton(Point Location, int size, Color color)
        {
            Button button = new Button();
            button.Location = Location;
            button.Width = size;
            button.Height = size;
            Color NewColor = Color.FromArgb(200, color);

            button.BackColor = NewColor;
            button.Click += KeyButtonClick;

            Controls.Add(button);
            return button;
        }

        private void KeyButtonClick(object sender, EventArgs e)
        {
            if (AnswerRight != MaxAnswerRight)
            {
                AnswerRight++;
                InitLevel();
            }
            else
            {
                AnswerRight = 0;
                Level++;
                InitLevel();
            }
            progressBar1.Value = progressBar1.Value + 1;

            i++;
            
            label9.Text = "" + i;
            timer2.Start();

            //Reset timer khi trả lời đúng
            z = 15;
            
            label10.Text = "" + z;

        }
        public Button InitNormalButton(Point Location, int size, Color color)
        {
            Button button = new Button();
            button.Location = Location;
            button.BackColor = color;
            button.Width = size;
            button.Height = size;
            button.Click += NormalButtonClick;

            Controls.Add(button);
            return button;
        }

        private void NormalButtonClick(object sender, EventArgs e)
        {
            if (z > 3) // khi click vào button bình thường, thì tgian sẽ -3, khi thời gian = 3 sẽ không trừ mà tự gameover
            {
                z = z - 3;
            }
            else
            {

                if (0 < i && i <= 4)
                {
                    this.Hide();
                    frmConDoi.Show();
                }
                if (4 < i && i <= 9)
                {
                    this.Hide();
                    frmChuotChui.Show();
                }
                if (9 < i && i <= 14)
                {
                    this.Hide();
                    frmConCho.Show();
                }
                if (14 < i && i <= 19)
                {
                    this.Hide();
                    frmConMeo.Show();
                }
                if (19 < i && i <= 24)
                {
                    this.Hide();
                    frmConHo.Show();
                }
                if (24 < i && i <= 29)
                {
                    this.Hide();
                    frmDieuHau.Show();
                }
                timer2.Stop();
             
            }

            
            label10.Text = "" + z;
            loi++;
            
            label11.Text = "" + loi;
        }
        public void InitMatrixNormalButton(int Size, Color ColorToDraw)
        {
            for (int i = 0; i < NormalButton.Count; i++)
            {
                for (int j = 0; j < NormalButton[i].Count; j++)
                {
                    NormalButton[i][j] = InitNormalButton(new Point(j * Size, i * Size), Size, ColorToDraw);
                }
            }
        }

        public void InitLevel()
        {
            //xoa cac nut tren form
            Controls.Remove(KeyButton);
            for (int i = 0; i < NormalButton.Count; i++)
            {
                for (int j = 0; j < NormalButton[i].Count; j++)
                {
                    Controls.Remove(NormalButton[i][j]);
                }
                NormalButton[i].Clear();
            }
            NormalButton.Clear();

            size = this.DisplayRectangle.Height / Level;

            for (int i = 0; i < Level; i++)
            {
                NormalButton.Add(new List<Button>());
                for (int j = 0; j < Level; j++)
                {
                    NormalButton[i].Add(new Button());
                }
            }

            MainColor = InitRandomColor();
            InitMatrixNormalButton(size, MainColor);

            int Randx = random.Next(Level);
            int Randy = random.Next(Level);

            Controls.Remove(NormalButton[Randy][Randx]);
            KeyButton = InitKeyButton(new Point(Randx * size, Randy * size), size, MainColor);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1000;   
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            z--;
            
            label10.Text = "" + z;
            if (z == 0)
            {
                if (0 < i && i <= 4)
                {
                    this.Hide();
                    frmConDoi.Show();
                }
                if (4 < i && i <= 9)
                {
                    this.Hide();
                    frmChuotChui.Show();
                }
                if (9 < i && i <= 14)
                {
                    this.Hide();
                    frmConCho.Show();
                }
                if (14 < i && i <= 19)
                {
                    this.Hide();
                    frmConMeo.Show();
                }
                if (19 < i && i <= 24)
                {
                    this.Hide();
                    frmConHo.Show();
                }
                if (24 < i && i <= 29)
                {
                    this.Hide();
                    frmDieuHau.Show();
                }
                timer2.Stop();
            }
        }
     
        public void LanguageRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (English.Checked)
            {
                SetLanguage("en-US");
                label6.Text = "Score: ";
                label8.Text = "Mistake: ";
                label1.Text = "WHICH ONE OF THE BOXES HAS AN IRREGULAR COLOR?";

            }
            else if (VietNam.Checked)
            {
                SetLanguage("vi-VN");
                label6.Text = "Điểm: ";
                label8.Text = "Số lỗi: ";
                label1.Text = "Hộp nào có màu sắc bất thường?";
            }
            else if (TrungQuoc.Checked)
            { 
                SetLanguage("cn-TQ");
                label6.Text = "得分: ";
                label8.Text = "错误: ";
                label1.Text = "哪一个盒子有不规则的颜色 ?";
            }
            else if (HanQuoc.Checked)
            {
                SetLanguage("kor-HQ");
                label6.Text = "점수: ";
                label8.Text = "오류: ";
                label1.Text = "4개의 박스 중 색이다른 박스는 어떤건가요 ?";
            }
            else if (NhatBan.Checked)
            {
                SetLanguage("jav-NB");
                label6.Text = "スコア: ";
                label8.Text = "エラー: ";
                label1.Text = "ボックスの中で1つどれが異なる色をしているでしょう？ ?";
            }
            else if (TayBanNha.Checked)
            {
                SetLanguage("Spa-TBN");
                label6.Text = "PUNTUACIÓN: ";
                label8.Text = "FALLOS: ";
                label1.Text = "¿QUÉ CASILLA TIENEUN COLOR DISTINTO ? ";
            }
            else if (Duc.Checked)
            {
                SetLanguage("Ger-Duc");
                label6.Text = "PUNKTZAHL: ";
                label8.Text = "FEHLER: ";
                label1.Text = "WELCHES KÄSTCHEN HATEINE ANDERE FARBE ? ";
            }
            else if (Phap.Checked)
            {
                SetLanguage("Fra-Phap");
                label6.Text = "SCORE: ";
                label8.Text = "ERREURS: ";
                label1.Text = "LAQUELLE DE CES CASESN'EST PAS DE LA MÊME COULEUR? ";
            }


          

        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("abc.Lang.MyResource", typeof(Form1).Assembly);
        
        }

 
    }
}