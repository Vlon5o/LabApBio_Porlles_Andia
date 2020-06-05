using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApBio_Porlles_Andia
{
    public partial class Form1 : Form
    {
        Bitmap imgbit1, imgbit2; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfldg = new OpenFileDialog();

            if (openfldg.ShowDialog() == DialogResult.OK)
            {
                ptbxImg1.ImageLocation = openfldg.FileName;
                imgbit1 = new Bitmap(openfldg.FileName);
            }
        }

        private void btnImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfldg = new OpenFileDialog();

            if (openfldg.ShowDialog() == DialogResult.OK) 
            {
                ptbxImg2.ImageLocation = openfldg.FileName;
                imgbit2 = new Bitmap(openfldg.FileName);
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            bool comparar = CompararImagen(imgbit1, imgbit2);
            if (comparar == true)
            {
                MessageBox.Show("las huellas son iguales");
            }
            else
            {
                MessageBox.Show("las huellas no son iguales");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool CompararImagen(Bitmap imgbit1, Bitmap imgbit2)
        {
            MemoryStream ms = new MemoryStream(); 
            imgbit1.Save(ms, ImageFormat.Bmp); 
            string priimgbit = Convert.ToBase64String(ms.ToArray()); 
            ms.Position = 0;
            imgbit2.Save(ms, ImageFormat.Bmp);
            string segimgbit = Convert.ToBase64String(ms.ToArray());
            if (priimgbit.Equals(segimgbit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
