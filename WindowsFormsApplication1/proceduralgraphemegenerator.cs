using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void b1_Click_1(object sender, EventArgs e)
        {
            Process proc = Process.Start("cave_maker.exe", "16 16 56 8 8 6 88");
            pictureBox2.Image=Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File001.bmp");
            pictureBox3.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File002.bmp");
            pictureBox4.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File003.bmp");
            pictureBox5.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File004.bmp");
            pictureBox6.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File005.bmp");
            pictureBox7.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File006.bmp");
            pictureBox8.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File007.bmp");
            pictureBox9.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File008.bmp");
            pictureBox10.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File009.bmp");
            pictureBox11.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File010.bmp");
            pictureBox12.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File011.bmp");
            pictureBox13.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File012.bmp");
            pictureBox14.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File013.bmp");
            pictureBox15.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File014.bmp");
            pictureBox16.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File015.bmp");
            pictureBox17.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File016.bmp");
            pictureBox18.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File017.bmp");
            pictureBox19.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File018.bmp");
            pictureBox20.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File019.bmp");
            pictureBox21.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File020.bmp");
            pictureBox22.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File021.bmp");
            pictureBox23.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File022.bmp");
            pictureBox24.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File023.bmp");
            
            pictureBox26.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File025.bmp");
            pictureBox27.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File026.bmp");
            pictureBox28.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File027.bmp");
            pictureBox29.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File028.bmp");
            pictureBox30.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File029.bmp");
            pictureBox31.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File030.bmp");
            pictureBox32.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File031.bmp");
            pictureBox33.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File032.bmp");
            pictureBox34.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File033.bmp");
            pictureBox35.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File034.bmp");
            pictureBox36.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File035.bmp");
            pictureBox37.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File036.bmp");
            pictureBox38.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File037.bmp");
            pictureBox39.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File038.bmp");
            pictureBox40.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File039.bmp");
            pictureBox41.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File040.bmp");
            pictureBox42.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File041.bmp");
            pictureBox43.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File042.bmp");
            pictureBox44.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File043.bmp");
            pictureBox45.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File044.bmp");
            pictureBox46.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File045.bmp");
            pictureBox47.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File046.bmp");
            pictureBox48.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File047.bmp");
            pictureBox49.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File048.bmp");
            pictureBox50.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File049.bmp");
            pictureBox51.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File050.bmp");
            pictureBox52.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File051.bmp");
            pictureBox53.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File052.bmp");
            pictureBox54.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File053.bmp");
            pictureBox55.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File054.bmp");
            pictureBox56.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File055.bmp");
            pictureBox57.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File056.bmp");
            pictureBox58.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File057.bmp");
            pictureBox59.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File058.bmp");
            pictureBox60.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File059.bmp");
            pictureBox61.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File060.bmp");
            pictureBox62.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File061.bmp");
            pictureBox63.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File062.bmp");
            pictureBox64.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File063.bmp");
            pictureBox65.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File064.bmp");
            pictureBox66.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File065.bmp");
            pictureBox67.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File066.bmp");
            pictureBox68.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File067.bmp");
            pictureBox69.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File068.bmp");
            pictureBox70.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File069.bmp");
            pictureBox71.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File070.bmp");
            pictureBox72.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File071.bmp");
            pictureBox73.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File072.bmp");
            pictureBox74.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File073.bmp");
            pictureBox75.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File074.bmp");
            pictureBox76.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File075.bmp");
            pictureBox77.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File076.bmp");
            pictureBox78.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File077.bmp");
            pictureBox79.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File078.bmp");
            pictureBox80.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File079.bmp");
            pictureBox81.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File080.bmp");
            pictureBox82.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File081.bmp");
            pictureBox83.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File082.bmp");
            pictureBox84.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File083.bmp");
            pictureBox85.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File084.bmp");
            pictureBox86.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File085.bmp");
            pictureBox87.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File086.bmp");
            pictureBox88.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File087.bmp");
            pictureBox89.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File088.bmp");
            pictureBox90.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File089.bmp");
            pictureBox91.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File090.bmp");
            pictureBox92.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File091.bmp");
            pictureBox93.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File092.bmp");
            pictureBox94.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File093.bmp");
            pictureBox95.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File094.bmp");
            pictureBox96.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File095.bmp");
            pictureBox97.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File096.bmp");
            pictureBox98.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File097.bmp");
            pictureBox99.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File098.bmp");
            //pictureBox100.Image = Image.FromFile(@"C:\Users\Aravind\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\bin\Debug\File024.bmp");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player =
        new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-00a.wav");
            player.Play();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
       new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-01a.wav");
            player.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
       new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-02a.wav");
            player.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
       new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-03a.wav");
            player.Play();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
       new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-04a.wav");
            player.Play();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
       new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-05a.wav");
            player.Play();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-06a.wav");
            player.Play();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-07a.wav");
            player.Play();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-08a.wav");
            player.Play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-09a.wav");
            player.Play();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-10a.wav");
            player.Play();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-11a.wav");
            player.Play();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-12a.wav");
            player.Play();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-13a.wav");
            player.Play();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-14a.wav");
            player.Play();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-15a.wav");
            player.Play();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-16a.wav");
            player.Play();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-17a.wav");
            player.Play();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-18a.wav");
            player.Play();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-19a.wav");
            player.Play();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-20a.wav");
            player.Play();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-21a.wav");
            player.Play();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-22a.wav");
            player.Play();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-23a.wav");
            player.Play();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-24a.wav");
            player.Play();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-25a.wav");
            player.Play();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-26a.wav");
            player.Play();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-27a.wav");
            player.Play();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-28a.wav");
            player.Play();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-29a.wav");
            player.Play();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-30a.wav");
            player.Play();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-31a.wav");
            player.Play();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-32a.wav");
            player.Play();
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-33a.wav");
            player.Play();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-34a.wav");
            player.Play();
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-35a.wav");
            player.Play();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-36a.wav");
            player.Play();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-37a.wav");
            player.Play();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-38a.wav");
            player.Play();
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-39a.wav");
            player.Play();
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-40a.wav");
            player.Play();
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-41a.wav");
            player.Play();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-42a.wav");
            player.Play();
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-43a.wav");
            player.Play();
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-44a.wav");
            player.Play();
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-45a.wav");
            player.Play();
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-46a.wav");
            player.Play();
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-47a.wav");
            player.Play();
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-48a.wav");
            player.Play();
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-49a.wav");
            player.Play();
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-50a.wav");
            player.Play();
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-51a.wav");
            player.Play();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-52a.wav");
            player.Play();
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-53a.wav");
            player.Play();
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-54a.wav");
            player.Play();
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-55a.wav");
            player.Play();
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-56a.wav");
            player.Play();
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\pulmonic consonants\Con-57a.wav");
            player.Play();
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-58a.wav");
            player.Play();

        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-59a.wav");
            player.Play();
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-60a.wav");
            player.Play();
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-61a.wav");
            player.Play();
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-62a.wav");
            player.Play();
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-67a.wav");
            player.Play();
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-66a.wav");
            player.Play();
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-65a.wav");
            player.Play();
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-64a.wav");
            player.Play();
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\consonants\nonpulmonic consonants\Con-63a.wav");
            player.Play();
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-00a.wav");
            player.Play();
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-01a.wav");
            player.Play();
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-02a.wav");
            player.Play();
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-03a.wav");
            player.Play();
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-04a.wav");
            player.Play();
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-05a.wav");
            player.Play();
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-06a.wav");
            player.Play();
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-07a.wav");
            player.Play();
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-08a.wav");
            player.Play();
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-09a.wav");
            player.Play();
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-10a.wav");
            player.Play();
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-11a.wav");
            player.Play();
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-12a.wav");
            player.Play();
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-13a.wav");
            player.Play();
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-14a.wav");
            player.Play();
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-15a.wav");
            player.Play();
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-16a.wav");
            player.Play();
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-17a.wav");
            player.Play();
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-18a.wav");
            player.Play();
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-19a.wav");
            player.Play();
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-20a.wav");
            player.Play();
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-21a.wav");
            player.Play();
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-22a.wav");
            player.Play();
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-23a.wav");
            player.Play();
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-24a.wav");
            player.Play();
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-25a.wav");
            player.Play();
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-26a.wav");
            player.Play();
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player =
     new System.Media.SoundPlayer(@"C:\Users\Aravind\Desktop\IPA sounds\vowels\Vow-27a.wav");
            player.Play();
        }
    }
}
