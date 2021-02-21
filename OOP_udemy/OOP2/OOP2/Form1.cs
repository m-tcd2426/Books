﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = LoginInfo.Member.GetName();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // シルバー 0
            // ゴールド 20%
            // プラチナ 40%

            var value = Convert.ToInt32(InputTextBox.Text);
            ResultLabel.Text = (value * LoginInfo.Member.GetRate()).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var f = new Form2())
            {
                f.ShowDialog();
            }
        }
    }
}
