using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _2048DEMO
{
    public partial class Form1 : Form
    {
        public int[,] map = new int[4, 4];
        public Label[,] labels = new Label[4, 4];
        public PictureBox[,] pics = new PictureBox[4, 4];
        private int score = 0;
        public string line;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnKeyboardPressed);
            CreateMap();
            CreatePics();
            pictureBox1.SendToBack();
            using (StreamReader sr = new StreamReader("best.txt"))
            {
                line = sr.ReadLine();
                label4.Text = line;
            }
        }
        public void GenerateNewPic()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);
            while (pics[a, b] != null)
            {
                a = rnd.Next(0, 4);
                b = rnd.Next(0, 4);
            }
            int num = rnd.Next(0, 101);
            if(num == 69)
            {
                map[a, b] = 1;
                pics[a, b] = new PictureBox();
                labels[a, b] = new Label();
                labels[a, b].Text = "4";
                labels[a, b].Size = new Size(99, 99);
                labels[a, b].TextAlign = ContentAlignment.MiddleCenter;
                labels[a, b].Font = new Font(new FontFamily("Arial Black"), 25);
                pics[a, b].Controls.Add(labels[a, b]);
                pics[a, b].Location = new Point(13 + b * 109, 116 + 109 * a);
                pics[a, b].Size = new Size(99, 99);
                pics[a, b].BackColor = Color.FromArgb(237, 224, 200);
                this.Controls.Add(pics[a, b]);
                pics[a, b].BringToFront();
            }
            else
            {
                map[a, b] = 1;
                pics[a, b] = new PictureBox();
                labels[a, b] = new Label();
                labels[a, b].Text = "2";
                labels[a, b].Size = new Size(99, 99);
                labels[a, b].TextAlign = ContentAlignment.MiddleCenter;
                labels[a, b].Font = new Font(new FontFamily("Arial Black"), 25);
                pics[a, b].Controls.Add(labels[a, b]);
                pics[a, b].Location = new Point(13 + b * 109, 116 + 109 * a);
                pics[a, b].Size = new Size(99, 99);
                pics[a, b].BackColor = Color.FromArgb(238, 228, 218);
                this.Controls.Add(pics[a, b]);
                pics[a, b].BringToFront();
            }
        }
        public void CreateMap()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(13 + 109 * j, 116 + 109 * i);
                    pic.Size = new Size(99, 99);
                    Image myimage = new Bitmap(@".\Imagens\unnamed.png");
                    pic.Image = myimage;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pic);
                }
            }
        }

        private void ChangeColor(int sum, int k, int j)
        {
            if (sum == 2048) 
            {
                pics[k, j].BackColor = Color.FromArgb(237, 194, 45);
            }
            else if (sum == 1024)
            {
                pics[k, j].BackColor = Color.FromArgb(237, 197, 63);
            }
            else if (sum == 512)
            {
                pics[k, j].BackColor = Color.FromArgb(237, 200, 80);
            }
            else if (sum == 256)
            {
                pics[k, j].BackColor = Color.FromArgb(237, 204, 98);
            }
            else if (sum == 128)
            {
                pics[k, j].BackColor = Color.FromArgb(237, 207, 115);
            }
            else if (sum == 64)
            {
                pics[k, j].BackColor = Color.FromArgb(246, 94, 59);
            }
            else if (sum == 32)
            {
                pics[k, j].BackColor = Color.FromArgb(246, 124, 96);
            }
            else if (sum == 16)
            {
                pics[k, j].BackColor = Color.FromArgb(245, 149, 99);
            }
            else if (sum == 8)
            {
                pics[k, j].BackColor = Color.FromArgb(242, 177, 121);
            }
            else
            {
                pics[k, j].BackColor = Color.FromArgb(237, 224, 200);
            }
        }
        public void CreatePics()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);

            map[a, b] = 1;
            pics[a, b] = new PictureBox();
            labels[a, b] = new Label();
            labels[a, b].Text = "2";
            labels[a, b].Size = new Size(99, 99);
            labels[a, b].TextAlign = ContentAlignment.MiddleCenter;
            labels[a, b].Font = new Font(new FontFamily("Arial Black"), 25);
            pics[a, b].Controls.Add(labels[a, b]);
            pics[a, b].Location = new Point(13 + b * 109, 116 + 109 * a);
            pics[a, b].Size = new Size(99, 99);
            pics[a, b].BackColor = Color.FromArgb(238, 228, 218);
            this.Controls.Add(pics[a, b]);
            pics[a, b].BringToFront();
            
            int c = rnd.Next(0, 4);
            int d = rnd.Next(0, 4);
            while (c == a && d == b)
            {
                c = rnd.Next(0, 4);
                d = rnd.Next(0, 4);
            }
            int num = rnd.Next(0, 101);
            if (num == 69)
            {
                map[c, d] = 1;
                pics[c, d] = new PictureBox();
                labels[c, d] = new Label();
                labels[c, d].Text = "4";
                labels[c, d].Size = new Size(99, 99);
                labels[c, d].TextAlign = ContentAlignment.MiddleCenter;
                labels[c, d].Font = new Font(new FontFamily("Arial Black"), 25);
                pics[c, d].Controls.Add(labels[c, d]);
                pics[c, d].Location = new Point(13 + c * 109, 116 + 109 * d);
                pics[c, d].Size = new Size(99, 99);
                pics[c, d].BackColor = Color.FromArgb(237, 224, 200);
                this.Controls.Add(pics[c, d]);
                pics[c, d].BringToFront();
            }
            else
            {
                map[c, d] = 1;
                pics[c, d] = new PictureBox();
                labels[c, d] = new Label();
                labels[c, d].Text = "2";
                labels[c, d].Size = new Size(99, 99);
                labels[c, d].TextAlign = ContentAlignment.MiddleCenter;
                labels[c, d].Font = new Font(new FontFamily("Arial Black"), 25);
                pics[c, d].Controls.Add(labels[c, d]);
                pics[c, d].Location = new Point(13 + c * 109, 116 + 109 * d);
                pics[c, d].Size = new Size(99, 99);
                pics[c, d].BackColor = Color.FromArgb(238, 228, 218);
                this.Controls.Add(pics[c, d]);
                pics[c, d].BringToFront();
            }
        }
        public void OnKeyboardPressed(object sender, KeyEventArgs e)
        {
            bool ifPicWasMoved = false;

            switch (e.KeyCode.ToString())
            {
                case "Right":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 2; l >= 0; l--)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l + 1; j < 4; j++)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j - 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j - 1];
                                        pics[k, j - 1] = null;
                                        labels[k, j] = labels[k, j - 1];
                                        labels[k, j - 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + 109, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j - 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            if(score > Int32.Parse(line))
                                            {
                                                using (StreamWriter sw = new StreamWriter("best.txt"))
                                                {
                                                    sw.Write(score);
                                                }
                                            }
                                            ChangeColor(a + b, k, j);
                                            label1.Text = score.ToString();
                                            map[k, j - 1] = 0;
                                            this.Controls.Remove(pics[k, j - 1]);
                                            this.Controls.Remove(labels[k, j - 1]);
                                            pics[k, j - 1] = null;
                                            labels[k, j - 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Left":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 1; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l - 1; j >= 0; j--)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j + 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j + 1];
                                        pics[k, j + 1] = null;
                                        labels[k, j] = labels[k, j + 1];
                                        labels[k, j + 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - 109, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j + 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            if (score > Int32.Parse(line))
                                            {
                                                using (StreamWriter sw = new StreamWriter("best.txt"))
                                                {
                                                    sw.Write(score);
                                                }
                                            }
                                            ChangeColor(a + b, k, j);
                                            label1.Text = score.ToString();
                                            map[k, j + 1] = 0;
                                            this.Controls.Remove(pics[k, j + 1]);
                                            this.Controls.Remove(labels[k, j + 1]);
                                            pics[k, j + 1] = null;
                                            labels[k, j + 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Down":
                    for (int k = 2; k >= 0; k--)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k + 1; j < 4; j++)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j - 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j - 1, l];
                                        pics[j - 1, l] = null;
                                        labels[j, l] = labels[j - 1, l];
                                        labels[j - 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y + 109);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j - 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            if (score > Int32.Parse(line))
                                            {
                                                using (StreamWriter sw = new StreamWriter("best.txt"))
                                                {
                                                    sw.Write(score);
                                                }
                                            }
                                            ChangeColor(a + b, j, l);
                                            label1.Text = score.ToString();
                                            map[j - 1, l] = 0;
                                            this.Controls.Remove(pics[j - 1, l]);
                                            this.Controls.Remove(labels[j - 1, l]);
                                            pics[j - 1, l] = null;
                                            labels[j - 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Up":
                    for (int k = 1; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k - 1; j >= 0; j--)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j + 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j + 1, l];
                                        pics[j + 1, l] = null;
                                        labels[j, l] = labels[j + 1, l];
                                        labels[j + 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y - 109);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j + 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            if (score > Int32.Parse(line))
                                            {
                                                using (StreamWriter sw = new StreamWriter("best.txt"))
                                                {
                                                    sw.Write(score);
                                                }
                                            }
                                            ChangeColor(a + b, j, l);
                                            label1.Text = score.ToString();
                                            map[j + 1, l] = 0;
                                            this.Controls.Remove(pics[j + 1, l]);
                                            this.Controls.Remove(labels[j + 1, l]);
                                            pics[j + 1, l] = null;
                                            labels[j + 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
            if (ifPicWasMoved)
            {
                GenerateNewPic();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
