using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjeknoProjekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            karoPicBox.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
            pikPicBox.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\pik.png");
            srcePicBox.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\srce.png");
            trefPicBox.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\tref.png");
            logoPicBox.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\logo.png");

        }

        int brojacPolja = 1;
        int[] trenutnaKombinacija = new int[4];

        private void karoPicBox_Click(object sender, EventArgs e)
        {
            switch (brojacPolja)
            {
                case 1:
                    slika1.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 2:
                    slika2.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 3:
                    slika3.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 4:
                    slika4.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 5:
                    slika5.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 6:
                    slika6.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 7:
                    slika7.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 8:
                    slika8.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 9:
                    slika9.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 10:
                    slika10.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 11:
                    slika11.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 12:
                    slika12.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 13:
                    slika13.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 14:
                    slika14.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 15:
                    slika15.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 16:
                    slika16.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 17:
                    slika17.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 18:
                    slika18.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 19:
                    slika19.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 20:
                    slika20.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 21:
                    slika21.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 22:
                    slika22.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 23:
                    slika23.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
                case 24:
                    slika24.Image = Image.FromFile(@"C:\Users\Nikola\Desktop\OOP projekat\karo.png");
                    trenutnaKombinacija[brojacPolja % 4] = 1;
                    break;
            }

            ++brojacPolja;

            //if brojac polja deljiv sa 4 prikazi tacnost

        }

        private void pikPicBox_Click(object sender, EventArgs e)
        {

        }

        private void srcePicBox_Click(object sender, EventArgs e)
        {

        }

        private void trefPicBox_Click(object sender, EventArgs e)
        {

        }

        private void logoPicBox_Click(object sender, EventArgs e)
        {

        }
    }
}
