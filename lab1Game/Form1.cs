using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            сохранитьКакToolStripMenuItem.Enabled = false;
            OpenFileDialog Fdia = new OpenFileDialog();
            Fdia.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | All files(*.*) | *.* ";
            if (Fdia.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    pictureBox1.Image = new Bitmap(Fdia.FileName);
                }
                catch 
                {
                    MessageBox.Show("Невозможно открыть данный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) 
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true; 
                sfd.Filter = "Image Files(*.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | All files(*.*) | *.* ";
                sfd.ShowHelp = true; 
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox2.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonGrey_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap InputImage = new Bitmap(pictureBox1.Image);
                Bitmap OutputImage = new Bitmap(InputImage.Width, InputImage.Height);
                for (int i = 0; i < InputImage.Width; i++) 
                {
                    for (int j = 0; j < InputImage.Height; j++) 
                    {
                        UInt32 pixel = (UInt32)(InputImage.GetPixel(i, j).ToArgb());

                        float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                        float B = (float)(pixel & 0x000000FF); // синий

                        R = G = B = (R + G + B) / 3.0f;
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        OutputImage.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                }
                pictureBox2.Image = OutputImage;
                сохранитьКакToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Картинка не загружена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Увеличение контрастности на N процентов:
             I = (I • 100 – 128 • N) / (100 – N)
             I – соответственно R, G, B каналы каждой точки изображения.
             Если I меньше 0 или больше 255 обрезаем
             */
            if (pictureBox1.Image != null)
            {
                Bitmap InputImage = new Bitmap(pictureBox1.Image);
                Bitmap OutputImage = new Bitmap(InputImage.Width, InputImage.Height);
                for (int i = 0; i < InputImage.Width; i++)
                {
                    for (int j = 0; j < InputImage.Height; j++)
                    {
                        UInt32 pixel = (UInt32)(InputImage.GetPixel(i, j).ToArgb());
                        double R = (double)((pixel & 0x00FF0000) >> 16); // красный
                        double G = (double)((pixel & 0x0000FF00) >> 8); // зеленый
                        double B = (double)(pixel & 0x000000FF); // синий

                        R = (R * 100 - 128 * 50) / (100 - 50);
                        if (R > 255)
                        {
                            R = 255;
                        }
                        else if (R < 0) 
                        {
                            R = 0;
                        }
                        G = (G * 100 - 128 * 50) / (100 - 50);
                        if (G > 255)
                        {
                            G = 255;
                        }
                        else if (G < 0)
                        {
                            G = 0;
                        }
                        B = (B * 100 - 128 * 50) / (100 - 50);
                        if (B > 255)
                        {
                            B = 255;
                        }
                        else if (B < 0)
                        {
                            B = 0;
                        }
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        OutputImage.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                }
                pictureBox2.Image = OutputImage;
                сохранитьКакToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Картинка не загружена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap InputImage = new Bitmap(pictureBox1.Image);
                Bitmap OutputImage = new Bitmap(InputImage.Width, InputImage.Height);
                for (int i = 0; i < InputImage.Width; i++)
                {
                    for (int j = 0; j < InputImage.Height; j++)
                    {
                        UInt32 pixel = (UInt32)(InputImage.GetPixel(i, j).ToArgb());

                        float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                        float B = (float)(pixel & 0x000000FF); // синий

                        R = G;
                        G = B;
                        B = R;
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        OutputImage.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                }
                pictureBox2.Image = OutputImage;
                сохранитьКакToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Картинка не загружена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap InputImage = new Bitmap(pictureBox1.Image);
            Bitmap OutputImage = new Bitmap(InputImage.Width, InputImage.Height);
            OutputImage = InputImage;
            OutputImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = OutputImage;
            сохранитьКакToolStripMenuItem.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap InputImage = new Bitmap(pictureBox1.Image);
            Bitmap OutputImage = new Bitmap(InputImage.Width, InputImage.Height);
            OutputImage = InputImage;
            OutputImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox2.Image = OutputImage;
            сохранитьКакToolStripMenuItem.Enabled = true;
        }
//-----------------------------------------------------------------------------------------------------------------------------------------


        //размыть
        private void button5_Click(object sender, EventArgs e)
        {
            UInt32[,] pixel;
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap OutputImage = new Bitmap(image.Width, image.Height);
            pixel = new UInt32[image.Height, image.Width];
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());
            pixel = matrix_filtration(image.Width, image.Height, pixel, N2, blur);
            pictureBox2.Image = FromPixelToBitmap(OutputImage,pixel);
        }

        //преобразование из UINT32 to Bitmap
        public static Bitmap FromPixelToBitmap(Bitmap image, UInt32[,] pixel)
        {
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    image.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
            return image;
        }










        struct RGB
        {
            public float R;
            public float G;
            public float B;
        }


        UInt32[,] matrix_filtration(int W, int H, UInt32[,] pixel, int N, double[,] matryx)
        {


            int i, j, k, m, gap = (int)(N / 2);
            int tmpH = H + 2 * gap, tmpW = W + 2 * gap;
            UInt32[,] tmppixel = new UInt32[tmpH, tmpW];
            UInt32[,] newpixel = new UInt32[H, W];
            //заполнение временного расширенного изображения
            //углы
            for (i = 0; i < gap; i++)
                for (j = 0; j < gap; j++)
                {
                    tmppixel[i, j] = pixel[0, 0];
                    tmppixel[i, tmpW - 1 - j] = pixel[0, W - 1];
                    tmppixel[tmpH - 1 - i, j] = pixel[H - 1, 0];
                    tmppixel[tmpH - 1 - i, tmpW - 1 - j] = pixel[H - 1, W - 1];
                }
            //крайние левая и правая стороны
            for (i = gap; i < tmpH - gap; i++)
                for (j = 0; j < gap; j++)
                {
                    tmppixel[i, j] = pixel[i - gap, j];
                    tmppixel[i, tmpW - 1 - j] = pixel[i - gap, W - 1 - j];
                }
            //крайние верхняя и нижняя стороны
            for (i = 0; i < gap; i++)
                for (j = gap; j < tmpW - gap; j++)
                {
                    tmppixel[i, j] = pixel[i, j - gap];
                    tmppixel[tmpH - 1 - i, j] = pixel[H - 1 - i, j - gap];
                }
            //центр
            for (i = 0; i < H; i++)
                for (j = 0; j < W; j++)
                    tmppixel[i + gap, j + gap] = pixel[i, j];
            //применение ядра свертки
            RGB ColorOfPixel = new RGB();
            RGB ColorOfCell = new RGB();
            for (i = gap; i < tmpH - gap; i++)
                for (j = gap; j < tmpW - gap; j++)
                {
                    ColorOfPixel.R = 0;
                    ColorOfPixel.G = 0;
                    ColorOfPixel.B = 0;
                    for (k = 0; k < N; k++)
                        for (m = 0; m < N; m++)
                        {
                            ColorOfCell = calculationOfColor(tmppixel[i - gap + k, j - gap + m], matryx[k, m]);
                            ColorOfPixel.R += ColorOfCell.R;
                            ColorOfPixel.G += ColorOfCell.G;
                            ColorOfPixel.B += ColorOfCell.B;
                        }
                    //контролируем переполнение переменных
                    if (ColorOfPixel.R < 0) ColorOfPixel.R = 0;
                    if (ColorOfPixel.R > 255) ColorOfPixel.R = 255;
                    if (ColorOfPixel.G < 0) ColorOfPixel.G = 0;
                    if (ColorOfPixel.G > 255) ColorOfPixel.G = 255;
                    if (ColorOfPixel.B < 0) ColorOfPixel.B = 0;
                    if (ColorOfPixel.B > 255) ColorOfPixel.B = 255;

                    newpixel[i - gap, j - gap] = build(ColorOfPixel);
                }

            return newpixel;
        }

        //вычисление нового цвета
        RGB calculationOfColor(UInt32 pixel, double coefficient)
        {
            RGB Color = new RGB();
            Color.R = (float)(coefficient * ((pixel & 0x00FF0000) >> 16));
            Color.G = (float)(coefficient * ((pixel & 0x0000FF00) >> 8));
            Color.B = (float)(coefficient * (pixel & 0x000000FF));
            return Color;
        }

        //сборка каналов
        UInt32 build(RGB ColorOfPixel)
        {
            UInt32 Color;
            Color = 0xFF000000 | ((UInt32)ColorOfPixel.R << 16) | ((UInt32)ColorOfPixel.G << 8) | ((UInt32)ColorOfPixel.B);
            return Color;
        }








        //повышение резкости
        public const int N1 = 3;
        public static double[,] sharpness = new double[N1, N1] {{-1, -1, -1},
                                                               {-1,  9, -1},
                                                               {-1, -1, -1}};

        //размытие
        public const int N2 = 3;
        public static double[,] blur = new double[N1, N1] {{0.111, 0.111, 0.111},
                                                               {0.111, 0.111, 0.111},
                                                               {0.111, 0.111, 0.111}};

    }
}
