using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BurgerApp_Capítulo_2
{
    public partial class BurgerApp : Form
    {
        public BurgerApp()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        
}

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCje2d3O0phy0kzg926AYmhw");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRebaixado frmRebaixado = new FrmRebaixado();
            frmRebaixado.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer SuperIdol = new SoundPlayer(@"Super Idol.wav");
                        SuperIdol.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=qZTjBfPNhiA");
        }
    }
}
