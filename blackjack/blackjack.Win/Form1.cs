using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace blackjack.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s, i, z1, z2, z3 = 1;
        PictureBox[] picturebox = new PictureBox[54];
        
        int Xlocation = 80, x2loc = 163;
        int ylocation = 191, y2loc = 54;

        Dictionary<int, string> kagitlar = new Dictionary<int, string> { { 0, "" }, { 1, "_1" }, { 2, "_2" }, { 3, "_3" }, { 4, "_4" }, { 5, "_5" }, { 6, "_6" }, { 7, "_7" }, { 8, "_8" }, { 9, "_9" }, { 10, "_10" }, { 11, "_11" }, { 12, "_12" }, { 13, "_13" }, { 14, "_14" }, { 15, "_15" }, { 16, "_16" }, { 17, "_17" }, { 18, "_18" }, { 19, "_19" }, { 20, "_20" }, { 21, "_21" }, { 22, "_22" }, { 23, "_23" }, { 24, "_24" }, { 25, "_25" }, { 26, "_26" }, { 27, "_27" }, { 28, "_28" }, { 29, "_29" }, { 30, "_30" }, { 31, "_31" }, { 32, "_32" }, { 33, "_33" }, { 34, "_34" }, { 35, "_35" }, { 36, "_36" }, { 37, "_37" }, { 38, "_38" }, { 39, "_39" }, { 40, "_40" }, { 41, "_41" }, { 42, "_42" }, { 43, "_43" }, { 44, "_44" }, { 45, "_45" }, { 46, "_46" }, { 47, "_47" }, { 48, "_48" }, { 49, "_49" }, { 50, "_50" }, { 51, "_51" }, { 52, "_52" } };
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "BAŞLA")
            {
                z3 = 1;
                Xlocation = 80;
                x2loc = 163;
                ylocation = 191;
                y2loc = 54;
                picturebox = new PictureBox[54];
                button1.Text = "BİTİR";
                button2.Enabled = true;
                button3.Enabled = true;
                label1.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label3.Visible = false;
                score1 = 0;
                score2 = 0;
                score3 = 0;
                label4.Visible = false;
                Dictionary<int, string> kagitlar = new Dictionary<int, string> { { 0, "" }, { 1, "_1" }, { 2, "_2" }, { 3, "_3" }, { 4, "_4" }, { 5, "_5" }, { 6, "_6" }, { 7, "_7" }, { 8, "_8" }, { 9, "_9" }, { 10, "_10" }, { 11, "_11" }, { 12, "_12" }, { 13, "_13" }, { 14, "_14" }, { 15, "_15" }, { 16, "_16" }, { 17, "_17" }, { 18, "_18" }, { 19, "_19" }, { 20, "_20" }, { 21, "_21" }, { 22, "_22" }, { 23, "_23" }, { 24, "_24" }, { 25, "_25" }, { 26, "_26" }, { 27, "_27" }, { 28, "_28" }, { 29, "_29" }, { 30, "_30" }, { 31, "_31" }, { 32, "_32" }, { 33, "_33" }, { 34, "_34" }, { 35, "_35" }, { 36, "_36" }, { 37, "_37" }, { 38, "_38" }, { 39, "_39" }, { 40, "_40" }, { 41, "_41" }, { 42, "_42" }, { 43, "_43" }, { 44, "_44" }, { 45, "_45" }, { 46, "_46" }, { 47, "_47" }, { 48, "_48" }, { 49, "_49" }, { 50, "_50" }, { 51, "_51" }, { 52, "_52" } };
                s = 53;
                picturebox[s] = new PictureBox();
                picturebox[s].Name = "picturebox" + s.ToString();
                picturebox[s].SetBounds(x2loc, y2loc, 200, 115);
                this.Controls.Add(picturebox[s]);
                picturebox[s].BringToFront();
                picturebox[s].BackColor = Color.ForestGreen;
                if (button1.Text == "BİTİR")
                {
                    
                PictureBox picturebox10 = new PictureBox();
                picturebox10.Name = "picturebox10";
                picturebox10.SetBounds(Xlocation, ylocation, 800, 115);
                this.Controls.Add(picturebox10);
                picturebox10.BringToFront();
                picturebox10.BackColor = Color.ForestGreen;
                }

            }
            else
            {
                button1.Text = "BAŞLA";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }


            if (button1.Text == "BİTİR")
            {

                s = _random.Next(1, 53);
                picturebox[s] = new PictureBox();
                picturebox[s].Name = "picturebox" + s.ToString();
                picturebox[s].SetBounds(x2loc, y2loc, 80, 115);//location ve size belirleme
                x2loc = x2loc + 15;

                this.Controls.Add(picturebox[s]);
                picturebox[s].BringToFront();
                #region sinr4
                switch (s)
                {
                    case (1):
                        picturebox[s].Image = Properties.Resources._1;
                        score2 += 11;
                        break;
                    case (2):
                        picturebox[s].Image = Properties.Resources._2;
                        score2 += 2;
                        break;
                    case (3):
                        picturebox[s].Image = Properties.Resources._3;
                        score2 += 3;
                        break;
                    case (4):
                        picturebox[s].Image = Properties.Resources._4;
                        score2 += 4;
                        break;
                    case (5):
                        picturebox[s].Image = Properties.Resources._5;
                        score2 += 5;
                        break;
                    case (6):
                        picturebox[s].Image = Properties.Resources._6;
                        score2 += 6;
                        break;
                    case (7):
                        picturebox[s].Image = Properties.Resources._7;
                        score2 += 7;
                        break;
                    case (8):
                        picturebox[s].Image = Properties.Resources._8;
                        score2 += 8;
                        break;
                    case (9):
                        picturebox[s].Image = Properties.Resources._9;
                        score2 += 9;
                        break;
                    case (10):
                        picturebox[s].Image = Properties.Resources._10;
                        score2 += 10;
                        break;
                    case (11):
                        picturebox[s].Image = Properties.Resources._11;
                        score2 += 10;
                        break;
                    case (12):
                        picturebox[s].Image = Properties.Resources._12;
                        score2 += 10;
                        break;
                    case (13):
                        picturebox[s].Image = Properties.Resources._13;
                        score2 += 10;
                        break;
                    case (14):
                        picturebox[s].Image = Properties.Resources._14;
                        score2 += 11;
                        break;
                    case (15):
                        picturebox[s].Image = Properties.Resources._15;
                        score2 += 2;
                        break;
                    case (16):
                        picturebox[s].Image = Properties.Resources._16;
                        score2 += 3;
                        break;
                    case (17):
                        picturebox[s].Image = Properties.Resources._17;
                        score2 += 4;
                        break;
                    case (18):
                        picturebox[s].Image = Properties.Resources._18;
                        score2 += 5;
                        break;
                    case (19):
                        picturebox[s].Image = Properties.Resources._19;
                        score2 += 6;
                        break;
                    case (20):
                        picturebox[s].Image = Properties.Resources._20;
                        score2 += 7;
                        break;
                    case (21):
                        picturebox[s].Image = Properties.Resources._21;
                        score2 += 8;
                        break;
                    case (22):
                        picturebox[s].Image = Properties.Resources._22;
                        score2 += 9;
                        break;
                    case (23):
                        picturebox[s].Image = Properties.Resources._23;
                        score2 += 10;
                        break;
                    case (24):
                        picturebox[s].Image = Properties.Resources._24;
                        score2 += 10;
                        break;
                    case (25):
                        picturebox[s].Image = Properties.Resources._25;
                        score2 += 10;
                        break;
                    case (26):
                        picturebox[s].Image = Properties.Resources._26;
                        score2 += 10;
                        break;
                    case (27):
                        picturebox[s].Image = Properties.Resources._27;
                        score2 += 11;
                        break;
                    case (28):
                        picturebox[s].Image = Properties.Resources._28;
                        score2 += 2;
                        break;
                    case (29):
                        picturebox[s].Image = Properties.Resources._29;
                        score2 += 3;
                        break;
                    case (30):
                        picturebox[s].Image = Properties.Resources._31;
                        score2 += 4;
                        break;
                    case (31):
                        picturebox[s].Image = Properties.Resources._32;
                        score2 += 5;
                        break;
                    case (32):
                        picturebox[s].Image = Properties.Resources._33;
                        score2 += 6;
                        break;
                    case (33):
                        picturebox[s].Image = Properties.Resources._34;
                        score2 += 7;
                        break;
                    case (34):
                        picturebox[s].Image = Properties.Resources._35;
                        score2 += 8;
                        break;
                    case (35):
                        picturebox[s].Image = Properties.Resources._36;
                        score2 += 9;
                        break;
                    case (36):
                        picturebox[s].Image = Properties.Resources._37;
                        score2 += 10;
                        break;
                    case (37):
                        picturebox[s].Image = Properties.Resources._38;
                        score2 += 10;
                        break;
                    case (38):
                        picturebox[s].Image = Properties.Resources._39;
                        score2 += 10;
                        break;
                    case (39):
                        picturebox[s].Image = Properties.Resources._40;
                        score2 += 10;
                        break;
                    case (40):
                        picturebox[s].Image = Properties.Resources._41;
                        score2 += 11;
                        break;
                    case (41):
                        picturebox[s].Image = Properties.Resources._42;
                        score2 += 2;
                        break;
                    case (42):
                        picturebox[s].Image = Properties.Resources._43;
                        score2 += 3;
                        break;
                    case (43):
                        picturebox[s].Image = Properties.Resources._44;
                        score2 += 4;
                        break;
                    case (44):
                        picturebox[s].Image = Properties.Resources._45;
                        score2 += 5;
                        break;
                    case (45):
                        picturebox[s].Image = Properties.Resources._46;
                        score2 += 6;
                        break;
                    case (46):
                        picturebox[s].Image = Properties.Resources._47;
                        score2 += 7;
                        break;
                    case (47):
                        picturebox[s].Image = Properties.Resources._48;
                        score2 += 8;
                        break;
                    case (48):
                        picturebox[s].Image = Properties.Resources._49;
                        score2 += 9;
                        break;
                    case (49):
                        picturebox[s].Image = Properties.Resources._50;
                        score2 += 10;
                        break;
                    case (50):
                        picturebox[s].Image = Properties.Resources._51;
                        score2 += 10;
                        break;
                    case (51):
                        picturebox[s].Image = Properties.Resources._52;
                        score2 += 10;
                        break;
                    case (52):
                        picturebox[s].Image = Properties.Resources._53;
                        score2 += 10;
                        break;

                    default:
                        break;
                }
                #endregion
                label1.Text = score2.ToString();
                kagitlar.Remove(s);

                for (i = 1; i < 3; i++)
                {
                    s = _random.Next(1, 53);


                    if (kagitlar.ContainsKey(s))
                    {
                        picturebox[s] = new PictureBox();
                        picturebox[s].Name = "picturebox" + i.ToString();
                        picturebox[s].SetBounds(Xlocation, ylocation, 80, 115);//location ve size belirleme
                        Xlocation = Xlocation + 15;

                        this.Controls.Add(picturebox[s]);
                        #region sinir3
                        switch (s)
                        {
                            case (1):
                                picturebox[s].Image = Properties.Resources._1;
                                picturebox[s].BringToFront();
                                score1 += 1;
                                break;
                            case (2):
                                picturebox[s].Image = Properties.Resources._2;
                                picturebox[s].BringToFront();
                                score1 += 2;
                                break;
                            case (3):
                                picturebox[s].Image = Properties.Resources._3;
                                picturebox[s].BringToFront();
                                score1 += 3;
                                break;
                            case (4):
                                picturebox[s].Image = Properties.Resources._4;
                                picturebox[s].BringToFront();
                                score1 += 4;
                                break;
                            case (5):
                                picturebox[s].Image = Properties.Resources._5;
                                picturebox[s].BringToFront();
                                score1 += 5;
                                break;
                            case (6):
                                picturebox[s].Image = Properties.Resources._6;
                                picturebox[s].BringToFront();
                                score1 += 6;
                                break;
                            case (7):
                                picturebox[s].Image = Properties.Resources._7;
                                picturebox[s].BringToFront();
                                score1 += 7;
                                break;
                            case (8):
                                picturebox[s].Image = Properties.Resources._8;
                                picturebox[s].BringToFront();
                                score1 += 8;
                                break;
                            case (9):
                                picturebox[s].Image = Properties.Resources._9;
                                picturebox[s].BringToFront();
                                score1 += 9;
                                break;
                            case (10):
                                picturebox[s].Image = Properties.Resources._10;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (11):
                                picturebox[s].Image = Properties.Resources._11;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (12):
                                picturebox[s].Image = Properties.Resources._12;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (13):
                                picturebox[s].Image = Properties.Resources._13;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (14):
                                picturebox[s].Image = Properties.Resources._14;
                                picturebox[s].BringToFront();
                                score1 += 1;
                                break;
                            case (15):
                                picturebox[s].Image = Properties.Resources._15;
                                picturebox[s].BringToFront();
                                score1 += 2;
                                break;
                            case (16):
                                picturebox[s].Image = Properties.Resources._16;
                                picturebox[s].BringToFront();
                                score1 += 3;
                                break;
                            case (17):
                                picturebox[s].Image = Properties.Resources._17;
                                picturebox[s].BringToFront();
                                score1 += 4;
                                break;
                            case (18):
                                picturebox[s].Image = Properties.Resources._18;
                                picturebox[s].BringToFront();
                                score1 += 5;
                                break;
                            case (19):
                                picturebox[s].Image = Properties.Resources._19;
                                picturebox[s].BringToFront();
                                score1 += 6;
                                break;
                            case (20):
                                picturebox[s].Image = Properties.Resources._20;
                                picturebox[s].BringToFront();
                                score1 += 7;
                                break;
                            case (21):
                                picturebox[s].Image = Properties.Resources._21;
                                picturebox[s].BringToFront();
                                score1 += 8;
                                break;
                            case (22):
                                picturebox[s].Image = Properties.Resources._22;
                                picturebox[s].BringToFront();
                                score1 += 9;
                                break;
                            case (23):
                                picturebox[s].Image = Properties.Resources._23;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (24):
                                picturebox[s].Image = Properties.Resources._24;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (25):
                                picturebox[s].Image = Properties.Resources._25;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (26):
                                picturebox[s].Image = Properties.Resources._26;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (27):
                                picturebox[s].Image = Properties.Resources._27;
                                picturebox[s].BringToFront();
                                score1 += 1;
                                break;
                            case (28):
                                picturebox[s].Image = Properties.Resources._28;
                                picturebox[s].BringToFront();
                                score1 += 2;
                                break;
                            case (29):
                                picturebox[s].Image = Properties.Resources._29;
                                picturebox[s].BringToFront();
                                score1 += 3;
                                break;
                            case (30):
                                picturebox[s].Image = Properties.Resources._31;
                                picturebox[s].BringToFront();
                                score1 += 4;
                                break;
                            case (31):
                                picturebox[s].Image = Properties.Resources._32;
                                picturebox[s].BringToFront();
                                score1 += 5;
                                break;
                            case (32):
                                picturebox[s].Image = Properties.Resources._33;
                                picturebox[s].BringToFront();
                                score1 += 6;
                                break;
                            case (33):
                                picturebox[s].Image = Properties.Resources._34;
                                picturebox[s].BringToFront();
                                score1 += 7;
                                break;
                            case (34):
                                picturebox[s].Image = Properties.Resources._35;
                                picturebox[s].BringToFront();
                                score1 += 8;
                                break;
                            case (35):
                                picturebox[s].Image = Properties.Resources._36;
                                picturebox[s].BringToFront();
                                score1 += 9;
                                break;
                            case (36):
                                picturebox[s].Image = Properties.Resources._37;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (37):
                                picturebox[s].Image = Properties.Resources._38;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (38):
                                picturebox[s].Image = Properties.Resources._39;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (39):
                                picturebox[s].Image = Properties.Resources._40;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (40):
                                picturebox[s].Image = Properties.Resources._41;
                                picturebox[s].BringToFront();
                                score1 += 1;
                                break;
                            case (41):
                                picturebox[s].Image = Properties.Resources._42;
                                picturebox[s].BringToFront();
                                score1 += 2;
                                break;
                            case (42):
                                picturebox[s].Image = Properties.Resources._43;
                                picturebox[s].BringToFront();
                                score1 += 3;
                                break;
                            case (43):
                                picturebox[s].Image = Properties.Resources._44;
                                picturebox[s].BringToFront();
                                score1 += 4;
                                break;
                            case (44):
                                picturebox[s].Image = Properties.Resources._45;
                                picturebox[s].BringToFront();
                                score1 += 5;
                                break;
                            case (45):
                                picturebox[s].Image = Properties.Resources._46;
                                picturebox[s].BringToFront();
                                score1 += 6;
                                break;
                            case (46):
                                picturebox[s].Image = Properties.Resources._47;
                                picturebox[s].BringToFront();
                                score1 += 7;
                                break;
                            case (47):
                                picturebox[s].Image = Properties.Resources._48;
                                picturebox[s].BringToFront();
                                score1 += 8;
                                break;
                            case (48):
                                picturebox[s].Image = Properties.Resources._49;
                                picturebox[s].BringToFront();
                                score1 += 9;
                                break;
                            case (49):
                                picturebox[s].Image = Properties.Resources._50;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (50):
                                picturebox[s].Image = Properties.Resources._51;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (51):
                                picturebox[s].Image = Properties.Resources._52;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;
                            case (52):
                                picturebox[s].Image = Properties.Resources._53;
                                picturebox[s].BringToFront();
                                score1 += 10;
                                break;

                            default:
                                break;
                        }
                        #endregion
                        if (i == 1)
                        {
                            z1 = score1;
                        }
                        else
                        {
                            z2 = score1 - z1;
                        }

                        label2.Text = score1.ToString();
                        kagitlar.Remove(s);
                    }
                    else
                    {

                        i--;
                    }
                }
                if (z1 == z2)
                {
                    button4.Enabled = true;
                }
                if (score1 == 2)
                {
                    button2.Enabled = false;
                    button5.Visible = true;
                    button6.Visible = true;
                }
                if (z1 == 1 || z2 == 1)
                {
                    button2.Enabled = false;
                    button5.Visible = true;
                    button6.Visible = true;
                }
                if ((z1 == 10 && z2 == 1) || (z1 == 1 && z2 == 10))
                {

                    label2.Text = "21";
                    label4.Visible = true;
                    label4.Text = "KAZANDINIZ";
                    button1.Text = "BAŞLA";
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }


            }
        }
        int score1 = 0, score2 = 0, score3 = 0;
        Random _random = new Random();

        private void button2_Click(object sender, EventArgs e)
        {

            if (z3 == 3)
            {
                for (i = 2; i < 3; i++)
                {


                    s = _random.Next(1, 53);


                    if (kagitlar.ContainsKey(s))
                    {
                        picturebox[s] = new PictureBox();
                        picturebox[s].Name = "picturebox" + i.ToString();

                        picturebox[s].SetBounds(Xlocation, ylocation, 80, 115);//location ve size belirleme
                        Xlocation = Xlocation + 15;

                        this.Controls.Add(picturebox[s]);
                        picturebox[s].BringToFront();
                        //SendToBack()
                        #region sinirbozucu
                        switch (s)
                        {
                            case (1):
                                picturebox[s].Image = Properties.Resources._1;
                                score3 += 1;
                                break;
                            case (2):
                                picturebox[s].Image = Properties.Resources._2;
                                score3 += 2;
                                break;
                            case (3):
                                picturebox[s].Image = Properties.Resources._3;
                                score3 += 3;
                                break;
                            case (4):
                                picturebox[s].Image = Properties.Resources._4;
                                score3 += 4;
                                break;
                            case (5):
                                picturebox[s].Image = Properties.Resources._5;
                                score3 += 5;
                                break;
                            case (6):
                                picturebox[s].Image = Properties.Resources._6;
                                score3 += 6;
                                break;
                            case (7):
                                picturebox[s].Image = Properties.Resources._7;
                                score3 += 7;
                                break;
                            case (8):
                                picturebox[s].Image = Properties.Resources._8;
                                score3 += 8;
                                break;
                            case (9):
                                picturebox[s].Image = Properties.Resources._9;
                                score3 += 9;
                                break;
                            case (10):
                                picturebox[s].Image = Properties.Resources._10;
                                score3 += 10;
                                break;
                            case (11):
                                picturebox[s].Image = Properties.Resources._11;
                                score3 += 10;
                                break;
                            case (12):
                                picturebox[s].Image = Properties.Resources._12;
                                score3 += 10;
                                break;
                            case (13):
                                picturebox[s].Image = Properties.Resources._13;
                                score3 += 10;
                                break;
                            case (14):
                                picturebox[s].Image = Properties.Resources._14;
                                score3 += 1;
                                break;
                            case (15):
                                picturebox[s].Image = Properties.Resources._15;
                                score3 += 2;
                                break;
                            case (16):
                                picturebox[s].Image = Properties.Resources._16;
                                score3 += 3;
                                break;
                            case (17):
                                picturebox[s].Image = Properties.Resources._17;
                                score3 += 4;
                                break;
                            case (18):
                                picturebox[s].Image = Properties.Resources._18;
                                score3 += 5;
                                break;
                            case (19):
                                picturebox[s].Image = Properties.Resources._19;
                                score3 += 6;
                                break;
                            case (20):
                                picturebox[s].Image = Properties.Resources._20;
                                score3 += 7;
                                break;
                            case (21):
                                picturebox[s].Image = Properties.Resources._21;
                                score3 += 8;
                                break;
                            case (22):
                                picturebox[s].Image = Properties.Resources._22;
                                score3 += 9;
                                break;
                            case (23):
                                picturebox[s].Image = Properties.Resources._23;
                                score3 += 10;
                                break;
                            case (24):
                                picturebox[s].Image = Properties.Resources._24;
                                score3 += 10;
                                break;
                            case (25):
                                picturebox[s].Image = Properties.Resources._25;
                                score3 += 10;
                                break;
                            case (26):
                                picturebox[s].Image = Properties.Resources._26;
                                score3 += 10;
                                break;
                            case (27):
                                picturebox[s].Image = Properties.Resources._27;
                                score3 += 1;
                                break;
                            case (28):
                                picturebox[s].Image = Properties.Resources._28;
                                score3 += 2;
                                break;
                            case (29):
                                picturebox[s].Image = Properties.Resources._29;
                                score3 += 3;
                                break;
                            case (30):
                                picturebox[s].Image = Properties.Resources._31;
                                score3 += 4;
                                break;
                            case (31):
                                picturebox[s].Image = Properties.Resources._32;
                                score3 += 5;
                                break;
                            case (32):
                                picturebox[s].Image = Properties.Resources._33;
                                score3 += 6;
                                break;
                            case (33):
                                picturebox[s].Image = Properties.Resources._34;
                                score3 += 7;
                                break;
                            case (34):
                                picturebox[s].Image = Properties.Resources._35;
                                score3 += 8;
                                break;
                            case (35):
                                picturebox[s].Image = Properties.Resources._36;
                                score3 += 9;
                                break;
                            case (36):
                                picturebox[s].Image = Properties.Resources._37;
                                score3 += 10;
                                break;
                            case (37):
                                picturebox[s].Image = Properties.Resources._38;
                                score3 += 10;
                                break;
                            case (38):
                                picturebox[s].Image = Properties.Resources._39;
                                score3 += 10;
                                break;
                            case (39):
                                picturebox[s].Image = Properties.Resources._40;
                                score3 += 10;
                                break;
                            case (40):
                                picturebox[s].Image = Properties.Resources._41;
                                score3 += 1;
                                break;
                            case (41):
                                picturebox[s].Image = Properties.Resources._42;
                                score3 += 2;
                                break;
                            case (42):
                                picturebox[s].Image = Properties.Resources._43;
                                score3 += 3;
                                break;
                            case (43):
                                picturebox[s].Image = Properties.Resources._44;
                                score3 += 4;
                                break;
                            case (44):
                                picturebox[s].Image = Properties.Resources._45;
                                score3 += 5;
                                break;
                            case (45):
                                picturebox[s].Image = Properties.Resources._46;
                                score3 += 6;
                                break;
                            case (46):
                                picturebox[s].Image = Properties.Resources._47;
                                score3 += 7;
                                break;
                            case (47):
                                picturebox[s].Image = Properties.Resources._48;
                                score3 += 8;
                                break;
                            case (48):
                                picturebox[s].Image = Properties.Resources._49;
                                score3 += 9;
                                break;
                            case (49):
                                picturebox[s].Image = Properties.Resources._50;
                                score3 += 10;
                                break;
                            case (50):
                                picturebox[s].Image = Properties.Resources._51;
                                score2 += 10;
                                break;
                            case (51):
                                picturebox[s].Image = Properties.Resources._52;
                                score3 += 10;
                                break;
                            case (52):
                                picturebox[s].Image = Properties.Resources._53;
                                score3 += 10;
                                break;

                            default:
                                break;
                        }
                        #endregion
                        label3.Text = score3.ToString();
                        kagitlar.Remove(s);
                    }
                    else
                    {
                        i--;
                    }
                    if (score3 == 21)
                    {
                        label4.Visible = true;
                        label4.Text = "KAZANDINIZ";
                        button1.Text = "BAŞLA";
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;



                    }
                    else if (score3 > 21)
                    {
                        while (true)
                        {
                            for (i = 2; i < 3; i++)
                            {


                                s = _random.Next(1, 53);


                                if (kagitlar.ContainsKey(s))
                                {
                                    picturebox[s] = new PictureBox();
                                    picturebox[s].Name = "picturebox" + i.ToString();
                                    picturebox[s].SetBounds(x2loc, y2loc, 80, 115);//location ve size belirleme
                                    Xlocation = Xlocation + 15;

                                    this.Controls.Add(picturebox[s]);
                                    picturebox[s].BringToFront();
                                    #region sinirbozucu
                                    switch (s)
                                    {
                                        case (1):
                                            picturebox[s].Image = Properties.Resources._1;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (2):
                                            picturebox[s].Image = Properties.Resources._2;
                                            score2 += 2;
                                            break;
                                        case (3):
                                            picturebox[s].Image = Properties.Resources._3;
                                            score2 += 3;
                                            break;
                                        case (4):
                                            picturebox[s].Image = Properties.Resources._4;
                                            score2 += 4;
                                            break;
                                        case (5):
                                            picturebox[s].Image = Properties.Resources._5;
                                            score2 += 5;
                                            break;
                                        case (6):
                                            picturebox[s].Image = Properties.Resources._6;
                                            score2 += 6;
                                            break;
                                        case (7):
                                            picturebox[s].Image = Properties.Resources._7;
                                            score2 += 7;
                                            break;
                                        case (8):
                                            picturebox[s].Image = Properties.Resources._8;
                                            score2 += 8;
                                            break;
                                        case (9):
                                            picturebox[s].Image = Properties.Resources._9;
                                            score2 += 9;
                                            break;
                                        case (10):
                                            picturebox[s].Image = Properties.Resources._10;
                                            score2 += 10;
                                            break;
                                        case (11):
                                            picturebox[s].Image = Properties.Resources._11;
                                            score2 += 10;
                                            break;
                                        case (12):
                                            picturebox[s].Image = Properties.Resources._12;
                                            score2 += 10;
                                            break;
                                        case (13):
                                            picturebox[s].Image = Properties.Resources._13;
                                            score2 += 10;
                                            break;
                                        case (14):
                                            picturebox[s].Image = Properties.Resources._14;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (15):
                                            picturebox[s].Image = Properties.Resources._15;
                                            score2 += 2;
                                            break;
                                        case (16):
                                            picturebox[s].Image = Properties.Resources._16;
                                            score2 += 3;
                                            break;
                                        case (17):
                                            picturebox[s].Image = Properties.Resources._17;
                                            score2 += 4;
                                            break;
                                        case (18):
                                            picturebox[s].Image = Properties.Resources._18;
                                            score2 += 5;
                                            break;
                                        case (19):
                                            picturebox[s].Image = Properties.Resources._19;
                                            score2 += 6;
                                            break;
                                        case (20):
                                            picturebox[s].Image = Properties.Resources._20;
                                            score2 += 7;
                                            break;
                                        case (21):
                                            picturebox[s].Image = Properties.Resources._21;
                                            score2 += 8;
                                            break;
                                        case (22):
                                            picturebox[s].Image = Properties.Resources._22;
                                            score2 += 9;
                                            break;
                                        case (23):
                                            picturebox[s].Image = Properties.Resources._23;
                                            score2 += 10;
                                            break;
                                        case (24):
                                            picturebox[s].Image = Properties.Resources._24;
                                            score2 += 10;
                                            break;
                                        case (25):
                                            picturebox[s].Image = Properties.Resources._25;
                                            score2 += 10;
                                            break;
                                        case (26):
                                            picturebox[s].Image = Properties.Resources._26;
                                            score2 += 10;
                                            break;
                                        case (27):
                                            picturebox[s].Image = Properties.Resources._27;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (28):
                                            picturebox[s].Image = Properties.Resources._28;
                                            score2 += 2;
                                            break;
                                        case (29):
                                            picturebox[s].Image = Properties.Resources._29;
                                            score2 += 3;
                                            break;
                                        case (30):
                                            picturebox[s].Image = Properties.Resources._31;
                                            score2 += 4;
                                            break;
                                        case (31):
                                            picturebox[s].Image = Properties.Resources._32;
                                            score2 += 5;
                                            break;
                                        case (32):
                                            picturebox[s].Image = Properties.Resources._33;
                                            score2 += 6;
                                            break;
                                        case (33):
                                            picturebox[s].Image = Properties.Resources._34;
                                            score2 += 7;
                                            break;
                                        case (34):
                                            picturebox[s].Image = Properties.Resources._35;
                                            score2 += 8;
                                            break;
                                        case (35):
                                            picturebox[s].Image = Properties.Resources._36;
                                            score2 += 9;
                                            break;
                                        case (36):
                                            picturebox[s].Image = Properties.Resources._37;
                                            score2 += 10;
                                            break;
                                        case (37):
                                            picturebox[s].Image = Properties.Resources._38;
                                            score2 += 10;
                                            break;
                                        case (38):
                                            picturebox[s].Image = Properties.Resources._39;
                                            score2 += 10;
                                            break;
                                        case (39):
                                            picturebox[s].Image = Properties.Resources._40;
                                            score2 += 10;
                                            break;
                                        case (40):
                                            picturebox[s].Image = Properties.Resources._41;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (41):
                                            picturebox[s].Image = Properties.Resources._42;
                                            score2 += 2;
                                            break;
                                        case (42):
                                            picturebox[s].Image = Properties.Resources._43;
                                            score2 += 3;
                                            break;
                                        case (43):
                                            picturebox[s].Image = Properties.Resources._44;
                                            score2 += 4;
                                            break;
                                        case (44):
                                            picturebox[s].Image = Properties.Resources._45;
                                            score2 += 5;
                                            break;
                                        case (45):
                                            picturebox[s].Image = Properties.Resources._46;
                                            score2 += 6;
                                            break;
                                        case (46):
                                            picturebox[s].Image = Properties.Resources._47;
                                            score2 += 7;
                                            break;
                                        case (47):
                                            picturebox[s].Image = Properties.Resources._48;
                                            score2 += 8;
                                            break;
                                        case (48):
                                            picturebox[s].Image = Properties.Resources._49;
                                            score2 += 9;
                                            break;
                                        case (49):
                                            picturebox[s].Image = Properties.Resources._50;
                                            score2 += 10;
                                            break;
                                        case (50):
                                            picturebox[s].Image = Properties.Resources._51;
                                            score2 += 10;
                                            break;
                                        case (51):
                                            picturebox[s].Image = Properties.Resources._52;
                                            score2 += 10;
                                            break;
                                        case (52):
                                            picturebox[s].Image = Properties.Resources._53;
                                            score2 += 10;
                                            break;

                                        default:
                                            break;
                                    }
                                    #endregion
                                    label1.Text = score2.ToString();
                                    kagitlar.Remove(s);
                                }
                                else
                                {
                                    i--;
                                }

                            }
                            if (score2 > 17)
                            {
                                break;
                            }
                        }
                        if (score2 <= 21)
                        {
                            label4.Visible = true;
                            label4.Text = "KAYBETTİNİZ";
                            button1.Text = "BAŞLA";
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                        }
                        else
                        {
                            label4.Visible = true;
                            label4.Text = "BERABERE";
                            button1.Text = "BAŞLA";
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                        }

                    }

                }
            }
            else
            {
                for (i = 2; i < 3; i++)
                {


                    s = _random.Next(1, 53);


                    if (kagitlar.ContainsKey(s))
                    {

                        picturebox[s] = new PictureBox();
                        picturebox[s].Name = "picturebox" + i.ToString();
                        picturebox[s].SetBounds(Xlocation, ylocation, 80, 115);//location ve size belirleme
                        Xlocation = Xlocation + 15;

                        this.Controls.Add(picturebox[s]);
                        picturebox[s].BringToFront();
                        #region sinir
                        switch (s)
                        {
                            case (1):
                                picturebox[s].Image = Properties.Resources._1;
                                score1 += 1;
                                break;
                            case (2):
                                picturebox[s].Image = Properties.Resources._2;
                                score1 += 2;
                                break;
                            case (3):
                                picturebox[s].Image = Properties.Resources._3;
                                score1 += 3;
                                break;
                            case (4):
                                picturebox[s].Image = Properties.Resources._4;
                                score1 += 4;
                                break;
                            case (5):
                                picturebox[s].Image = Properties.Resources._5;
                                score1 += 5;
                                break;
                            case (6):
                                picturebox[s].Image = Properties.Resources._6;
                                score1 += 6;
                                break;
                            case (7):
                                picturebox[s].Image = Properties.Resources._7;
                                score1 += 7;
                                break;
                            case (8):
                                picturebox[s].Image = Properties.Resources._8;
                                score1 += 8;
                                break;
                            case (9):
                                picturebox[s].Image = Properties.Resources._9;
                                score1 += 9;
                                break;
                            case (10):
                                picturebox[s].Image = Properties.Resources._10;
                                score1 += 10;
                                break;
                            case (11):
                                picturebox[s].Image = Properties.Resources._11;
                                score1 += 10;
                                break;
                            case (12):
                                picturebox[s].Image = Properties.Resources._12;
                                score1 += 10;
                                break;
                            case (13):
                                picturebox[s].Image = Properties.Resources._13;
                                score1 += 10;
                                break;
                            case (14):
                                picturebox[s].Image = Properties.Resources._14;
                                score1 += 1;
                                break;
                            case (15):
                                picturebox[s].Image = Properties.Resources._15;
                                score1 += 2;
                                break;
                            case (16):
                                picturebox[s].Image = Properties.Resources._16;
                                score1 += 3;
                                break;
                            case (17):
                                picturebox[s].Image = Properties.Resources._17;
                                score1 += 4;
                                break;
                            case (18):
                                picturebox[s].Image = Properties.Resources._18;
                                score1 += 5;
                                break;
                            case (19):
                                picturebox[s].Image = Properties.Resources._19;
                                score1 += 6;
                                break;
                            case (20):
                                picturebox[s].Image = Properties.Resources._20;
                                score1 += 7;
                                break;
                            case (21):
                                picturebox[s].Image = Properties.Resources._21;
                                score1 += 8;
                                break;
                            case (22):
                                picturebox[s].Image = Properties.Resources._22;
                                score1 += 9;
                                break;
                            case (23):
                                picturebox[s].Image = Properties.Resources._23;
                                score1 += 10;
                                break;
                            case (24):
                                picturebox[s].Image = Properties.Resources._24;
                                score1 += 10;
                                break;
                            case (25):
                                picturebox[s].Image = Properties.Resources._25;
                                score1 += 10;
                                break;
                            case (26):
                                picturebox[s].Image = Properties.Resources._26;
                                score1 += 10;
                                break;
                            case (27):
                                picturebox[s].Image = Properties.Resources._27;
                                score1 += 1;
                                break;
                            case (28):
                                picturebox[s].Image = Properties.Resources._28;
                                score1 += 2;
                                break;
                            case (29):
                                picturebox[s].Image = Properties.Resources._29;
                                score1 += 3;
                                break;
                            case (30):
                                picturebox[s].Image = Properties.Resources._31;
                                score1 += 4;
                                break;
                            case (31):
                                picturebox[s].Image = Properties.Resources._32;
                                score1 += 5;
                                break;
                            case (32):
                                picturebox[s].Image = Properties.Resources._33;
                                score1 += 6;
                                break;
                            case (33):
                                picturebox[s].Image = Properties.Resources._34;
                                score1 += 7;
                                break;
                            case (34):
                                picturebox[s].Image = Properties.Resources._35;
                                score1 += 8;
                                break;
                            case (35):
                                picturebox[s].Image = Properties.Resources._36;
                                score1 += 9;
                                break;
                            case (36):
                                picturebox[s].Image = Properties.Resources._37;
                                score1 += 10;
                                break;
                            case (37):
                                picturebox[s].Image = Properties.Resources._38;
                                score1 += 10;
                                break;
                            case (38):
                                picturebox[s].Image = Properties.Resources._39;
                                score1 += 10;
                                break;
                            case (39):
                                picturebox[s].Image = Properties.Resources._40;
                                score1 += 10;
                                break;
                            case (40):
                                picturebox[s].Image = Properties.Resources._41;
                                score1 += 1;
                                break;
                            case (41):
                                picturebox[s].Image = Properties.Resources._42;
                                score1 += 2;
                                break;
                            case (42):
                                picturebox[s].Image = Properties.Resources._43;
                                score1 += 3;
                                break;
                            case (43):
                                picturebox[s].Image = Properties.Resources._44;
                                score1 += 4;
                                break;
                            case (44):
                                picturebox[s].Image = Properties.Resources._45;
                                score1 += 5;
                                break;
                            case (45):
                                picturebox[s].Image = Properties.Resources._46;
                                score1 += 6;
                                break;
                            case (46):
                                picturebox[s].Image = Properties.Resources._47;
                                score1 += 7;
                                break;
                            case (47):
                                picturebox[s].Image = Properties.Resources._48;
                                score1 += 8;
                                break;
                            case (48):
                                picturebox[s].Image = Properties.Resources._49;
                                score1 += 9;
                                break;
                            case (49):
                                picturebox[s].Image = Properties.Resources._50;
                                score1 += 10;
                                break;
                            case (50):
                                picturebox[s].Image = Properties.Resources._51;
                                score1 += 10;
                                break;
                            case (51):
                                picturebox[s].Image = Properties.Resources._52;
                                score1 += 10;
                                break;
                            case (52):
                                picturebox[s].Image = Properties.Resources._53;
                                score1 += 10;
                                break;

                            default:
                                break;
                        }
                        #endregion
                        label2.Text = score1.ToString();
                        kagitlar.Remove(s);
                    }
                    else
                    {
                        i--;
                    }
                    if (score1 > 21 && z3 != 2)
                    {
                        while (score2 < 17)
                        {
                            for (i = 2; i < 3; i++)
                            {


                                s = _random.Next(1, 53);


                                if (kagitlar.ContainsKey(s))
                                {
                                    picturebox[s] = new PictureBox();
                                    picturebox[s].Name = "picturebox" + i.ToString();
                                    picturebox[s].SetBounds(x2loc, y2loc, 80, 115);//location ve size belirleme
                                    x2loc = x2loc + 15;

                                    this.Controls.Add(picturebox[s]);
                                    picturebox[s].BringToFront();
                                    #region sinirbozucu
                                    switch (s)
                                    {
                                        case (1):
                                            picturebox[s].Image = Properties.Resources._1;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (2):
                                            picturebox[s].Image = Properties.Resources._2;
                                            score2 += 2;
                                            break;
                                        case (3):
                                            picturebox[s].Image = Properties.Resources._3;
                                            score2 += 3;
                                            break;
                                        case (4):
                                            picturebox[s].Image = Properties.Resources._4;
                                            score2 += 4;
                                            break;
                                        case (5):
                                            picturebox[s].Image = Properties.Resources._5;
                                            score2 += 5;
                                            break;
                                        case (6):
                                            picturebox[s].Image = Properties.Resources._6;
                                            score2 += 6;
                                            break;
                                        case (7):
                                            picturebox[s].Image = Properties.Resources._7;
                                            score2 += 7;
                                            break;
                                        case (8):
                                            picturebox[s].Image = Properties.Resources._8;
                                            score2 += 8;
                                            break;
                                        case (9):
                                            picturebox[s].Image = Properties.Resources._9;
                                            score2 += 9;
                                            break;
                                        case (10):
                                            picturebox[s].Image = Properties.Resources._10;
                                            score2 += 10;
                                            break;
                                        case (11):
                                            picturebox[s].Image = Properties.Resources._11;
                                            score2 += 10;
                                            break;
                                        case (12):
                                            picturebox[s].Image = Properties.Resources._12;
                                            score2 += 10;
                                            break;
                                        case (13):
                                            picturebox[s].Image = Properties.Resources._13;
                                            score2 += 10;
                                            break;
                                        case (14):
                                            picturebox[s].Image = Properties.Resources._14;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (15):
                                            picturebox[s].Image = Properties.Resources._15;
                                            score2 += 2;
                                            break;
                                        case (16):
                                            picturebox[s].Image = Properties.Resources._16;
                                            score2 += 3;
                                            break;
                                        case (17):
                                            picturebox[s].Image = Properties.Resources._17;
                                            score2 += 4;
                                            break;
                                        case (18):
                                            picturebox[s].Image = Properties.Resources._18;
                                            score2 += 5;
                                            break;
                                        case (19):
                                            picturebox[s].Image = Properties.Resources._19;
                                            score2 += 6;
                                            break;
                                        case (20):
                                            picturebox[s].Image = Properties.Resources._20;
                                            score2 += 7;
                                            break;
                                        case (21):
                                            picturebox[s].Image = Properties.Resources._21;
                                            score2 += 8;
                                            break;
                                        case (22):
                                            picturebox[s].Image = Properties.Resources._22;
                                            score2 += 9;
                                            break;
                                        case (23):
                                            picturebox[s].Image = Properties.Resources._23;
                                            score2 += 10;
                                            break;
                                        case (24):
                                            picturebox[s].Image = Properties.Resources._24;
                                            score2 += 10;
                                            break;
                                        case (25):
                                            picturebox[s].Image = Properties.Resources._25;
                                            score2 += 10;
                                            break;
                                        case (26):
                                            picturebox[s].Image = Properties.Resources._26;
                                            score2 += 10;
                                            break;
                                        case (27):
                                            picturebox[s].Image = Properties.Resources._27;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (28):
                                            picturebox[s].Image = Properties.Resources._28;
                                            score2 += 2;
                                            break;
                                        case (29):
                                            picturebox[s].Image = Properties.Resources._29;
                                            score2 += 3;
                                            break;
                                        case (30):
                                            picturebox[s].Image = Properties.Resources._31;
                                            score2 += 4;
                                            break;
                                        case (31):
                                            picturebox[s].Image = Properties.Resources._32;
                                            score2 += 5;
                                            break;
                                        case (32):
                                            picturebox[s].Image = Properties.Resources._33;
                                            score2 += 6;
                                            break;
                                        case (33):
                                            picturebox[s].Image = Properties.Resources._34;
                                            score2 += 7;
                                            break;
                                        case (34):
                                            picturebox[s].Image = Properties.Resources._35;
                                            score2 += 8;
                                            break;
                                        case (35):
                                            picturebox[s].Image = Properties.Resources._36;
                                            score2 += 9;
                                            break;
                                        case (36):
                                            picturebox[s].Image = Properties.Resources._37;
                                            score2 += 10;
                                            break;
                                        case (37):
                                            picturebox[s].Image = Properties.Resources._38;
                                            score2 += 10;
                                            break;
                                        case (38):
                                            picturebox[s].Image = Properties.Resources._39;
                                            score2 += 10;
                                            break;
                                        case (39):
                                            picturebox[s].Image = Properties.Resources._40;
                                            score2 += 10;
                                            break;
                                        case (40):
                                            picturebox[s].Image = Properties.Resources._41;
                                            if (score2 <= 10)
                                            {
                                                score2 += 11;
                                            }
                                            else if (score2 > 10)
                                            {
                                                score2 += 1;
                                            }
                                            break;
                                        case (41):
                                            picturebox[s].Image = Properties.Resources._42;
                                            score2 += 2;
                                            break;
                                        case (42):
                                            picturebox[s].Image = Properties.Resources._43;
                                            score2 += 3;
                                            break;
                                        case (43):
                                            picturebox[s].Image = Properties.Resources._44;
                                            score2 += 4;
                                            break;
                                        case (44):
                                            picturebox[s].Image = Properties.Resources._45;
                                            score2 += 5;
                                            break;
                                        case (45):
                                            picturebox[s].Image = Properties.Resources._46;
                                            score2 += 6;
                                            break;
                                        case (46):
                                            picturebox[s].Image = Properties.Resources._47;
                                            score2 += 7;
                                            break;
                                        case (47):
                                            picturebox[s].Image = Properties.Resources._48;
                                            score2 += 8;
                                            break;
                                        case (48):
                                            picturebox[s].Image = Properties.Resources._49;
                                            score2 += 9;
                                            break;
                                        case (49):
                                            picturebox[s].Image = Properties.Resources._50;
                                            score2 += 10;
                                            break;
                                        case (50):
                                            picturebox[s].Image = Properties.Resources._51;
                                            score2 += 10;
                                            break;
                                        case (51):
                                            picturebox[s].Image = Properties.Resources._52;
                                            score2 += 10;
                                            break;
                                        case (52):
                                            picturebox[s].Image = Properties.Resources._53;
                                            score2 += 10;
                                            break;

                                        default:
                                            break;
                                    }
                                    #endregion
                                    label1.Text = score2.ToString();
                                    kagitlar.Remove(s);
                                }
                            }
                        }
                        if (score2 < 21)
                        {

                            label4.Visible = true;
                            label4.Text = "KAYBETTİNİZ";
                            button1.Text = "BAŞLA";
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                        }
                        else
                        {

                            label4.Visible = true;
                            label4.Text = "BERABERE";
                            button1.Text = "BAŞLA";
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                        }

                    }
                    else if (score1 == 21)
                    {

                        label4.Visible = true;
                        label4.Text = "KAZANDINIZ";
                        button1.Text = "BAŞLA";
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;



                    }
                    if (score3 > 0 && score1 > 21)
                    {
                        Xlocation = 324;
                        z3 = 3;
                        ok.Image = Properties.Resources.ok1;
                    }
                    button4.Enabled = false;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (score1 == 2)
            {
                score1 = 12;
                label2.Text = score1.ToString();

            }
            if (z3 == 3)
            {
                while (true)
                {
                    for (i = 2; i < 3; i++)
                    {


                        s = _random.Next(1, 53);


                        if (kagitlar.ContainsKey(s))
                        {
                            picturebox[s] = new PictureBox();
                            picturebox[s].Name = "picturebox" + i.ToString();
                            picturebox[s].SetBounds(x2loc, y2loc, 80, 115);//location ve size belirleme
                            x2loc = x2loc + 15;

                            this.Controls.Add(picturebox[s]);
                            picturebox[s].BringToFront();
                            #region sinirbozucu
                            switch (s)
                            {
                                case (1):
                                    picturebox[s].Image = Properties.Resources._1;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (2):
                                    picturebox[s].Image = Properties.Resources._2;
                                    score2 += 2;
                                    break;
                                case (3):
                                    picturebox[s].Image = Properties.Resources._3;
                                    score2 += 3;
                                    break;
                                case (4):
                                    picturebox[s].Image = Properties.Resources._4;
                                    score2 += 4;
                                    break;
                                case (5):
                                    picturebox[s].Image = Properties.Resources._5;
                                    score2 += 5;
                                    break;
                                case (6):
                                    picturebox[s].Image = Properties.Resources._6;
                                    score2 += 6;
                                    break;
                                case (7):
                                    picturebox[s].Image = Properties.Resources._7;
                                    score2 += 7;
                                    break;
                                case (8):
                                    picturebox[s].Image = Properties.Resources._8;
                                    score2 += 8;
                                    break;
                                case (9):
                                    picturebox[s].Image = Properties.Resources._9;
                                    score2 += 9;
                                    break;
                                case (10):
                                    picturebox[s].Image = Properties.Resources._10;
                                    score2 += 10;
                                    break;
                                case (11):
                                    picturebox[s].Image = Properties.Resources._11;
                                    score2 += 10;
                                    break;
                                case (12):
                                    picturebox[s].Image = Properties.Resources._12;
                                    score2 += 10;
                                    break;
                                case (13):
                                    picturebox[s].Image = Properties.Resources._13;
                                    score2 += 10;
                                    break;
                                case (14):
                                    picturebox[s].Image = Properties.Resources._14;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (15):
                                    picturebox[s].Image = Properties.Resources._15;
                                    score2 += 2;
                                    break;
                                case (16):
                                    picturebox[s].Image = Properties.Resources._16;
                                    score2 += 3;
                                    break;
                                case (17):
                                    picturebox[s].Image = Properties.Resources._17;
                                    score2 += 4;
                                    break;
                                case (18):
                                    picturebox[s].Image = Properties.Resources._18;
                                    score2 += 5;
                                    break;
                                case (19):
                                    picturebox[s].Image = Properties.Resources._19;
                                    score2 += 6;
                                    break;
                                case (20):
                                    picturebox[s].Image = Properties.Resources._20;
                                    score2 += 7;
                                    break;
                                case (21):
                                    picturebox[s].Image = Properties.Resources._21;
                                    score2 += 8;
                                    break;
                                case (22):
                                    picturebox[s].Image = Properties.Resources._22;
                                    score2 += 9;
                                    break;
                                case (23):
                                    picturebox[s].Image = Properties.Resources._23;
                                    score2 += 10;
                                    break;
                                case (24):
                                    picturebox[s].Image = Properties.Resources._24;
                                    score2 += 10;
                                    break;
                                case (25):
                                    picturebox[s].Image = Properties.Resources._25;
                                    score2 += 10;
                                    break;
                                case (26):
                                    picturebox[s].Image = Properties.Resources._26;
                                    score2 += 10;
                                    break;
                                case (27):
                                    picturebox[s].Image = Properties.Resources._27;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (28):
                                    picturebox[s].Image = Properties.Resources._28;
                                    score2 += 2;
                                    break;
                                case (29):
                                    picturebox[s].Image = Properties.Resources._29;
                                    score2 += 3;
                                    break;
                                case (30):
                                    picturebox[s].Image = Properties.Resources._31;
                                    score2 += 4;
                                    break;
                                case (31):
                                    picturebox[s].Image = Properties.Resources._32;
                                    score2 += 5;
                                    break;
                                case (32):
                                    picturebox[s].Image = Properties.Resources._33;
                                    score2 += 6;
                                    break;
                                case (33):
                                    picturebox[s].Image = Properties.Resources._34;
                                    score2 += 7;
                                    break;
                                case (34):
                                    picturebox[s].Image = Properties.Resources._35;
                                    score2 += 8;
                                    break;
                                case (35):
                                    picturebox[s].Image = Properties.Resources._36;
                                    score2 += 9;
                                    break;
                                case (36):
                                    picturebox[s].Image = Properties.Resources._37;
                                    score2 += 10;
                                    break;
                                case (37):
                                    picturebox[s].Image = Properties.Resources._38;
                                    score2 += 10;
                                    break;
                                case (38):
                                    picturebox[s].Image = Properties.Resources._39;
                                    score2 += 10;
                                    break;
                                case (39):
                                    picturebox[s].Image = Properties.Resources._40;
                                    score2 += 10;
                                    break;
                                case (40):
                                    picturebox[s].Image = Properties.Resources._41;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (41):
                                    picturebox[s].Image = Properties.Resources._42;
                                    score2 += 2;
                                    break;
                                case (42):
                                    picturebox[s].Image = Properties.Resources._43;
                                    score2 += 3;
                                    break;
                                case (43):
                                    picturebox[s].Image = Properties.Resources._44;
                                    score2 += 4;
                                    break;
                                case (44):
                                    picturebox[s].Image = Properties.Resources._45;
                                    score2 += 5;
                                    break;
                                case (45):
                                    picturebox[s].Image = Properties.Resources._46;
                                    score2 += 6;
                                    break;
                                case (46):
                                    picturebox[s].Image = Properties.Resources._47;
                                    score2 += 7;
                                    break;
                                case (47):
                                    picturebox[s].Image = Properties.Resources._48;
                                    score2 += 8;
                                    break;
                                case (48):
                                    picturebox[s].Image = Properties.Resources._49;
                                    score2 += 9;
                                    break;
                                case (49):
                                    picturebox[s].Image = Properties.Resources._50;
                                    score2 += 10;
                                    break;
                                case (50):
                                    picturebox[s].Image = Properties.Resources._51;
                                    score2 += 10;
                                    break;
                                case (51):
                                    picturebox[s].Image = Properties.Resources._52;
                                    score2 += 10;
                                    break;
                                case (52):
                                    picturebox[s].Image = Properties.Resources._53;
                                    score2 += 10;
                                    break;

                                default:
                                    break;
                            }
                            #endregion
                            label1.Text = score2.ToString();
                            kagitlar.Remove(s);
                        }
                        else
                        {
                            i--;
                        }


                    }
                    if (score2 > 16)
                    {
                        break;
                    }
                }
                if (score2 == 21)
                {
                    if (score1 == 21 || score3 == 21)
                    {

                        label4.Text = "BERABERE";
                        label4.Visible = true;

                    }
                    else
                    {
                        label4.Text = "KAYBETTİNİZ";
                        label4.Visible = true;
                    }

                }
                else if (score2 > 21)
                {
                    if (score1 <= 21 || score3 <= 21)
                    {
                        label4.Text = "KAZANDINIZ";
                        label4.Visible = true;

                    }
                    else
                    {
                        label4.Text = "BERABERE";
                        label4.Visible = true;

                    }
                }
                else
                {
                    if (score1 == 21 || score3 == 21)
                    {
                        label4.Text = "KAZANDINIZ";
                        label4.Visible = true;

                    }
                    else if ((score3 < 21 && score3 > score2) || (score1 < 21 && score1 > score2))
                    {
                        label4.Text = "KAZANDINIZ";
                        label4.Visible = true;

                    }
                    else
                    {
                        label4.Text = "KAYBETİNİZ";
                        label4.Visible = true;

                    }
                }

            }
            else if (z3 == 2)
            {

                ok.Image = Properties.Resources.ok1;
                z3++;
                Xlocation = 324;
                if (label3.Text == "1")
                {
                    button2.Enabled = false;
                    button5.Visible = true;
                    button6.Visible = true;
                }
            }

            else
            {


                while (true)
                {
                    for (i = 2; i < 3; i++)
                    {


                        s = _random.Next(1, 53);


                        if (kagitlar.ContainsKey(s))
                        {
                            picturebox[s] = new PictureBox();
                            picturebox[s].Name = "picturebox" + i.ToString();
                            picturebox[s].SetBounds(x2loc, y2loc, 80, 115);//location ve size belirleme
                            x2loc = x2loc + 15;
                            this.Controls.Add(picturebox[s]);
                            picturebox[s].BringToFront();
                            #region sinirbozucu
                            switch (s)
                            {
                                case (1):
                                    picturebox[s].Image = Properties.Resources._1;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (2):
                                    picturebox[s].Image = Properties.Resources._2;
                                    score2 += 2;
                                    break;
                                case (3):
                                    picturebox[s].Image = Properties.Resources._3;
                                    score2 += 3;
                                    break;
                                case (4):
                                    picturebox[s].Image = Properties.Resources._4;
                                    score2 += 4;
                                    break;
                                case (5):
                                    picturebox[s].Image = Properties.Resources._5;
                                    score2 += 5;
                                    break;
                                case (6):
                                    picturebox[s].Image = Properties.Resources._6;
                                    score2 += 6;
                                    break;
                                case (7):
                                    picturebox[s].Image = Properties.Resources._7;
                                    score2 += 7;
                                    break;
                                case (8):
                                    picturebox[s].Image = Properties.Resources._8;
                                    score2 += 8;
                                    break;
                                case (9):
                                    picturebox[s].Image = Properties.Resources._9;
                                    score2 += 9;
                                    break;
                                case (10):
                                    picturebox[s].Image = Properties.Resources._10;
                                    score2 += 10;
                                    break;
                                case (11):
                                    picturebox[s].Image = Properties.Resources._11;
                                    score2 += 10;
                                    break;
                                case (12):
                                    picturebox[s].Image = Properties.Resources._12;
                                    score2 += 10;
                                    break;
                                case (13):
                                    picturebox[s].Image = Properties.Resources._13;
                                    score2 += 10;
                                    break;
                                case (14):
                                    picturebox[s].Image = Properties.Resources._14;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (15):
                                    picturebox[s].Image = Properties.Resources._15;
                                    score2 += 2;
                                    break;
                                case (16):
                                    picturebox[s].Image = Properties.Resources._16;
                                    score2 += 3;
                                    break;
                                case (17):
                                    picturebox[s].Image = Properties.Resources._17;
                                    score2 += 4;
                                    break;
                                case (18):
                                    picturebox[s].Image = Properties.Resources._18;
                                    score2 += 5;
                                    break;
                                case (19):
                                    picturebox[s].Image = Properties.Resources._19;
                                    score2 += 6;
                                    break;
                                case (20):
                                    picturebox[s].Image = Properties.Resources._20;
                                    score2 += 7;
                                    break;
                                case (21):
                                    picturebox[s].Image = Properties.Resources._21;
                                    score2 += 8;
                                    break;
                                case (22):
                                    picturebox[s].Image = Properties.Resources._22;
                                    score2 += 9;
                                    break;
                                case (23):
                                    picturebox[s].Image = Properties.Resources._23;
                                    score2 += 10;
                                    break;
                                case (24):
                                    picturebox[s].Image = Properties.Resources._24;
                                    score2 += 10;
                                    break;
                                case (25):
                                    picturebox[s].Image = Properties.Resources._25;
                                    score2 += 10;
                                    break;
                                case (26):
                                    picturebox[s].Image = Properties.Resources._26;
                                    score2 += 10;
                                    break;
                                case (27):
                                    picturebox[s].Image = Properties.Resources._27;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (28):
                                    picturebox[s].Image = Properties.Resources._28;
                                    score2 += 2;
                                    break;
                                case (29):
                                    picturebox[s].Image = Properties.Resources._29;
                                    score2 += 3;
                                    break;
                                case (30):
                                    picturebox[s].Image = Properties.Resources._31;
                                    score2 += 4;
                                    break;
                                case (31):
                                    picturebox[s].Image = Properties.Resources._32;
                                    score2 += 5;
                                    break;
                                case (32):
                                    picturebox[s].Image = Properties.Resources._33;
                                    score2 += 6;
                                    break;
                                case (33):
                                    picturebox[s].Image = Properties.Resources._34;
                                    score2 += 7;
                                    break;
                                case (34):
                                    picturebox[s].Image = Properties.Resources._35;
                                    score2 += 8;
                                    break;
                                case (35):
                                    picturebox[s].Image = Properties.Resources._36;
                                    score2 += 9;
                                    break;
                                case (36):
                                    picturebox[s].Image = Properties.Resources._37;
                                    score2 += 10;
                                    break;
                                case (37):
                                    picturebox[s].Image = Properties.Resources._38;
                                    score2 += 10;
                                    break;
                                case (38):
                                    picturebox[s].Image = Properties.Resources._39;
                                    score2 += 10;
                                    break;
                                case (39):
                                    picturebox[s].Image = Properties.Resources._40;
                                    score2 += 10;
                                    break;
                                case (40):
                                    picturebox[s].Image = Properties.Resources._41;
                                    if (score2 <= 10)
                                    {
                                        score2 += 11;
                                    }
                                    else if (score2 > 10)
                                    {
                                        score2 += 1;
                                    }
                                    break;
                                case (41):
                                    picturebox[s].Image = Properties.Resources._42;
                                    score2 += 2;
                                    break;
                                case (42):
                                    picturebox[s].Image = Properties.Resources._43;
                                    score2 += 3;
                                    break;
                                case (43):
                                    picturebox[s].Image = Properties.Resources._44;
                                    score2 += 4;
                                    break;
                                case (44):
                                    picturebox[s].Image = Properties.Resources._45;
                                    score2 += 5;
                                    break;
                                case (45):
                                    picturebox[s].Image = Properties.Resources._46;
                                    score2 += 6;
                                    break;
                                case (46):
                                    picturebox[s].Image = Properties.Resources._47;
                                    score2 += 7;
                                    break;
                                case (47):
                                    picturebox[s].Image = Properties.Resources._48;
                                    score2 += 8;
                                    break;
                                case (48):
                                    picturebox[s].Image = Properties.Resources._49;
                                    score2 += 9;
                                    break;
                                case (49):
                                    picturebox[s].Image = Properties.Resources._50;
                                    score2 += 10;
                                    break;
                                case (50):
                                    picturebox[s].Image = Properties.Resources._51;
                                    score2 += 10;
                                    break;
                                case (51):
                                    picturebox[s].Image = Properties.Resources._52;
                                    score2 += 10;
                                    break;
                                case (52):
                                    picturebox[s].Image = Properties.Resources._53;
                                    score2 += 10;
                                    break;

                                default:
                                    break;
                            }
                            #endregion
                            label1.Text = score2.ToString();
                            kagitlar.Remove(s);
                        }
                        else
                        {
                            i--;
                        }

                    }
                    if (score2 == 21)
                    {
                        label4.Visible = true;
                        label4.Text = "KAYBETTİNİZ";
                        break;
                    }
                    else if (score2 < 21 && score2 >= 17)
                    {
                        if (score2 < score1)
                        {
                            label4.Visible = true;
                            label4.Text = "TEBRİKLER KAZANDINIZ";
                            break;
                        }
                        else if (score1 < score2)
                        {
                            label4.Visible = true;
                            label4.Text = "KAYBETTİNİZ";
                            break;
                        }
                        else
                        {
                            label4.Visible = true;
                            label4.Text = "BERABERE";
                            break;
                        }
                    }
                    else if (score2 > 21)
                    {
                        label4.Visible = true;
                        label4.Text = "TEBRİKLER KAZANDINIZ";
                        break;
                    }
                }

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            z3++;
            score1 = z1;
            label2.Text = z1.ToString();
            score3 = z1;
            label3.Text = z1.ToString();
            button4.Enabled = false;
            label3.Visible = true;
            ok.Visible = true;

            picturebox[s].SetBounds(Xlocation + 199, ylocation, 80, 115);
            Xlocation = Xlocation - 15;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (z3 == 3)
            {
                score3 = score3 + 10;
                label3.Text = score3.ToString();
                button2.Enabled = true;
                button5.Visible = false;
                button6.Visible = false;
            }
            else
            {
                score1 = score1 + 10;
                label2.Text = score1.ToString();
                button2.Enabled = true;
                button5.Visible = false;
                button6.Visible = false;
            }

        }

    }


}

