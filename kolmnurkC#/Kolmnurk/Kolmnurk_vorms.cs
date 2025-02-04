﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolmnurk
{
    public partial class Kolmnurk_vorms : Form
    {
        public Kolmnurk_vorms()
        {
            InitializeComponent();
        }

        private void Kolmnurk_vorms_Load(object sender, EventArgs e)
        {

        }

        private void Arvuta_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            Triangle t=new Triangle(a, b, c);
            lv.Items.Clear(); //   очищаем список перед добавлением новых элементов
            lv.Items.Add("Külg A");
            lv.Items[0].SubItems.Add(t.OutputA());
            lv.Items.Add("Külg B");
            lv.Items[1].SubItems.Add(t.OutputB());
            lv.Items.Add("Külg C");
            lv.Items[2].SubItems.Add(t.OutputC());
            Triangle triangle = new Triangle(a, b, c);
            lv.Items.Add("Ümbermõõt");
            lv.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            lv.Items.Add("Pindala");
            lv.Items[4].SubItems.Add(Convert.ToString(triangle.PerimentrL()));
            lv.Items.Add("Eksisteerib");
            if (triangle.ExistTriangle) { lv.Items[5].SubItems.Add("Jah"); }
            else lv.Items[5].SubItems.Add("Ei");
            lv.Items.Add("Spetsifikaator");
            lv.Items[6].SubItems.Add(triangle.TriangleType);
            lv.Items.Add("Nurgapoolitaja pikkus");
            lv.Items[7].SubItems.Add(Convert.ToString(triangle.Bisector()));
            // получаем PictureBox 
            PictureBox pictureBox = pictureBox1;

            // метод для изменения картинки с типом треугольника
            triangle.ImageTriangleType(pictureBox);


        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
