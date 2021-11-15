using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048DEMO
{
    class mapa
    {
       
        public void CriarPics()
        {
            /*/
            pics[0, 0] = new PictureBox(); 
            labels[0, 0] = new Label();
            labels[0, 0].Text = "2";
            labels[0, 0].Size = new Size(50, 50);
            labels[0, 0].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 0].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[0, 0].Controls.Add(labels[0, 0]);
            pics[0, 0].Location = new Point(12, 73);
            pics[0, 0].Size = new Size(50, 50);
            pics[0, 0].BackColor = Color.Yellow;
            this.Controls.Add(pics[0, 0]);
            pics[0, 0].BringToFront();

            pics[0, 1] = new PictureBox();
            labels[0, 1] = new Label();
            labels[0, 1].Text = "2";
            labels[0, 1].Size = new Size(50, 50);
            labels[0, 1].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 1].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[0, 1].Controls.Add(labels[0, 1]);
            pics[0, 1].Location = new Point(68, 73);
            pics[0, 1].Size = new Size(50, 50);
            pics[0, 1].BackColor = Color.Yellow;
            this.Controls.Add(pics[0, 1]);
            pics[0, 1].BringToFront();/*/
        }
        /*/
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
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + 56, pics[k, j].Location.Y);
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
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "Score: " + score;
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
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - 56, pics[k, j].Location.Y);
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
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "Score: " + score;
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
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y + 56);
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
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "Score: " + score;
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
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y - 56);
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
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "Score: " + score;
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
                GenerateNewPic();
        }/*/
    }
}
