﻿using System;
using System.Windows.Forms;

namespace DietKuyDesktop5
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                //buat objek Form1 untuk membukanya scr otomatis
                FrmLogin frmLogin = new FrmLogin();
                this.Hide();
                frmLogin.Show();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
