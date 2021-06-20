using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUESTION_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void predict() {
            string[] names = new string[] { "I see a tall, dark stranger in your future.",
                "Something you lost will turn up soon.",
                "Plan for many pleasures ahead."
                ,"The one you love is closer than you think.",
                "A thrilling time is in your near future.",
                "A secret admirer will soon send you a sign of affection.",
                "Your heart is in a place to draw true happiness." };
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            // Console.WriteLine($"Name: {names[index]}");
            switch (index) {
                case 0:
                    label1.Text = "Your Predictions Are : " + names[index];
                    panel1.BackColor = Color.Goldenrod;
                    label1.BackColor = Color.AliceBlue;
                    break;
                case 1:
                    label1.Text = "Your Predictions Are : " + names[index];
                    label1.BackColor = Color.BlueViolet;
                    panel1.BackColor = Color.DarkBlue;
                    break;
                case 2:
                    label1.Text = "Your Predictions Are : " + names[index];
                    label1.BackColor = Color.BurlyWood;
                    panel1.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    label1.Text = "Your Predictions Are : " + names[index];
                    label1.BackColor = Color.Ivory;
                    panel1.BackColor = Color.DarkViolet;
                    break;
                case 4:
                    label1.Text = "Your Predictions Are : " + names[index];
                    label1.BackColor = Color.DarkGreen;
                    panel1.BackColor = Color.LemonChiffon;
                    break;
                case 5:
                    label1.Text = "Your Predictions Are : " + names[index];
                    label1.BackColor = Color.DarkGoldenrod;
                    panel1.BackColor = Color.Firebrick;
                    break;
                case 6:
                    label1.Text = "Your Predictions Are : " + names[index];
                    label1.BackColor = Color.CornflowerBlue;
                    panel1.BackColor = Color.Lavender;
                    break;
            }
          


        }
        private void button1_Click(object sender, EventArgs e)
        {
            predict();

        }
    }
}
