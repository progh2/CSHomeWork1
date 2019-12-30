using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        int[] myIntArray = new int[10];
        Random r = new Random();
        String result = "";

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                this.myIntArray[i] = r.Next(100);
            }

            foreach (int num in myIntArray)
            {
                result = result + " " + num;
            }

            lblResult.Text = result;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(myIntArray);
            result = "";
            foreach (int num in myIntArray)
            {
                result = result + " " + num;
            }

            lblResult.Text = result;
        }
    }
}
